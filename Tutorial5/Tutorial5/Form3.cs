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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tutorial5
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_Uid.Text = Login.SetValueForText1;
            txt_pwd.Text = Login.SetValueForText2;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string user = "^[a-zA-Z0-9][a-zA-Z0-9_\\-]{0,4}[a-zA-Z0-9]$";


            Regex re = new Regex(user);

            if (!re.IsMatch(txt_name.Text) || txt_addr.Text == "")
            {
                if (!re.IsMatch(txt_name.Text))
                {
                    MessageBox.Show("Fill Valid User Name");
                }
                if (txt_addr.Text == "")
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
