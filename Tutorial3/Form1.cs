using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tutorial3
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "^[a-zA-Z0-9][a-zA-Z0-9_\\-]{0,4}[a-zA-Z0-9]$";
            string pass = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

            
            Regex re = new Regex(user);
            Regex re1 = new Regex(pass);

            if(!re.IsMatch(textBox1.Text) || !re1.IsMatch(textBox2.Text))
            {
                if (!re.IsMatch(textBox1.Text))
                {
                    
                    MessageBox.Show("Fill Valid User ID");
                }

                if (!re1.IsMatch(textBox2.Text))
                {
                    
                    MessageBox.Show("Password with \nAt least one lower case letter,\nAt least one upper case letter,\nAt least special character,\nAt least one number\nAt least 8 characters length");
                }
            }
            else
            {
                SetValueForText1 = textBox1.Text;
                SetValueForText2 = textBox2.Text;

                Form2 frm2 = new Form2();
                frm2.Show();
            }

            
        }
    }
     
}
