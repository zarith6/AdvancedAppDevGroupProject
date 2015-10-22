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
    public partial class PhoneNumber : Form
    {
        public PhoneNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1(false, phoneNumberTextBox.Text);
            this.Hide();
            Form1.Show();
        }
    }
}
