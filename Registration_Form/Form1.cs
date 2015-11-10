using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationLibrary;

namespace Registration_Form
{
    public partial class Registration : Form
    {
        RegistrationForm adminRegistrationInfo = new RegistrationForm("admin", "Qwerty1234");
        RegistrationForm userRegistrationInfo = new RegistrationForm();
        public Registration()
        {
            InitializeComponent();
            Capcha.Text = userRegistrationInfo.Capcha;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                userRegistrationInfo.Login = Login_textBox.Text;
                userRegistrationInfo.Password = Password_textBox.Text;
                if (Capcha_textBox.Text != Capcha.Text)
                {
                    throw new Exception("Wrong capcha input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Capcha.Text = userRegistrationInfo.Capcha;
                return;
            }

            if (userRegistrationInfo.Equals(adminRegistrationInfo))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Declined!");
            }
            Capcha.Text = userRegistrationInfo.Capcha;

        }

        private void Login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshCapchaButton_Click(object sender, EventArgs e)
        {
            Capcha.Text = userRegistrationInfo.Capcha;
        }
    }
}
