using System.Text.RegularExpressions;

namespace ED_Exobio
{
    public partial class Form1 : Form
    {
        private bool[] correct = new bool[4];
        private int founded_output;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            correct[0] = false;
            correct[1] = false;
            correct[2] = false;
            correct[3] = false;
            Program.Init();
            listBox1.Items.Add("Инициализация прошла успешно");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correct[0] == true && correct[1] == true && correct[2] == true && correct[3] == true)
            {
                founded_output = 0;
                listBox1.Items.Clear();
                Program.get_values(type_of_planet.Text, atmosphere.Text, Convert.ToDouble(temperature.Text), Convert.ToDouble(gravity.Text));
                Program.new_search();
                for (int i=0;i<125;i++)
                {
                    Program.process(i);
                    if (Program.IsMatched(i)==true)
                    {
                        foreach (string s in Regex.Split(Program.output(i), "\n")) listBox1.Items.Add(s);
                        founded_output++;
                    }
                }
                if (founded_output == 0)
                {
                    listBox1.Items.Clear();
                    foreach (string s in Regex.Split("Образцов органики по вашему запросу: 0\nВозможно, фильтры настроены неправильно или стоимость экземпляров ниже предела.", "\n")) listBox1.Items.Add(s);
                }
                else founded_output = 0;
            }
            else 
            {
                listBox1.Items.Clear();
                foreach (string s in Regex.Split("Неправильно введены значения в поля.\nВозможно при указании числового значения была указана \".\" вместо \",\"", "\n")) listBox1.Items.Add(s);
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
    }
}
