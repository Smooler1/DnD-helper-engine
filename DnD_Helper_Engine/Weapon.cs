using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Helper_Engine
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Damage { get; set; }
        public string SpecialEffect { get; set; }
        public int Durability { get; set; }
    }
    public class Ranged_Weapon : Weapon
    {
        public int Range { get; set; }
        public int Bullets { get; set; }
    }

    public class Melee_Weapon : Weapon { }

    public static class WeaponRepository
    {
        public static List<Weapon> AllWeapons { get; } = new List<Weapon>
        {
            new Melee_Weapon { Name = "Saw Cleaver", Type = "Intermediate", Damage = "2D6+3", SpecialEffect = "/", Durability = 10 },
    new Melee_Weapon { Name = "Saw-Spear", Type = "Intermediate", Damage = "2D6+2 / 1D6+4", SpecialEffect = "Nothing / +1D6 initiative", Durability = 10 },
    new Melee_Weapon { Name = "Hunter's Axe", Type = "Heavy / Intermediate", Damage = "2D6+4 / 2D6+2", SpecialEffect = "+1D6 initiative / can use firearm", Durability = 12 },
    new Melee_Weapon { Name = "Whip Cane", Type = "Intermediate", Damage = "2D6+2", SpecialEffect = "Area of effect (1D6 dmg to nearby enemies)", Durability = 10 },
    new Melee_Weapon { Name = "Hammer-Sword", Type = "Heavy / Intermediate", Damage = "2D6+5 / 2D6+2", SpecialEffect = "Nothing / can use firearm", Durability = 12 },
    new Melee_Weapon { Name = "Reiterpallasch", Type = "Light", Damage = "3D6", SpecialEffect = "Initiative +1D6, Ranged", Durability = 8 },
    new Melee_Weapon { Name = "Bayonet Rifle", Type = "Intermediate", Damage = "2D6+2", SpecialEffect = "AOE gun mode (1D6 to others), Ranged", Durability = 8 },

    new Ranged_Weapon { Name = "Pistol", Type = "Intermediate", Damage = "1D6+3", SpecialEffect = "Nothing", Durability = 10, Bullets = 10 },
    new Ranged_Weapon { Name = "Tromblon", Type = "Intermediate", Damage = "2D6+1", SpecialEffect = "AoE (1D6 extra)", Durability = 8, Bullets = 5 },
    new Ranged_Weapon { Name = "Sniper Rifle", Type = "Light", Damage = "2D6+4", SpecialEffect = "Twice range", Durability = 10, Bullets = 10 },
    new Ranged_Weapon { Name = "Flamethrower", Type = "Intermediate", Damage = "1D6+3", SpecialEffect = "AoE full dmg (3 enemies)", Durability = 12, Bullets = 15 }
};


    }
    }

