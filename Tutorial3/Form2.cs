using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            textBox2.Text = Form1.SetValueForText2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "^[a-zA-Z0-9][a-zA-Z0-9_\\-]{0,4}[a-zA-Z0-9]$";
            

            Regex re = new Regex(user);

            if (!re.IsMatch(textBox1.Text) || richTextBox1.Text == "")
            {
                if (!re.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Fill Valid User Name");
                }
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Fill the Address");
                }
            }
            else
            {
                MessageBox.Show("Sumbit Button Clicked");
            }
        }
    }
}
