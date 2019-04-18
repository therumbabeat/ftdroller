using System;
using System.Collections.Generic;
using System.Linq;

namespace FtDRoller
{
    using SkillValue = Int32;

    class CharacterSheet
    {
        public enum Consequence { Mild, Medium, Severe };

        public String Name { get; set; }
        public uint FatePoints { get; set; }
        public uint MaxChakra { get; set; }
        public uint Chakra { get; set; }
        public uint PhysicalStressTrack { get; set;  }
        public uint MentalStressTrack { get; set; }
        public List<String> Aspects { get; set; } = new List<String>();
        public HashSet<Consequence> PhysicalConsequences { get; set; } = new HashSet<Consequence>();
        public HashSet<Consequence> MentalConsequences { get; set; } = new HashSet<Consequence>();

        /*
         * Skill and Technique values are held as triplets of: the base value, modifier which counts for Aspect Bonuses,
         * and modifier which doesn't count for Aspect Bonuses. Only the base value dictionary actually contains all of
         * the skill names as keys, the modifier dictionaries only contain the ones for which modifiers actually exist.
         * The values are presumed to be 0 if no entry is present.
         */
        public Dictionary<String, SkillValue> BaseSkillValues { get; set; } = new Dictionary<String, SkillValue>();
        public Dictionary<String, SkillValue> AspectSkillModifiers { get; } = new Dictionary<String, SkillValue>();
        public Dictionary<String, SkillValue> NonAspectSkillModifiers { get; } = new Dictionary<String, SkillValue>();

        private Random RNG = new Random();

        public CharacterSheet()
        {}

        public SkillValue GetSkillValue(String skillName) {
            var baseValue = BaseSkillValues[skillName];
            SkillValue aspectModifier = 0;
            SkillValue nonAspectModifier = 0;
            AspectSkillModifiers.TryGetValue(skillName, out aspectModifier);
            NonAspectSkillModifiers.TryGetValue(skillName, out nonAspectModifier);
            return baseValue + aspectModifier + nonAspectModifier;
        }

        public int RollFudgeDice() {
            int sum = 0;
            for (int ctr = 0; ctr < 4; ++ctr) {
                sum += RollFudgeDie();
            }
            return sum;
        }

        public int RollFudgeDie() {
            return RNG.Next(-1, 2) * 3;
        }

        public int RollSkill(String skillName) {
            var skillValue = GetSkillValue(skillName);
            var diceValue = RollFudgeDice();
            return (int)(skillValue + diceValue);
        }
        public int RollSkill(String skillName, ICollection<RollModifier> modifiers)
        {
            var skillValue = GetSkillValue(skillName);
            foreach (var modifier in modifiers) {
                skillValue += modifier.GetValue(skillName, this);
            }
            var diceValue = RollFudgeDice();
            return (int)(skillValue + diceValue);
        }

        public int RollSkillAgainst(String skillName, int opposingValue) {
            return RollSkill(skillName) - opposingValue;
        }

        public int RollSkillAgainst(String skillName, int opposingValue, ICollection<RollModifier> modifiers)
        {
            return RollSkill(skillName, modifiers) - opposingValue;
        }

        public void ApplyModifiers(ICollection<CharacterSheetModifier> modifiers) {
            foreach (var modifier in modifiers) {
                modifier.Apply(this);
            }
        }

        public void ClearModifiers() {
            AspectSkillModifiers.Clear();
            NonAspectSkillModifiers.Clear();
        }

        public Dictionary<String, SkillValue> GetSkillValues() {
            var skillValues = BaseSkillValues.ToDictionary(entry => entry.Key, entry => entry.Value);
            foreach (var kv in AspectSkillModifiers) {
                skillValues[kv.Key] += kv.Value;
            }
            foreach (var kv in NonAspectSkillModifiers) {
                skillValues[kv.Key] += kv.Value;
            }
            return skillValues;
        }

        public int GetAspectBonus(String skillName) {
            var baseValue = BaseSkillValues[skillName];
            SkillValue aspectModifier = 0;
            AspectSkillModifiers.TryGetValue(skillName, out aspectModifier);
            var aspectValue = baseValue + aspectModifier;
            return (int)Math.Floor((double)aspectValue / 10) + 1;
        }
    }

    abstract class CharacterSheetModifier
    {
        public String Name { get; set; }
        public String SkillName { get; set; }
        public Boolean ModifiesAspectBonus { get; set; }
        public void Apply(CharacterSheet characterSheet)
        {
            SkillValue modifierValue = 0;
            var skillValues = GetSkillValueDictionary(characterSheet);
            skillValues.TryGetValue(SkillName, out modifierValue);
            modifierValue += GetValue(characterSheet);
            skillValues[SkillName] = modifierValue;
        }

        abstract protected SkillValue GetValue(CharacterSheet characterSheet);

        private Dictionary<String, SkillValue> GetSkillValueDictionary(CharacterSheet characterSheet) {
            if (ModifiesAspectBonus)
            {
                return characterSheet.AspectSkillModifiers;
            } else {
                return characterSheet.NonAspectSkillModifiers;
            }
        }
    }

    class StaticCharacterBuff : CharacterSheetModifier
    {
        public SkillValue Value { get; set; }
        override protected SkillValue GetValue(CharacterSheet CharacterSheet) {
            return Value;
        }
    }

    abstract class RollModifier
    {
        abstract public SkillValue GetValue(String SkillName, CharacterSheet characterSheet);
    }

    class AspectBonus : RollModifier
    {
        override public SkillValue GetValue(String SkillName, CharacterSheet characterSheet)
        {
            return (SkillValue)characterSheet.GetAspectBonus(SkillName);
        }
    }
}
