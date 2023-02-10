namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name;
            this.textBox1.Text=name= textBox1.Text;
            progressBar1.Value = 1;
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name;
            this.textBox1.Text = name = textBox1.Text;
            progressBar1.Value = 2;
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name;
            this.textBox1.Text = name = textBox1.Text;
            progressBar1.Value = 3;
            checkBox1.Enabled = true;checkBox2.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string name;
            this.textBox1.Text = name = textBox1.Text;
            progressBar1.Value = 4;
            dateTimePicker1.Enabled= true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            string name;
            this.textBox1.Text = name = textBox1.Text;
            progressBar1.Value = 5;
            textBox6.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string name;
            this.textBox1.Text = name = textBox1.Text;
            progressBar1.Value = 6;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                MessageBox.Show($"Ім'я {textBox1.Text.ToString()}; Прізвище {textBox2.Text.ToString()};" +
                    $"          По батькові {textBox3.Text.ToString()}; Стать {checkBox1.Text};" +
                    $"          Дата народження {dateTimePicker1.Value}; Громадянство {textBox6.Text.ToString()};");

            }
            else {

                MessageBox.Show($"Ім'я {textBox1.Text.ToString()} Прізвище {textBox2.Text.ToString()}" +
                        $"          По батькові {textBox3.Text.ToString()} Стать {checkBox2.Text}" +
                        $"          Дата народження {dateTimePicker1.Value} Громадянство {textBox6.Text.ToString()}");
            }
        }
    }
}