using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FtDRoller
{
    static class Program
    {
        static CharacterSheet characterSheet = new CharacterSheet {
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
            BaseSkillValues = new Dictionary<String, int> {
                ["Taijutsu"] = 43,
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
        }
    }
}
