﻿using System;
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

        public Form1(bool isNewUser, string phoneNumber)
        {
            InitializeComponent();
            motorOil = new Part("Motor Oil", "Oil for your engine", 20.00m);
            brakePads = new Part("Brake Pads", "Replacement pads for your brakes", 15.00m);
            transmissionFluid = new Part("Transmission Fluid", "Fluid for your automatic transmission", 20.00m);
            emailOrderRadioButton.Checked = true;

            if (isNewUser)
            {
                emailTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                phoneNumberTextBox.ReadOnly = false;
            }
            else
            {
                emailTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                phoneNumberTextBox.ReadOnly = true;
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                phoneNumberTextBox.Text = phoneNumber;
                emailTextBox.Text = "Testdata@testdata.com";
                addressTextBox.Text = "123 Fake St. Marietta, GA";
                firstNameTextBox.Text = "John";
                lastNameTextBox.Text = "Smith";
                partDropDownBox.Focus();

                
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
            populateDropDownBox();
        }

        private void partDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partDropDownBox.SelectedItem.ToString() == "Motor Oil")
            {
                productDescriptionLabel.Text = motorOil.Description;
                productPriceLabel.Text = "$" +  motorOil.Price.ToString();
            }
            else if (partDropDownBox.SelectedItem.ToString() == "Transmission Fluid")
            {
                productDescriptionLabel.Text = transmissionFluid.Description;
                productPriceLabel.Text = "$" + transmissionFluid.Price.ToString();
            }
            else if (partDropDownBox.SelectedItem.ToString() == "Brake Pads")
            {
                productDescriptionLabel.Text = brakePads.Description;
                productPriceLabel.Text = "$" + brakePads.Price.ToString();
            }
        }


    }
}