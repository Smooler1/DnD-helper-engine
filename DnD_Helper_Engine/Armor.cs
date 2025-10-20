using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Helper_Engine
{
    public class Armor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpecialEffect { get; set; }
    }
    public static class ArmorRepository
    {

        public static List<Armor> allArmor { get; } = new List<Armor>()
        {
        new Armor { Name = "Hunter's garb", Type = "intermediate", SpecialEffect = "/" },
        new Armor { Name = "Yharnam's hunter's garb", Type = "intermediate", SpecialEffect = "+1D6 persuasion yharnamite" },
        new Armor { Name = "Tomb prospector's garb", Type = "intermediate", SpecialEffect = "+1D6 persuasion clergy" },
        new Armor { Name = "Knight's uniform", Type = "light", SpecialEffect = "+1D6 persuasion clergy" },
        new Armor { Name = "Student's uniform", Type = "light", SpecialEffect = "+1D6 persuasion scholars" },
        new Armor { Name = "Sweat stained clothes", Type = "light", SpecialEffect = "+1D6 persuasion lowlives" },
        };


    }
}
