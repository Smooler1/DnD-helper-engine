namespace DnD_Helper_Engine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CharacterCreatorNameLbl = new Label();
            Text_box_name_enter = new TextBox();
            checkedListBox_Characteristics_Major = new CheckedListBox();
            checkedListBox_Characteristics_Medium = new CheckedListBox();
            checkedListBox_Characteristics_Minor = new CheckedListBox();
            label_characteristic_scale = new Label();
            checkedListBox_Abilities = new CheckedListBox();
            characteristics_announce_label = new Label();
            abilities_label = new Label();
            ComboBox_Weapons = new ComboBox();
            equipment_label = new Label();
            ability_category_label = new Label();
            ability_category_label2 = new Label();
            ability_category_label3 = new Label();
            ability_category_label4 = new Label();
            ability_category_label5 = new Label();
            ability_category_label6 = new Label();
            ComboBox_Armor = new ComboBox();
            generalTip = new ToolTip(components);
            Create_Character_btn = new Button();
            All_Stats_lbl = new Label();
            Stats_Name_lbl = new Label();
            Stats_Characteristics_and_stuff_lbl = new Label();
            SuspendLayout();
            // 
            // CharacterCreatorNameLbl
            // 
            CharacterCreatorNameLbl.AutoSize = true;
            CharacterCreatorNameLbl.Font = new Font("Microsoft Sans Serif", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CharacterCreatorNameLbl.Location = new Point(692, 9);
            CharacterCreatorNameLbl.MaximumSize = new Size(1333, 1462);
            CharacterCreatorNameLbl.MinimumSize = new Size(13, 15);
            CharacterCreatorNameLbl.Name = "CharacterCreatorNameLbl";
            CharacterCreatorNameLbl.Size = new Size(274, 35);
            CharacterCreatorNameLbl.TabIndex = 0;
            CharacterCreatorNameLbl.Text = "Character Creation\r\n";
            // 
            // Text_box_name_enter
            // 
            Text_box_name_enter.Font = new Font("Microsoft Sans Serif", 12.4F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Text_box_name_enter.Location = new Point(101, 82);
            Text_box_name_enter.Margin = new Padding(3, 4, 3, 4);
            Text_box_name_enter.Name = "Text_box_name_enter";
            Text_box_name_enter.Size = new Size(325, 29);
            Text_box_name_enter.TabIndex = 1;
            Text_box_name_enter.KeyDown += Text_box_name_enter_KeyDown;
            // 
            // checkedListBox_Characteristics_Major
            // 
            checkedListBox_Characteristics_Major.CheckOnClick = true;
            checkedListBox_Characteristics_Major.FormattingEnabled = true;
            checkedListBox_Characteristics_Major.Items.AddRange(new object[] { "Strength", "Dexterity", "Constitution", "Perception", "Knowledge", "Sanity", "Persuasion", "Stubbornness" });
            checkedListBox_Characteristics_Major.Location = new Point(64, 365);
            checkedListBox_Characteristics_Major.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_Characteristics_Major.Name = "checkedListBox_Characteristics_Major";
            checkedListBox_Characteristics_Major.Size = new Size(143, 172);
            checkedListBox_Characteristics_Major.TabIndex = 3;
            checkedListBox_Characteristics_Major.ItemCheck += checkedListBox_Characteristics_Major_ItemCheck;
            // 
            // checkedListBox_Characteristics_Medium
            // 
            checkedListBox_Characteristics_Medium.CheckOnClick = true;
            checkedListBox_Characteristics_Medium.FormattingEnabled = true;
            checkedListBox_Characteristics_Medium.Items.AddRange(new object[] { "Strength", "Dexterity", "Constitution", "Perception", "Knowledge", "Sanity", "Persuasion", "Stubbornness" });
            checkedListBox_Characteristics_Medium.Location = new Point(245, 365);
            checkedListBox_Characteristics_Medium.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_Characteristics_Medium.Name = "checkedListBox_Characteristics_Medium";
            checkedListBox_Characteristics_Medium.Size = new Size(141, 172);
            checkedListBox_Characteristics_Medium.TabIndex = 4;
            checkedListBox_Characteristics_Medium.ItemCheck += checkedListBox_Characteristics_Medium_ItemCheck;
            // 
            // checkedListBox_Characteristics_Minor
            // 
            checkedListBox_Characteristics_Minor.CheckOnClick = true;
            checkedListBox_Characteristics_Minor.FormattingEnabled = true;
            checkedListBox_Characteristics_Minor.Items.AddRange(new object[] { "Strength", "Dexterity", "Constitution", "Perception", "Knowledge", "Sanity", "Persuasion", "Stubbornness" });
            checkedListBox_Characteristics_Minor.Location = new Point(432, 365);
            checkedListBox_Characteristics_Minor.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_Characteristics_Minor.Name = "checkedListBox_Characteristics_Minor";
            checkedListBox_Characteristics_Minor.Size = new Size(145, 172);
            checkedListBox_Characteristics_Minor.TabIndex = 5;
            checkedListBox_Characteristics_Minor.ItemCheck += checkedListBox_Characteristics_Minor_ItemCheck;
            // 
            // label_characteristic_scale
            // 
            label_characteristic_scale.AutoSize = true;
            label_characteristic_scale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_characteristic_scale.Location = new Point(101, 324);
            label_characteristic_scale.Name = "label_characteristic_scale";
            label_characteristic_scale.Size = new Size(424, 24);
            label_characteristic_scale.TabIndex = 6;
            label_characteristic_scale.Text = "Major                        Medium                          Minor\r\n";
            // 
            // checkedListBox_Abilities
            // 
            checkedListBox_Abilities.BackColor = Color.White;
            checkedListBox_Abilities.CheckOnClick = true;
            checkedListBox_Abilities.FormattingEnabled = true;
            checkedListBox_Abilities.Items.AddRange(new object[] { "Heavy weapons", "Heavy firearms", "Light weapons", "Light firearms", "Armor", "Rallying ", "Environnement", "Human", "Esoteric", "Mechanical ", "Willpower", "Lucidity" });
            checkedListBox_Abilities.Location = new Point(740, 324);
            checkedListBox_Abilities.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_Abilities.Name = "checkedListBox_Abilities";
            checkedListBox_Abilities.RightToLeft = RightToLeft.No;
            checkedListBox_Abilities.Size = new Size(159, 256);
            checkedListBox_Abilities.TabIndex = 8;
            checkedListBox_Abilities.ItemCheck += checkedListBox_Abilities_ItemCheck;
            // 
            // characteristics_announce_label
            // 
            characteristics_announce_label.AutoSize = true;
            characteristics_announce_label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            characteristics_announce_label.Location = new Point(207, 253);
            characteristics_announce_label.Name = "characteristics_announce_label";
            characteristics_announce_label.Size = new Size(171, 29);
            characteristics_announce_label.TabIndex = 9;
            characteristics_announce_label.Text = "Characteristics";
            // 
            // abilities_label
            // 
            abilities_label.AutoSize = true;
            abilities_label.Font = new Font("Microsoft Sans Serif", 15.05455F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abilities_label.Location = new Point(763, 253);
            abilities_label.Name = "abilities_label";
            abilities_label.Size = new Size(98, 29);
            abilities_label.TabIndex = 10;
            abilities_label.Text = "Abilities";
            // 
            // ComboBox_Weapons
            // 
            ComboBox_Weapons.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Weapons.FormattingEnabled = true;
            ComboBox_Weapons.Location = new Point(994, 330);
            ComboBox_Weapons.Margin = new Padding(3, 4, 3, 4);
            ComboBox_Weapons.Name = "ComboBox_Weapons";
            ComboBox_Weapons.Size = new Size(161, 27);
            ComboBox_Weapons.TabIndex = 11;
            ComboBox_Weapons.SelectedIndexChanged += ComboBox_Weapons_SelectedIndexChanged;
            ComboBox_Weapons.MouseHover += ComboBox_Weapons_MouseHover;
            // 
            // equipment_label
            // 
            equipment_label.AutoSize = true;
            equipment_label.Font = new Font("Microsoft Sans Serif", 15.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            equipment_label.Location = new Point(1102, 259);
            equipment_label.Name = "equipment_label";
            equipment_label.Size = new Size(129, 29);
            equipment_label.TabIndex = 12;
            equipment_label.Text = "Equipment";
            // 
            // ability_category_label
            // 
            ability_category_label.AutoSize = true;
            ability_category_label.FlatStyle = FlatStyle.System;
            ability_category_label.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label.Location = new Point(711, 335);
            ability_category_label.Name = "ability_category_label";
            ability_category_label.Size = new Size(23, 16);
            ability_category_label.TabIndex = 13;
            ability_category_label.Text = "Str";
            // 
            // ability_category_label2
            // 
            ability_category_label2.AutoSize = true;
            ability_category_label2.FlatStyle = FlatStyle.System;
            ability_category_label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label2.Location = new Point(703, 380);
            ability_category_label2.Name = "ability_category_label2";
            ability_category_label2.Size = new Size(31, 16);
            ability_category_label2.TabIndex = 14;
            ability_category_label2.Text = "Dex";
            // 
            // ability_category_label3
            // 
            ability_category_label3.AutoSize = true;
            ability_category_label3.FlatStyle = FlatStyle.System;
            ability_category_label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label3.Location = new Point(693, 421);
            ability_category_label3.Name = "ability_category_label3";
            ability_category_label3.Size = new Size(41, 16);
            ability_category_label3.TabIndex = 15;
            ability_category_label3.Text = "Const";
            // 
            // ability_category_label4
            // 
            ability_category_label4.AutoSize = true;
            ability_category_label4.FlatStyle = FlatStyle.System;
            ability_category_label4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label4.Location = new Point(699, 461);
            ability_category_label4.Name = "ability_category_label4";
            ability_category_label4.Size = new Size(35, 16);
            ability_category_label4.TabIndex = 16;
            ability_category_label4.Text = "Perc";
            // 
            // ability_category_label5
            // 
            ability_category_label5.AutoSize = true;
            ability_category_label5.FlatStyle = FlatStyle.System;
            ability_category_label5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label5.Location = new Point(692, 505);
            ability_category_label5.Name = "ability_category_label5";
            ability_category_label5.Size = new Size(42, 16);
            ability_category_label5.TabIndex = 17;
            ability_category_label5.Text = "Knowl";
            // 
            // ability_category_label6
            // 
            ability_category_label6.AutoSize = true;
            ability_category_label6.FlatStyle = FlatStyle.System;
            ability_category_label6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ability_category_label6.Location = new Point(703, 546);
            ability_category_label6.Name = "ability_category_label6";
            ability_category_label6.Size = new Size(31, 16);
            ability_category_label6.TabIndex = 18;
            ability_category_label6.Text = "San";
            // 
            // ComboBox_Armor
            // 
            ComboBox_Armor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Armor.FormattingEnabled = true;
            ComboBox_Armor.Location = new Point(1174, 330);
            ComboBox_Armor.Margin = new Padding(3, 4, 3, 4);
            ComboBox_Armor.Name = "ComboBox_Armor";
            ComboBox_Armor.Size = new Size(161, 27);
            ComboBox_Armor.TabIndex = 19;
            ComboBox_Armor.SelectedIndexChanged += ComboBox_Armor_SelectedIndexChanged;
            ComboBox_Armor.MouseHover += ComboBox_Armor_MouseHover;
            // 
            // Create_Character_btn
            // 
            Create_Character_btn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Create_Character_btn.Location = new Point(1460, 711);
            Create_Character_btn.Margin = new Padding(4);
            Create_Character_btn.MaximumSize = new Size(1333, 1462);
            Create_Character_btn.MinimumSize = new Size(67, 73);
            Create_Character_btn.Name = "Create_Character_btn";
            Create_Character_btn.Size = new Size(197, 73);
            Create_Character_btn.TabIndex = 20;
            Create_Character_btn.Text = "Create character";
            Create_Character_btn.UseVisualStyleBackColor = true;
            Create_Character_btn.Click += Create_Character_btn_Click;
            // 
            // All_Stats_lbl
            // 
            All_Stats_lbl.AutoSize = true;
            All_Stats_lbl.BackColor = Color.LightGray;
            All_Stats_lbl.Font = new Font("Microsoft Sans Serif", 13.74545F, FontStyle.Regular, GraphicsUnit.Point, 204);
            All_Stats_lbl.Location = new Point(1405, 107);
            All_Stats_lbl.Margin = new Padding(4, 0, 4, 0);
            All_Stats_lbl.MaximumSize = new Size(1332, 1460);
            All_Stats_lbl.MinimumSize = new Size(300, 600);
            All_Stats_lbl.Name = "All_Stats_lbl";
            All_Stats_lbl.Size = new Size(300, 600);
            All_Stats_lbl.TabIndex = 21;
            All_Stats_lbl.Text = "                Your stats";
            // 
            // Stats_Name_lbl
            // 
            Stats_Name_lbl.AutoSize = true;
            Stats_Name_lbl.BackColor = Color.WhiteSmoke;
            Stats_Name_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Stats_Name_lbl.Location = new Point(1460, 160);
            Stats_Name_lbl.Margin = new Padding(4, 0, 4, 0);
            Stats_Name_lbl.Name = "Stats_Name_lbl";
            Stats_Name_lbl.Size = new Size(51, 20);
            Stats_Name_lbl.TabIndex = 22;
            Stats_Name_lbl.Text = "Name";
            // 
            // Stats_Characteristics_and_stuff_lbl
            // 
            Stats_Characteristics_and_stuff_lbl.AutoSize = true;
            Stats_Characteristics_and_stuff_lbl.BackColor = Color.WhiteSmoke;
            Stats_Characteristics_and_stuff_lbl.Font = new Font("Microsoft Sans Serif", 8.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Stats_Characteristics_and_stuff_lbl.Location = new Point(1424, 214);
            Stats_Characteristics_and_stuff_lbl.Margin = new Padding(4, 0, 4, 0);
            Stats_Characteristics_and_stuff_lbl.Name = "Stats_Characteristics_and_stuff_lbl";
            Stats_Characteristics_and_stuff_lbl.Size = new Size(95, 112);
            Stats_Characteristics_and_stuff_lbl.TabIndex = 23;
            Stats_Characteristics_and_stuff_lbl.Text = "Characteristics\r\n\r\nMajor:\r\n\r\nMedium:\r\n\r\nMinor:";
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1748, 821);
            Controls.Add(Stats_Characteristics_and_stuff_lbl);
            Controls.Add(Stats_Name_lbl);
            Controls.Add(All_Stats_lbl);
            Controls.Add(Create_Character_btn);
            Controls.Add(ComboBox_Armor);
            Controls.Add(ability_category_label6);
            Controls.Add(ability_category_label5);
            Controls.Add(ability_category_label4);
            Controls.Add(ability_category_label3);
            Controls.Add(ability_category_label2);
            Controls.Add(ability_category_label);
            Controls.Add(equipment_label);
            Controls.Add(ComboBox_Weapons);
            Controls.Add(abilities_label);
            Controls.Add(characteristics_announce_label);
            Controls.Add(checkedListBox_Abilities);
            Controls.Add(label_characteristic_scale);
            Controls.Add(checkedListBox_Characteristics_Minor);
            Controls.Add(checkedListBox_Characteristics_Medium);
            Controls.Add(checkedListBox_Characteristics_Major);
            Controls.Add(Text_box_name_enter);
            Controls.Add(CharacterCreatorNameLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Character Creator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharacterCreatorNameLbl;
        private System.Windows.Forms.TextBox Text_box_name_enter;
        private System.Windows.Forms.CheckedListBox checkedListBox_Characteristics_Major;
        private System.Windows.Forms.CheckedListBox checkedListBox_Characteristics_Medium;
        private System.Windows.Forms.CheckedListBox checkedListBox_Characteristics_Minor;
        private System.Windows.Forms.Label label_characteristic_scale;
        private System.Windows.Forms.CheckedListBox checkedListBox_Abilities;
        private System.Windows.Forms.Label characteristics_announce_label;
        private System.Windows.Forms.Label abilities_label;
        private System.Windows.Forms.ComboBox ComboBox_Weapons;
        private System.Windows.Forms.Label equipment_label;
        private System.Windows.Forms.Label ability_category_label;
        private System.Windows.Forms.Label ability_category_label2;
        private System.Windows.Forms.Label ability_category_label3;
        private System.Windows.Forms.Label ability_category_label4;
        private System.Windows.Forms.Label ability_category_label5;
        private System.Windows.Forms.Label ability_category_label6;
        private System.Windows.Forms.ComboBox ComboBox_Armor;
        private System.Windows.Forms.ToolTip generalTip;
        private System.Windows.Forms.Button Create_Character_btn;
        private System.Windows.Forms.Label All_Stats_lbl;
        private System.Windows.Forms.Label Stats_Name_lbl;
        private System.Windows.Forms.Label Stats_Characteristics_and_stuff_lbl;
    }
}

