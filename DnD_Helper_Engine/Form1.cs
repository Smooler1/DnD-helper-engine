using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;




namespace DnD_Helper_Engine
{
    public partial class Form1 : Form
    {
        private Character user_character = new Character();
        public List<string> Chosen_major_characteristics = new List<string>();
        public List<string> Chosen_medium_characteristics = new List<string>();
        public List<string> Chosen_minor_characteristics = new List<string>();

        private List<Character> allCharacters = new List<Character>();



        public Form1()
        {
            InitializeComponent();

        }

        private void RefreshStatsBox()
        {
            string weaponText = "None";
            if (user_character.EquippedWeapon != null)
            {  weaponText = user_character.EquippedWeapon.Name;}

            string armorText = "None";
            if (user_character.EquippedArmor != null)
            { armorText = user_character.EquippedArmor.Name;}
         



            string strongText = "";
            for (int i = 0; i < user_character.StrongAbilities.Count; i++) 
            {
                if (i > 0 && i % 2 == 0)
                    strongText += ", \n";
                strongText += user_character.StrongAbilities[i];

                if (i % 2 == 0 && i + 1 < user_character.StrongAbilities.Count)
                    strongText += ", ";
            }

            
                string weakText = "";
            if (user_character.StrongAbilities.Count == 6)
            {
                for (int i = 0; i < user_character.WeakAbilities.Count; i++)
                {
                    if (i > 0 && i % 2 == 0)
                        weakText += ", \n";
                    weakText += user_character.WeakAbilities[i];

                    if (i % 2 == 0 && i + 1 < user_character.WeakAbilities.Count)
                        weakText += ", ";
                }
            }


            string mediumText = "";
    for (int i = 0; i < Chosen_medium_characteristics.Count; i++)
    {
        if (i > 0 && i % 2 == 0)      // after every 2 items
            mediumText += ",\n";

        mediumText += Chosen_medium_characteristics[i];

        // add a comma if it’s not the last item in the current line and not at a newline break
        if (i % 2 == 0 && i + 1 < Chosen_medium_characteristics.Count)
            mediumText += ", ";
    }

            Stats_Characteristics_and_stuff_lbl.Text = "Characteristics\n\n" +
                $"Major: {string.Join(", ", Chosen_major_characteristics)}\n\n" +
                $"Medium: {mediumText}\n\n" +
                $"Minor: {string.Join(", ", Chosen_minor_characteristics)}\n\n\n" +
                "Abilities\n\n" +
                $"Strong: {strongText}\n\n" +
                $"Weak: {weakText}\n\n\n" +
                "Equipment\n\n" +
                $"Weapon: {weaponText}\n" +
                $"Armor: {armorText}";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            var armorList = new List<Armor>
            {
    new Armor { Name = "Select armor..." }     
             };
            armorList.AddRange(ArmorRepository.allArmor);

            ComboBox_Armor.DataSource = armorList;
            ComboBox_Armor.DisplayMember = "Name";
            ComboBox_Armor.SelectedIndex = 0;

            var weaponList = new List<Weapon>
            {
    new Melee_Weapon { Name = "Select a weapon..." }       
             };
            weaponList.AddRange(WeaponRepository.AllWeapons);


            ComboBox_Weapons.DataSource = weaponList;
            ComboBox_Weapons.DisplayMember = "Name";
            ComboBox_Weapons.SelectedIndex = 0;
            
        }

     


        private void Text_box_name_enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string charName = Text_box_name_enter.Text.Trim();

                if (!string.IsNullOrEmpty(charName) && Text_box_name_enter.Text != "test" && charName.Length < 15)
                {
                 
                    Stats_Name_lbl.Text = charName;
                    user_character.charName = charName;

                }
                
                else if(charName.Length >= 15 )
                {
                    MessageBox.Show("This name is too long.");
                }

                else if (charName == "test")
                {
                    e.SuppressKeyPress = true;
                    MessageBox.Show($"Your strong characteristics are: {Chosen_major_characteristics[0]}, {Chosen_major_characteristics[1]}" +
                        $"\n Medium ones: {Chosen_medium_characteristics[0]}, {Chosen_medium_characteristics[1]}, {Chosen_medium_characteristics[2]}, {Chosen_medium_characteristics[3]}" +
                        $"\n Minor ones: {Chosen_minor_characteristics[0]}, {Chosen_minor_characteristics[1]}");

                    e.SuppressKeyPress = true;
                }


                e.SuppressKeyPress = true;
            }
        }

        private void checkedListBox_Characteristics_Major_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox_Characteristics_Major.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (Chosen_medium_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Medium characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }
                else if (Chosen_minor_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Minor characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                else if (Chosen_major_characteristics.Count >= 2)
                {
                    MessageBox.Show("You can only choose 2 major characteristics!");

                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                if (!Chosen_major_characteristics.Contains(item))
                    Chosen_major_characteristics.Add(item);
            }


            else if (e.NewValue == CheckState.Unchecked)
            {
                Chosen_major_characteristics.Remove(item);
                
            }
            user_character.MajorCharacteristics = Chosen_major_characteristics;

            RefreshStatsBox();
        }


        private void checkedListBox_Characteristics_Medium_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox_Characteristics_Medium.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (Chosen_major_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Major characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }
                else if (Chosen_minor_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Minor characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                else if (Chosen_medium_characteristics.Count >= 4)
                {
                    MessageBox.Show("You can only choose 4 medium characteristics!");

                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                if (!Chosen_medium_characteristics.Contains(item))
                    Chosen_medium_characteristics.Add(item);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                Chosen_medium_characteristics.Remove(item);
            }
            user_character.MediumCharacteristics = Chosen_medium_characteristics;

            RefreshStatsBox();
        }


        private void checkedListBox_Characteristics_Minor_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox_Characteristics_Minor.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (Chosen_medium_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Medium characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                else if (Chosen_major_characteristics.Contains(item))
                {
                    MessageBox.Show($"{item} is already chosen as a Major characteristic. Pick something else.");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                else if (Chosen_minor_characteristics.Count >= 2)
                {
                    MessageBox.Show("You can only choose 2 minor characteristics!");

                    e.NewValue = CheckState.Unchecked;
                    return;
                }

                if (!Chosen_minor_characteristics.Contains(item))
                    Chosen_minor_characteristics.Add(item);
            }


            else if (e.NewValue == CheckState.Unchecked)
            {
                Chosen_minor_characteristics.Remove(item);
            }
            user_character.MinorCharacteristics = Chosen_minor_characteristics;

            RefreshStatsBox();
        }

        private void checkedListBox_Abilities_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            string selectedAbility = checkedListBox_Abilities.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (user_character.StrongAbilities.Count >= 6)
                {
                    MessageBox.Show("You can only select 6 strong abilities!");
                    e.NewValue = CheckState.Unchecked;
                    return;
                }
                user_character.StrongAbilities.Add(selectedAbility);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                user_character.StrongAbilities.Remove(selectedAbility);
            }

            user_character.WeakAbilities = checkedListBox_Abilities.Items
                .Cast<string>()
                .Where(a => !user_character.StrongAbilities.Contains(a))
                .ToList();

           RefreshStatsBox();
        }

        private void ComboBox_Weapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapon SelectedWeapon = ComboBox_Weapons.SelectedItem as Weapon;
            if (SelectedWeapon != null && SelectedWeapon.Name != "Select a weapon...")
            {
                user_character.EquippedWeapon = SelectedWeapon;
                
            }
            RefreshStatsBox();

        }
        private void ComboBox_Weapons_MouseHover(object sender, EventArgs e)
        { 
            if(ComboBox_Weapons.SelectedItem is Weapon w && w.Name != "Select a weapon...")
            {
                generalTip.SetToolTip(ComboBox_Weapons, $"Damage: {w.Damage} \nEffect: {w.SpecialEffect}");
            }    
            else if(ComboBox_Weapons.SelectedItem is Weapon w2 &&  w2.Name == "Select a weapon...")
            {
                generalTip.SetToolTip(ComboBox_Weapons, "Select a weapon from the list below.");
            }

        }

        private void ComboBox_Armor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Armor SelectedArmor = ComboBox_Armor.SelectedItem as Armor;
            if (SelectedArmor != null && SelectedArmor.Name != "Select armor...")
            {
                user_character.EquippedArmor = SelectedArmor;
            }
            RefreshStatsBox();
        }

        private void ComboBox_Armor_MouseHover(object sender, EventArgs e)
        {
            if (ComboBox_Armor.SelectedItem is Armor a && a.Name != "Select armor...")
            {
                generalTip.SetToolTip(ComboBox_Armor, $"Type: {a.Type} \nEffect: {a.SpecialEffect}");

            }
            else if (ComboBox_Armor.SelectedItem is Armor b && b.Name == "Select armor...")
            {
                generalTip.SetToolTip(ComboBox_Armor, "Select armor from the list below.");

            }
        }

        private void Create_Character_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to create this character?",
        "Confirm Character Creation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                // Proceed to next form                                                //Add the main menu form here
                /* NextForm nextForm = new NextForm(user_character);
                 nextForm.Show();

                 // Optionally hide the current one
                 this.Hide();*/
                MessageBox.Show("Yay!", "Success");

                string jsonCharacter = JsonSerializer.Serialize<Character>(user_character);
                File.WriteAllText("character.json", jsonCharacter);


            }
            else
            {
                MessageBox.Show("Character creation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
    


