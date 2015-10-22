using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectUIMockUp
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }
        //use existing account
        private void button2_Click(object sender, EventArgs e)
        {
            var phoneNumber = new PhoneNumber();
            this.Hide();
            phoneNumber.Show();
        }

        //Create new account
        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1(true, new User());
            this.Hide();
            mainForm.Show();
            
        }
    }
}
