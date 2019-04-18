using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace FtDRoller
{
    public class CharacterSheetTests
    {
        private static IEnumerable<int> dieRollValues = Enumerable.Range(-1, 3).Select(x => x * 3);
        private static IEnumerable<int> fudgeRollValues = Enumerable.Range(-4, 9).Select(x => x * 3);
        private CharacterSheet characterSheet;
        private StaticCharacterBuff ironNerve;
        private StaticCharacterBuff pangolinGauntlets;
        private AspectBonus punchesHard;

        public CharacterSheetTests()
        {
            characterSheet = new CharacterSheet
            {
                Name = "Kurosawa Hazou",
                FatePoints = 7,
                Chakra = 130,
                MaxChakra = 130,
                PhysicalStressTrack = 3,
                MentalStressTrack = 3,
                Aspects = {
                    "Creative Idealist",
                    "Open Mouth, Insert Foot",
                    "Lists and Plans",
                    "Promising Sealing Student",
                    "(Formerly) Marked for Death",
                    "The Hokage is My New Dad",
                    "Team Uplift"
                },
                BaseSkillValues = new Dictionary<String, int>
                {
                    ["Taijutsu"] = 40,
                    ["Deceit "] = 24,
                    ["Stealth"] = 15,
                    ["Sealing"] = 20,
                    ["Craftsmanship (Calligraphy)"] = 14,
                    ["Cracking"] = 1,
                    ["Chakra Reserves"] = 13,
                    ["Empathy"] = 10,
                    ["Examination"] = 5,
                    ["Intimidation "] = 5,
                    ["Medical Knowledge"] = 0,
                    ["Medical Ninjutsu "] = 0,
                    ["Melee Weapons "] = 5,
                    ["Performance"] = 4,
                    ["Physique"] = 21,
                    ["Presence"] = 15,
                    ["Rapport"] = 10,
                    ["Ranged Weapons"] = 4,
                    ["Resolve"] = 20,
                    ["Survival"] = 1,
                    ["Technique Hacking"] = 0,
                    ["Cooking"] = 1,
                }
            };
            ironNerve = new StaticCharacterBuff
            {
                Name = "Iron Nerve",
                SkillName = "Taijutsu",
                ModifiesAspectBonus = true,
                Value = 3
            };
            pangolinGauntlets = new StaticCharacterBuff
            {
                Name = "Pangolin Gauntlets",
                SkillName = "Taijutsu",
                ModifiesAspectBonus = false,
                Value = 3
            };
            punchesHard = new AspectBonus();
        }

        private static IEnumerable<int> GetValidRollValues(int skillValue)
        {
            return fudgeRollValues.Select(x => x + skillValue);
        }

        [Fact]
        public void FudgeDieRoll()
        {
            var rollValue = characterSheet.RollFudgeDie();
            Assert.Contains(rollValue, dieRollValues);
        }

        [Fact]
        public void FudgeDiceRolls()
        {
            var rollValue = characterSheet.RollFudgeDice();
            Assert.Contains(rollValue, fudgeRollValues);
        }

        [Fact]
        public void SkillModifiers()
        {
            var skillName = ironNerve.SkillName;
            var baseSkillValue = characterSheet.BaseSkillValues[skillName];
            characterSheet.ApplyModifiers(new List<CharacterSheetModifier> { ironNerve });
            Assert.Equal(characterSheet.GetSkillValue(skillName), baseSkillValue + ironNerve.Value);
            characterSheet.ApplyModifiers(new List<CharacterSheetModifier> { pangolinGauntlets });
            Assert.Equal(characterSheet.GetSkillValue(skillName), baseSkillValue + ironNerve.Value + pangolinGauntlets.Value);
        }
        [Fact]
        public void AspectBonusCalculation()
        {
            var skillName = ironNerve.SkillName;
            characterSheet.BaseSkillValues[skillName] = 39;
            var oldAspectBonus = characterSheet.GetAspectBonus(skillName);
            characterSheet.ApplyModifiers(new List<CharacterSheetModifier> { ironNerve });
            var newAspectBonus = characterSheet.GetAspectBonus(skillName);
            Assert.Equal(newAspectBonus, oldAspectBonus + 1);

            // Check that the non aspect affecting buff really doesn't affect the bonus
            characterSheet.BaseSkillValues[skillName] = 39;
            oldAspectBonus = characterSheet.GetAspectBonus(skillName);
            characterSheet.ApplyModifiers(new List<CharacterSheetModifier> { pangolinGauntlets });
            newAspectBonus = characterSheet.GetAspectBonus(skillName);
            Assert.Equal(newAspectBonus, oldAspectBonus);
        }

        [Fact]
        public void RollModifiers()
        {
            var skillName = "Taijutsu";
            int skillValue = characterSheet.GetSkillValue(skillName);
            var skillRoll = characterSheet.RollSkill(skillName);
            Assert.Contains(skillRoll, GetValidRollValues(skillValue));

            skillRoll = characterSheet.RollSkill(skillName, new List<RollModifier> { punchesHard });
            Assert.Contains(skillRoll, GetValidRollValues(skillValue + characterSheet.GetAspectBonus(skillName)));
        }
    }
}

