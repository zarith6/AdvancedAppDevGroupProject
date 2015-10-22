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
    

    public partial class Form1 : Form
    {
        Part motorOil;
        Part brakePads;
        Part transmissionFluid;
        bool newUser;
        OrderType typeOfOrder;
        User SubmitUser;

        public Form1(bool isNewUser, User userInfo)
        {
            InitializeComponent();
     /*       motorOil = new Part("Motor Oil", "Oil for your engine", 20.00m);
            brakePads = new Part("Brake Pads", "Replacement pads for your brakes", 15.00m);
            transmissionFluid = new Part("Transmission Fluid", "Fluid for your automatic transmission", 20.00m);
            
*/
            emailOrderRadioButton.Checked = true;
            

            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                var query = from parts in db.Parts
                            select parts;

                foreach (var item in query)
                {
                    partDropDownBox.Items.Add(item.Name);
                    partDropDownBox2.Items.Add(item.Name);
                    partDropDownBox3.Items.Add(item.Name);
                    partDropDownBox4.Items.Add(item.Name);
                }
            }


            if (isNewUser)
            {
                emailTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                phoneNumberTextBox.ReadOnly = false;
                newUser = true;
                
            }
            else
            {
                emailTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                phoneNumberTextBox.ReadOnly = true;
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                phoneNumberTextBox.Text = userInfo.PhoneNumber;
                emailTextBox.Text = userInfo.Email;
                addressTextBox.Text = userInfo.Address;
                firstNameTextBox.Text = userInfo.FirstName;
                lastNameTextBox.Text = userInfo.LastName;
                partDropDownBox.Focus();
                newUser = false;
                SubmitUser = userInfo;

            }
        }

        

  /*      

   ** Radio buttons removed, these event handlers are redundant. **
   
        private void newUserRadio_CheckedChanged(object sender, EventArgs e)
        {
            emailTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            phoneNumberTextBox.ReadOnly = false;
        }

        private void existingUserRadio_CheckedChanged(object sender, EventArgs e)
        {
            emailTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            phoneNumberTextBox.ReadOnly = true;
        }

   * */
       

        private void populateDropDownBox()
        {
            partDropDownBox.Items.Add(motorOil.Name);
            partDropDownBox.Items.Add(transmissionFluid.Name);
            partDropDownBox.Items.Add(brakePads.Name);
            partDropDownBox2.Items.Add(motorOil.Name);
            partDropDownBox2.Items.Add(transmissionFluid.Name);
            partDropDownBox2.Items.Add(brakePads.Name);
            partDropDownBox3.Items.Add(motorOil.Name);
            partDropDownBox3.Items.Add(transmissionFluid.Name);
            partDropDownBox3.Items.Add(brakePads.Name);
            partDropDownBox4.Items.Add(motorOil.Name);
            partDropDownBox4.Items.Add(transmissionFluid.Name);
            partDropDownBox4.Items.Add(brakePads.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  populateDropDownBox();
        }

        private void partDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                if (partDropDownBox.SelectedItem.ToString() == "Motor Oil")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "Motor Oil"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        productPriceLabel.Text = "$" + item.Price.ToString();
                    }
                }
                else if (partDropDownBox.SelectedItem.ToString() == "Coolant")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "Coolant"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        productPriceLabel.Text = "$" + item.Price.ToString();
                    }
                }
                else if (partDropDownBox.SelectedItem.ToString() == "Brake Pads")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "Brake Pads"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        productPriceLabel.Text = "$" + item.Price.ToString();
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (newUser)
            {
                using (AutoPartsDbContext db = new AutoPartsDbContext())
                {

                        SubmitUser = new User();
                        SubmitUser.Address = addressTextBox.Text;
                        SubmitUser.FirstName = firstNameTextBox.Text;
                        SubmitUser.LastName = lastNameTextBox.Text;
                        SubmitUser.PhoneNumber = phoneNumberTextBox.Text;
                        SubmitUser.Email = emailTextBox.Text;

                        db.Users.Add(SubmitUser);
                    //TODO Fix this. It's broken
                    db.Orders.Add(new Order
                    {
                        OrderContents = partDropDownBox.SelectedItem.ToString() + "," +
                                        partDropDownBox2.SelectedItem.ToString() + "," +
                                        partDropDownBox3.SelectedItem.ToString() + "," +
                                        partDropDownBox4.SelectedItem.ToString(),
                        OrderQuantities = (int)partQuantityNumBox.Value,
                        OrderType = typeOfOrder,
                        User = SubmitUser,
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("User created and order submitted!");
            }
            else
            {
                using (AutoPartsDbContext db = new AutoPartsDbContext())
                {
                    db.Orders.Add(new Order
                    {
                        OrderContents = partDropDownBox.SelectedItem + "," +
                                        partDropDownBox2.SelectedItem + "," +
                                        partDropDownBox3.SelectedItem + "," +
                                        partDropDownBox4.SelectedItem,
                        OrderQuantities = (int)partQuantityNumBox.Value,
                        OrderType = typeOfOrder,
                        User = SubmitUser,
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Order submitted!");
            }
        }

        private void emailOrderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfOrder = OrderType.EMAIL;
        }

        private void phoneOrderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfOrder = OrderType.PHONE;
        }

        private void walkinOrderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfOrder = OrderType.WALKIN;
        }


    }
}
