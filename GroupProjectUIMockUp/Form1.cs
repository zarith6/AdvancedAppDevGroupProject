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

namespace GroupProjectUIMockUp
{
    

    public partial class Form1 : Form
    {
   //   Part motorOil;
   //   Part brakePads;
   //   Part transmissionFluid;
        bool newUser;
        OrderType typeOfOrder;
        User SubmitUser;
        decimal orderTotal = 0;
        int labelToShow = 0;
        const int MAX_INDEX_OF_LABELS = 4;

        public Form1(bool isNewUser, User userInfo)
        {
            InitializeComponent();
     /*       motorOil = new Part("Motor Oil", "Oil for your engine", 20.00m);
            brakePads = new Part("Brake Pads", "Replacement pads for your brakes", 15.00m);
            transmissionFluid = new Part("Transmission Fluid", "Fluid for your automatic transmission", 20.00m);
            
*/
            emailOrderRadioButton.Checked = true;
            

           


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

   * Used for testing before DB existed
       

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
        */
        private void Form1_Load(object sender, EventArgs e)
        {
          //  populateDropDownBox();
            

            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                var query = from parts in db.Parts
                            select parts;

                foreach (var item in query)
                {
                    partDropDownBox.Items.Add(item.Name);
                }
            }
        }

        private void partDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls["quantLabel" + labelToShow.ToString()].Visible = true;
            labelToShow++;
            

            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                if (partDropDownBox.SelectedItem.ToString() == "MotorOil")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "MotorOil"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        selectedItemsListBox.Items.Add(item.Name + "    $" + item.Price.ToString());
                        orderTotal += item.Price;
                        orderTotalLabel.Text = "$" + orderTotal.ToString();
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
                        selectedItemsListBox.Items.Add(item.Name + "    $" + item.Price.ToString());
                        orderTotal += item.Price;
                        orderTotalLabel.Text = "$" + orderTotal.ToString();
                    }
                }
                else if (partDropDownBox.SelectedItem.ToString() == "BrakePads")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "BrakePads"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        selectedItemsListBox.Items.Add(item.Name + "    $" + item.Price.ToString());
                        orderTotal += item.Price;
                        orderTotalLabel.Text = "$" + orderTotal.ToString();
                    }
                }
                else if (partDropDownBox.SelectedItem.ToString() == "Alternator")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "Alternator"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        selectedItemsListBox.Items.Add(item.Name + "    $" + item.Price.ToString());
                        orderTotal += item.Price;
                        orderTotalLabel.Text = "$" + orderTotal.ToString();
                    }
                }
                else if (partDropDownBox.SelectedItem.ToString() == "SparkPlug")
                {
                    var query = from parts in db.Parts
                                where parts.Name == "SparkPlug"
                                select parts;

                    foreach (var item in query)
                    {
                        productDescriptionLabel.Text = item.Description;
                        selectedItemsListBox.Items.Add(item.Name + "    $" + item.Price.ToString());
                        orderTotal += item.Price;
                        orderTotalLabel.Text = "$" + orderTotal.ToString();
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var r = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != ""
                && phoneNumberTextBox.Text != "" && addressTextBox.Text != "" && r.IsMatch(phoneNumberTextBox.Text))
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
                        
                        string itemsToSubmit = null;
                        
                        for (int i = 0; i < selectedItemsListBox.Items.Count; i++)
                        {
                            itemsToSubmit += selectedItemsListBox.Items[i].ToString() + " ";
                        }

                        int count = 0;
                        string total = null;
                        
                        
                        while (this.Controls["quantLabel" + count] != null)
                        {
                            if (count > MAX_INDEX_OF_LABELS)
                            {
                                break;
                            }
                            else if (this.Controls["quantLabel" + count].Visible == true)
                            {
                                total += this.Controls["quantLabel" + count].Text + " ";
                                count++;
                            }
                        }

                            try
                            {
                                db.Orders.Add(new Order
                                {
                                    OrderContents = itemsToSubmit,
                                    OrderQuantities = total,
                                    OrderType = typeOfOrder,
                                    //User = SubmitUser,
                                });
                            }
                            catch { MessageBox.Show("Please select an item to order"); }
                        db.SaveChanges();
                    }
                    MessageBox.Show("User created and order submitted!");
                }
                else
                {
                    string itemsToSubmit = null;

                    for (int i = 0; i < selectedItemsListBox.Items.Count; i++)
                    {
                        itemsToSubmit += selectedItemsListBox.Items[i].ToString() + " ";
                    }

                    int count = 0;
                    string total = null;




                   
                    while (this.Controls["quantLabel" + count] != null)
                    {
                        if (count > MAX_INDEX_OF_LABELS)
                        {
                            break;
                        }
                        else if (this.Controls["quantLabel" + count].Visible == true)
                        {
                            total += this.Controls["quantLabel" + count].Text + " ";
                            count++;
                        }
                    }
                    

                    using (AutoPartsDbContext db = new AutoPartsDbContext())
                    {
                        db.Orders.Add(new Order
                        {
                            OrderContents = itemsToSubmit,
                            OrderQuantities = total,
                            OrderType = typeOfOrder,
                            //User = SubmitUser,
                        });
                        db.SaveChanges();
                    }
                    MessageBox.Show("Order submitted!");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
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

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (selectedItemsListBox.SelectedItem != null)
            {
                char[] delimiter = {' ','$'};
                string stringToSplit = selectedItemsListBox.SelectedItem.ToString();
                string[] splitUpString = stringToSplit.Split(delimiter);
                decimal amountToRemove = Convert.ToDecimal(splitUpString[5]);
                orderTotal -= amountToRemove;
                orderTotalLabel.Text = "$" + orderTotal.ToString();
                selectedItemsListBox.Items.RemoveAt(selectedItemsListBox.SelectedIndex);
                labelToShow--;
                this.Controls["quantLabel" + labelToShow.ToString()].Visible = false;
                this.Controls["quantLabel" + labelToShow.ToString()].Text = "1";
                
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            if (selectedItemsListBox.SelectedItem != null)
            {
               int getQuantity = Convert.ToInt32(this.Controls["quantLabel" + selectedItemsListBox.SelectedIndex.ToString()].Text);
               getQuantity++;
               this.Controls["quantLabel" + selectedItemsListBox.SelectedIndex.ToString()].Text = getQuantity.ToString();
            }
        }


    }
}
