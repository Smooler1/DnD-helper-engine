using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Helper_Engine
{
    public class Character
    {
        public string charName { get; set; }
        public List<string> MajorCharacteristics { get; set; } = new List<string>();
        public List<string> MediumCharacteristics { get; set; } = new List<string>();
        public List<string> MinorCharacteristics { get; set; } = new List<string>();
        public List<string> StrongAbilities { get; set; } = new List<string>();
        public List<string> WeakAbilities { get; set; } = new List<string>();
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }

    }
}
