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
            button.Location = new Point(186, 454);
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
            atmosphere.Items.AddRange(new object[] { "Азот", "Аммиак", "Аргон", "Богатая аргоном", "Богатая неоном", "Вода","Водная атмосфера","Водород", "Высокое содержание диоксида углерода","Диоксид серы", "Диоксид углерода", "Кислород", "Метан", "Неон"});
            atmosphere.Location = new Point(154, 163);
            atmosphere.Name = "atmosphere";
            atmosphere.Size = new Size(303, 23);
            atmosphere.TabIndex = 11;
            atmosphere.SelectedIndexChanged += atmosphere_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1308, 729);
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
    }
}
