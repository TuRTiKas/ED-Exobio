using System.Text.RegularExpressions;

namespace ED_Exobio
{
    public partial class Form1 : Form
    {
        private bool[] correct = new bool[5];
        private bool[] filter_IsOn = new bool[4];
        private bool[] filter_IsMatched = new bool[125];
        private bool checkbox_low_info = false;
        private bool checkbox_cost_IsActive = false;
        private bool checkbox_filtres = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filter_IsOn[0] = false;
            filter_IsOn[1] = false;
            filter_IsOn[2] = false;
            filter_IsOn[3] = false;
            correct[0] = false;
            correct[1] = false;
            correct[2] = false;
            correct[3] = false;
            correct[4] = false;
            down_of_cost.Visible = false;
            down_of_cost_text.Visible = false;
            down_of_cost_text2.Visible = false;
            down_of_cost.BackColor = Color.Red;
            filter_type_of_planet.Visible = false;
            filter_type_of_atmosphere.Visible = false;
            filter_temperature.Visible = false;
            filter_gravity.Visible = false;
            Program.Init();
            listBox1.Items.Add("Инициализация прошла успешно");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkbox_filtres == false)
            {
                if (correct[0] == true && correct[1] == true && correct[2] == true && correct[3] == true)
                {
                    int founded_output = 0;
                    int founded_output_unfiltred = 0;
                    listBox1.Items.Clear();
                    Program.get_values(type_of_planet.Text, atmosphere.Text, Convert.ToDouble(temperature.Text), Convert.ToDouble(gravity.Text));
                    Program.new_search();
                    for (int i = 0; i < 125; i++)
                    {
                        Program.process(i);
                        if (Program.IsMatched(i) == true)
                        {
                            if (checkbox_cost_IsActive == true && correct[4] == true)
                            {
                                if (Program.IsMatchedOfCost(i, Convert.ToInt32(down_of_cost.Text)) == true)
                                {
                                    if (checkbox_low_info == false)
                                    {
                                        foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                                    }
                                    else
                                    {
                                        foreach (string s in Regex.Split(Program.output_low(i), "\n")) listBox1.Items.Add(s);
                                    }
                                    founded_output++;
                                }
                            }
                            else if (checkbox_cost_IsActive == false)
                            {
                                if (checkbox_low_info == false)
                                {
                                    foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                                }
                                else
                                {
                                    foreach (string s in Regex.Split(Program.output_low(i), "\n")) listBox1.Items.Add(s);
                                }
                                founded_output++;
                                founded_output_unfiltred++;
                            }
                        }
                    }
                    if (founded_output == 0)
                    {
                        listBox1.Items.Clear();
                        foreach (string s in Regex.Split("Образцов органики по вашему запросу: 0\nВозможно, фильтры настроены неправильно или стоимость экземпляров ниже предела.", "\n")) listBox1.Items.Add(s);
                    }
                    else
                    {
                        listBox1.Items.Add("Образцов органики по вашему запросу: " + founded_output);
                        if (founded_output_unfiltred > 0)
                        {
                            listBox1.Items.Add("Образцов органики по вашему запросу без фильтров стоимости: " + founded_output_unfiltred);
                        }
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (string s in Regex.Split("Неправильно введены значения в поля.\nВозможно при указании числового значения была указана \".\" вместо \",\"", "\n")) listBox1.Items.Add(s);
                }
            }
            else
            {
                if (((filter_IsOn[0] == true && correct[0] == true) || filter_IsOn[0] == false) &&
                    ((filter_IsOn[1] == true && correct[1] == true) || filter_IsOn[1] == false) &&
                    ((filter_IsOn[2] == true && correct[2] == true) || filter_IsOn[2] == false) &&
                    ((filter_IsOn[3] == true && correct[3] == true) || filter_IsOn[3] == false))
                {
                    int founded_output = 0;
                    int founded_output_unfiltred = 0;
                    listBox1.Items.Clear();
                    if (filter_IsOn[0] == true)
                    {
                        Program.get_value_type_of_planet(type_of_planet.Text);
                    }
                    if (filter_IsOn[1] == true)
                    {
                        Program.get_value_type_of_atmosphere(atmosphere.Text);
                    }
                    if (filter_IsOn[2] == true)
                    {
                        Program.get_value_temperature(Convert.ToDouble(temperature.Text));
                    }
                    if (filter_IsOn[3] == true)
                    {
                        Program.get_value_gravity(Convert.ToDouble(gravity.Text));
                    }
                    Program.new_search();
                    for (int i = 0; i < 125; i++)
                    {
                        Program.IsMatchedWithFilters(i, filter_IsOn[0], filter_IsOn[1], filter_IsOn[2], filter_IsOn[3]);
                        if (Program.IsMatched(i) == true)
                        {
                            if (checkbox_cost_IsActive == true && correct[4] == true)
                            {
                                if (Program.IsMatchedOfCost(i, Convert.ToInt32(down_of_cost.Text)) == true)
                                {
                                    if (checkbox_low_info == false)
                                    {
                                        foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                                    }
                                    else
                                    {
                                        foreach (string s in Regex.Split(Program.output_low(i), "\n")) listBox1.Items.Add(s);
                                    }
                                    founded_output++;
                                }
                            }
                            else if (checkbox_cost_IsActive == false)
                            {
                                if (checkbox_low_info == false)
                                {
                                    foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                                }
                                else
                                {
                                    foreach (string s in Regex.Split(Program.output_low(i), "\n")) listBox1.Items.Add(s);
                                }
                                founded_output++;
                                founded_output_unfiltred++;
                            }
                        }
                    }
                    if (founded_output == 0)
                    {
                        listBox1.Items.Clear();
                        foreach (string s in Regex.Split("Образцов органики по вашему запросу: 0\nВозможно, фильтры настроены неправильно или стоимость экземпляров ниже предела.", "\n")) listBox1.Items.Add(s);
                    }
                    else
                    {
                        listBox1.Items.Add("Образцов органики по вашему запросу: " + founded_output);
                        if (founded_output_unfiltred > 0)
                        {
                            listBox1.Items.Add("Образцов органики по вашему запросу без фильтров стоимости: " + founded_output_unfiltred);
                        }
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (string s in Regex.Split("Неправильно введены значения в поля.\nВозможно при указании числового значения была указана \".\" вместо \",\"", "\n")) listBox1.Items.Add(s);
                }
            }
        }

        private void temperature_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(temperature.Text);
                temperature.BackColor = Color.White;
                correct[2] = true;
            }
            catch
            {
                temperature.BackColor = Color.Red;
                correct[2] = false;
            }
        }

        private void gravity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(gravity.Text);
                gravity.BackColor = Color.White;
                correct[3] = true;
            }
            catch
            {
                gravity.BackColor = Color.Red;
                correct[3] = false;
            }
        }

        private void type_of_planet_SelectedIndexChanged(object sender, EventArgs e)
        {
            correct[0] = true;
        }

        private void atmosphere_SelectedIndexChanged(object sender, EventArgs e)
        {
            correct[1] = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_cost_IsActive == false)
            {
                down_of_cost.Visible = true;
                down_of_cost_text.Visible = true;
                down_of_cost_text2.Visible = true;
                checkbox_cost_IsActive = true;
            }
            else
            {
                down_of_cost.Visible = false;
                down_of_cost_text.Visible = false;
                down_of_cost_text2.Visible = false;
                checkbox_cost_IsActive = false;
            }
        }

        private void down_of_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(down_of_cost.Text);
                down_of_cost.BackColor = Color.White;
                correct[4] = true;
            }
            catch
            {
                down_of_cost.BackColor = Color.Red;
                correct[4] = false;
            }
        }

        private void checkBox_low_info_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_low_info == false)
            {
                checkbox_low_info = true;
            }
            else
            {
                checkbox_low_info = false;
            }
        }

        private void checkBox_filtres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_filtres == false)
            {
                filter_type_of_planet.Visible = true;
                filter_type_of_atmosphere.Visible = true;
                filter_temperature.Visible = true;
                filter_gravity.Visible = true;
                checkbox_filtres = true;
            }
            else
            {
                filter_type_of_planet.Visible = false;
                filter_type_of_atmosphere.Visible = false;
                filter_temperature.Visible = false;
                filter_gravity.Visible = false;
                checkbox_filtres = false;
            }
        }

        private void filter_type_of_planet_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_IsOn[0] == false)
            {
                filter_IsOn[0] = true;
            }
            else
            {
                filter_IsOn[0] = false;
            }
        }

        private void filter_type_of_atmosphere_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_IsOn[1] == false)
            {
                filter_IsOn[1] = true;
            }
            else
            {
                filter_IsOn[1] = false;
            }
        }

        private void filter_temperature_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_IsOn[2] == false)
            {
                filter_IsOn[2] = true;
            }
            else
            {
                filter_IsOn[2] = false;
            }
        }

        private void filter_gravity_CheckedChanged(object sender, EventArgs e)
        {
            if (filter_IsOn[3] == false)
            {
                filter_IsOn[3] = true;
            }
            else
            {
                filter_IsOn[3] = false;
            }
        }

        private void all_bio_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Количество доступных образцов: " + Program.number_of_biology);
            foreach (string s in Regex.Split("\n", "\n")) listBox1.Items.Add(s);
            for (int i = 0; i < Program.number_of_biology; i++)
            {
                if (checkbox_low_info == false)
                {
                    foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                }
                else
                {
                    foreach (string s in Regex.Split(Program.output_low(i), "\n")) listBox1.Items.Add(s);
                }
            }
        }
    }
}
