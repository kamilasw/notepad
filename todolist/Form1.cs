
using System.Numerics;


namespace todolist
{
    public partial class Form1 : Form
    {

        int count = 0;
        string textinstring = "";
        string filestring = "";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("input cannot be empty");
                return;
            }
            if(userInput.Length >= 39)
            {
                MessageBox.Show("max input length is 38 characters");
                return;
            }
            else { textBox1.Clear(); }
            
            if (count < 17)
            {

                textinstring += userInput + System.Environment.NewLine;
                count++;
                textBox2.Text = textinstring;

            }
            else
            {
                button2_Click(sender, e);
                textinstring = userInput + System.Environment.NewLine;
                count = 1;
                textBox2.Text = textinstring;
            }
            
            textBox1.Select();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filestring += textinstring;
            File.WriteAllText("noted.txt", filestring);
            

            textinstring = "";
            count = 0;
            textBox2.Clear();
            textBox1.Select();
        }
    }
}
