namespace ED_Exobio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button = new Button();
            temperature = new RichTextBox();
            label1 = new Label();
            gravity = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            type_of_planet = new ComboBox();
            atmosphere = new ComboBox();
            checkBox_cost = new CheckBox();
            down_of_cost_text = new Label();
            down_of_cost = new RichTextBox();
            down_of_cost_text2 = new Label();
            checkBox_low_info = new CheckBox();
            checkBox_filtres = new CheckBox();
            filter_type_of_planet = new CheckBox();
            filter_type_of_atmosphere = new CheckBox();
            filter_gravity = new CheckBox();
            filter_temperature = new CheckBox();
            all_bio = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(668, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(613, 631);
            listBox1.TabIndex = 0;
            // 
            // button
            // 
            button.BackColor = SystemColors.ButtonFace;
            button.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.ForeColor = Color.Black;
            button.Location = new Point(187, 426);
            button.Name = "button";
            button.Size = new Size(97, 29);
            button.TabIndex = 1;
            button.Text = "Расчёт";
            button.UseVisualStyleBackColor = false;
            button.Click += button1_Click;
            // 
            // temperature
            // 
            temperature.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            temperature.Location = new Point(154, 262);
            temperature.Name = "temperature";
            temperature.Size = new Size(169, 27);
            temperature.TabIndex = 2;
            temperature.Text = "";
            temperature.TextChanged += temperature_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(15, 67);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 4;
            label1.Text = "Тип планеты:";
            // 
            // gravity
            // 
            gravity.Font = new Font("Times New Roman", 12F);
            gravity.Location = new Point(154, 360);
            gravity.Name = "gravity";
            gravity.Size = new Size(169, 27);
            gravity.TabIndex = 6;
            gravity.Text = "";
            gravity.TextChanged += gravity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 162);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 7;
            label2.Text = "Атмосфера:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 262);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 8;
            label3.Text = "Температура:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 360);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 9;
            label4.Text = "Гравитация: ";
            // 
            // type_of_planet
            // 
            type_of_planet.FormattingEnabled = true;
            type_of_planet.Items.AddRange(new object[] { "Ледяной мир", "Каменисто-ледяной мир", "Каменистый мир", "Мир с высоким содержанием металлов" });
            type_of_planet.Location = new Point(154, 67);
            type_of_planet.Name = "type_of_planet";
            type_of_planet.Size = new Size(303, 23);
            type_of_planet.TabIndex = 10;
            type_of_planet.SelectedIndexChanged += type_of_planet_SelectedIndexChanged;
            // 
            // atmosphere
            // 
            atmosphere.FormattingEnabled = true;
            atmosphere.Items.AddRange(new object[] { "Азот", "Аммиак", "Аргон", "Богатая аргоном", "Богатая неоном", "Вода", "Водная атмосфера", "Водород", "Высокое содержание диоксида углерода", "Диоксид серы", "Диоксид углерода", "Кислород", "Метан", "Неон" });
            atmosphere.Location = new Point(154, 163);
            atmosphere.Name = "atmosphere";
            atmosphere.Size = new Size(303, 23);
            atmosphere.TabIndex = 11;
            atmosphere.SelectedIndexChanged += atmosphere_SelectedIndexChanged;
            // 
            // checkBox_cost
            // 
            checkBox_cost.AutoSize = true;
            checkBox_cost.Font = new Font("Times New Roman", 14F);
            checkBox_cost.ForeColor = SystemColors.ActiveCaptionText;
            checkBox_cost.Location = new Point(15, 548);
            checkBox_cost.Name = "checkBox_cost";
            checkBox_cost.Size = new Size(241, 25);
            checkBox_cost.TabIndex = 12;
            checkBox_cost.Text = "Фильтрация по стоимости";
            checkBox_cost.UseVisualStyleBackColor = true;
            checkBox_cost.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // down_of_cost_text
            // 
            down_of_cost_text.AutoSize = true;
            down_of_cost_text.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            down_of_cost_text.ForeColor = SystemColors.ActiveCaptionText;
            down_of_cost_text.Location = new Point(15, 588);
            down_of_cost_text.Name = "down_of_cost_text";
            down_of_cost_text.Size = new Size(286, 21);
            down_of_cost_text.TabIndex = 14;
            down_of_cost_text.Text = "Нижний порог общей стоимости: ";
            // 
            // down_of_cost
            // 
            down_of_cost.Font = new Font("Times New Roman", 12F);
            down_of_cost.Location = new Point(295, 586);
            down_of_cost.Name = "down_of_cost";
            down_of_cost.Size = new Size(256, 27);
            down_of_cost.TabIndex = 15;
            down_of_cost.Text = "";
            down_of_cost.TextChanged += down_of_cost_TextChanged;
            // 
            // down_of_cost_text2
            // 
            down_of_cost_text2.AutoSize = true;
            down_of_cost_text2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            down_of_cost_text2.ForeColor = SystemColors.ActiveCaptionText;
            down_of_cost_text2.Location = new Point(557, 588);
            down_of_cost_text2.Name = "down_of_cost_text2";
            down_of_cost_text2.Size = new Size(56, 21);
            down_of_cost_text2.TabIndex = 16;
            down_of_cost_text2.Text = "Кред.";
            // 
            // checkBox_low_info
            // 
            checkBox_low_info.AutoSize = true;
            checkBox_low_info.Font = new Font("Times New Roman", 14F);
            checkBox_low_info.ForeColor = SystemColors.ActiveCaptionText;
            checkBox_low_info.Location = new Point(15, 517);
            checkBox_low_info.Name = "checkBox_low_info";
            checkBox_low_info.Size = new Size(307, 25);
            checkBox_low_info.TabIndex = 17;
            checkBox_low_info.Text = "Показывать краткую информацию";
            checkBox_low_info.UseVisualStyleBackColor = true;
            checkBox_low_info.CheckedChanged += checkBox_low_info_CheckedChanged;
            // 
            // checkBox_filtres
            // 
            checkBox_filtres.AutoSize = true;
            checkBox_filtres.Font = new Font("Times New Roman", 14F);
            checkBox_filtres.ForeColor = SystemColors.ActiveCaptionText;
            checkBox_filtres.Location = new Point(15, 486);
            checkBox_filtres.Name = "checkBox_filtres";
            checkBox_filtres.Size = new Size(274, 25);
            checkBox_filtres.TabIndex = 18;
            checkBox_filtres.Text = "Включить отдельные фильтры";
            checkBox_filtres.UseVisualStyleBackColor = true;
            checkBox_filtres.CheckedChanged += checkBox_filtres_CheckedChanged;
            // 
            // filter_type_of_planet
            // 
            filter_type_of_planet.AutoSize = true;
            filter_type_of_planet.Font = new Font("Times New Roman", 14F);
            filter_type_of_planet.ForeColor = SystemColors.ActiveCaptionText;
            filter_type_of_planet.Location = new Point(473, 67);
            filter_type_of_planet.Name = "filter_type_of_planet";
            filter_type_of_planet.Size = new Size(88, 25);
            filter_type_of_planet.TabIndex = 19;
            filter_type_of_planet.Text = "Фильтр";
            filter_type_of_planet.UseVisualStyleBackColor = true;
            filter_type_of_planet.CheckedChanged += filter_type_of_planet_CheckedChanged;
            // 
            // filter_type_of_atmosphere
            // 
            filter_type_of_atmosphere.AutoSize = true;
            filter_type_of_atmosphere.Font = new Font("Times New Roman", 14F);
            filter_type_of_atmosphere.ForeColor = SystemColors.ActiveCaptionText;
            filter_type_of_atmosphere.Location = new Point(473, 163);
            filter_type_of_atmosphere.Name = "filter_type_of_atmosphere";
            filter_type_of_atmosphere.Size = new Size(88, 25);
            filter_type_of_atmosphere.TabIndex = 20;
            filter_type_of_atmosphere.Text = "Фильтр";
            filter_type_of_atmosphere.UseVisualStyleBackColor = true;
            filter_type_of_atmosphere.CheckedChanged += filter_type_of_atmosphere_CheckedChanged;
            // 
            // filter_gravity
            // 
            filter_gravity.AutoSize = true;
            filter_gravity.Font = new Font("Times New Roman", 14F);
            filter_gravity.ForeColor = SystemColors.ActiveCaptionText;
            filter_gravity.Location = new Point(339, 362);
            filter_gravity.Name = "filter_gravity";
            filter_gravity.Size = new Size(88, 25);
            filter_gravity.TabIndex = 21;
            filter_gravity.Text = "Фильтр";
            filter_gravity.UseVisualStyleBackColor = true;
            filter_gravity.CheckedChanged += filter_gravity_CheckedChanged;
            // 
            // filter_temperature
            // 
            filter_temperature.AutoSize = true;
            filter_temperature.Font = new Font("Times New Roman", 14F);
            filter_temperature.ForeColor = SystemColors.ActiveCaptionText;
            filter_temperature.Location = new Point(339, 264);
            filter_temperature.Name = "filter_temperature";
            filter_temperature.Size = new Size(88, 25);
            filter_temperature.TabIndex = 22;
            filter_temperature.Text = "Фильтр";
            filter_temperature.UseVisualStyleBackColor = true;
            filter_temperature.CheckedChanged += filter_temperature_CheckedChanged;
            // 
            // all_bio
            // 
            all_bio.BackColor = SystemColors.ButtonFace;
            all_bio.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            all_bio.ForeColor = Color.Black;
            all_bio.Location = new Point(901, 688);
            all_bio.Name = "all_bio";
            all_bio.Size = new Size(168, 29);
            all_bio.TabIndex = 23;
            all_bio.Text = "Все образцы";
            all_bio.UseVisualStyleBackColor = false;
            all_bio.Click += all_bio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 8F);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(12, 696);
            label5.Name = "label5";
            label5.Size = new Size(191, 14);
            label5.TabIndex = 24;
            label5.Text = "Создатель программы: CMDR TuRTiK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 8F);
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(1248, 697);
            label6.Name = "label6";
            label6.Size = new Size(33, 14);
            label6.TabIndex = 25;
            label6.Text = "v. 1.1";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1308, 729);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(all_bio);
            Controls.Add(filter_temperature);
            Controls.Add(filter_gravity);
            Controls.Add(filter_type_of_atmosphere);
            Controls.Add(filter_type_of_planet);
            Controls.Add(checkBox_filtres);
            Controls.Add(checkBox_low_info);
            Controls.Add(down_of_cost_text2);
            Controls.Add(down_of_cost);
            Controls.Add(down_of_cost_text);
            Controls.Add(checkBox_cost);
            Controls.Add(atmosphere);
            Controls.Add(type_of_planet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gravity);
            Controls.Add(label1);
            Controls.Add(temperature);
            Controls.Add(button);
            Controls.Add(listBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "ED Exobio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button;
        private RichTextBox temperature;
        private Label label1;
        private RichTextBox gravity;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox type_of_planet;
        private ComboBox atmosphere;
        private CheckBox checkBox_cost;
        private ComboBox comboBox1;
        private Label down_of_cost_text;
        private RichTextBox down_of_cost;
        private Label down_of_cost_text2;
        private CheckBox checkBox_low_info;
        private CheckBox checkBox_filtres;
        private CheckBox filter_type_of_planet;
        private CheckBox filter_type_of_atmosphere;
        private CheckBox filter_gravity;
        private CheckBox filter_temperature;
        private Button all_bio;
        private Label label5;
        private Label label6;
    }
}
