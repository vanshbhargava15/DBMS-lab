using static System.Runtime.InteropServices.JavaScript.JSType;

namespace studentinfo
{
    public partial class Form1 : Form
    {
        private String date;
        private String gender;
        private String sub;
        private String stream;
        private String name;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "Female";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.stream = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.date = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "Male";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.sub += "Maths";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = name + "\n" + date + "\n" + gender + "\n" + stream + "Selected Subjects" + sub + "Science";
            MessageBox.Show(str);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.sub += "Physics";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.sub += "chemistry";
            }
        }
    }
}
