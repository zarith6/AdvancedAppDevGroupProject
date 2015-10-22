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
            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                var query = from users in db.Users
                            where users.PhoneNumber == phoneNumberTextBox.Text && users.FirstName == firstNameTextBox.Text
                            select users;

                if (query.Count() != 0)
                {
                    User tempUser = new User();
                    foreach (var item in query)
                    {
                        tempUser.FirstName = item.FirstName;
                        tempUser.LastName = item.LastName;
                        tempUser.Email = item.Email;
                        tempUser.PhoneNumber = item.PhoneNumber;
                        tempUser.Address = item.Address;
                    }
                    var Form1 = new Form1(false, tempUser);
                    this.Hide();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("No record found that matches submitted data.");
                }

            }


            
        }
    }
}
