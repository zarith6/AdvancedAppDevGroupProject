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
{   //*****************************************************************************************************************
    //* This class only existed so I could add parts to the database easily. It's unnecessary now that it's been done.*
    //*****************************************************************************************************************

    public partial class AddParts : Form
    {
        public AddParts()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (AutoPartsDbContext db = new AutoPartsDbContext())
            {
                try
                {
                    db.Parts.Add(new AutoPart
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        Price = (decimal)Convert.ToDecimal(priceTextBox.Text)

                    });
                    db.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
