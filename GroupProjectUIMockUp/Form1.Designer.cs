namespace GroupProjectUIMockUp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partDropDownBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.partQuantityNumBox = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.emailOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.walkinOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.selectedItemsListBox = new System.Windows.Forms.ListBox();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partQuantityNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(138, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select part:";
            // 
            // partDropDownBox
            // 
            this.partDropDownBox.FormattingEnabled = true;
            this.partDropDownBox.Location = new System.Drawing.Point(214, 103);
            this.partDropDownBox.Name = "partDropDownBox";
            this.partDropDownBox.Size = new System.Drawing.Size(138, 21);
            this.partDropDownBox.TabIndex = 5;
            this.partDropDownBox.SelectedIndexChanged += new System.EventHandler(this.partDropDownBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(216, 25);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number: (xxx-xxx-xxxx)";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(216, 64);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(138, 20);
            this.phoneNumberTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(15, 103);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(138, 20);
            this.addressTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Product Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantity:";
            // 
            // partQuantityNumBox
            // 
            this.partQuantityNumBox.Location = new System.Drawing.Point(9, 227);
            this.partQuantityNumBox.Name = "partQuantityNumBox";
            this.partQuantityNumBox.Size = new System.Drawing.Size(120, 20);
            this.partQuantityNumBox.TabIndex = 19;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(216, 257);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(138, 40);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit Order";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Location = new System.Drawing.Point(12, 263);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.productDescriptionLabel.TabIndex = 15;
            // 
            // emailOrderRadioButton
            // 
            this.emailOrderRadioButton.AutoSize = true;
            this.emailOrderRadioButton.Location = new System.Drawing.Point(15, 129);
            this.emailOrderRadioButton.Name = "emailOrderRadioButton";
            this.emailOrderRadioButton.Size = new System.Drawing.Size(79, 17);
            this.emailOrderRadioButton.TabIndex = 27;
            this.emailOrderRadioButton.TabStop = true;
            this.emailOrderRadioButton.Text = "Email Order";
            this.emailOrderRadioButton.UseVisualStyleBackColor = true;
            this.emailOrderRadioButton.CheckedChanged += new System.EventHandler(this.emailOrderRadioButton_CheckedChanged);
            // 
            // phoneOrderRadioButton
            // 
            this.phoneOrderRadioButton.AutoSize = true;
            this.phoneOrderRadioButton.Location = new System.Drawing.Point(15, 153);
            this.phoneOrderRadioButton.Name = "phoneOrderRadioButton";
            this.phoneOrderRadioButton.Size = new System.Drawing.Size(85, 17);
            this.phoneOrderRadioButton.TabIndex = 28;
            this.phoneOrderRadioButton.TabStop = true;
            this.phoneOrderRadioButton.Text = "Phone Order";
            this.phoneOrderRadioButton.UseVisualStyleBackColor = true;
            this.phoneOrderRadioButton.CheckedChanged += new System.EventHandler(this.phoneOrderRadioButton_CheckedChanged);
            // 
            // walkinOrderRadioButton
            // 
            this.walkinOrderRadioButton.AutoSize = true;
            this.walkinOrderRadioButton.Location = new System.Drawing.Point(15, 176);
            this.walkinOrderRadioButton.Name = "walkinOrderRadioButton";
            this.walkinOrderRadioButton.Size = new System.Drawing.Size(90, 17);
            this.walkinOrderRadioButton.TabIndex = 29;
            this.walkinOrderRadioButton.TabStop = true;
            this.walkinOrderRadioButton.Text = "Walk-in Order";
            this.walkinOrderRadioButton.UseVisualStyleBackColor = true;
            this.walkinOrderRadioButton.CheckedChanged += new System.EventHandler(this.walkinOrderRadioButton_CheckedChanged);
            // 
            // selectedItemsListBox
            // 
            this.selectedItemsListBox.FormattingEnabled = true;
            this.selectedItemsListBox.Location = new System.Drawing.Point(216, 129);
            this.selectedItemsListBox.Name = "selectedItemsListBox";
            this.selectedItemsListBox.Size = new System.Drawing.Size(138, 121);
            this.selectedItemsListBox.TabIndex = 30;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(363, 128);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(43, 41);
            this.removeItemButton.TabIndex = 31;
            this.removeItemButton.Text = "X";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Order Total:";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(9, 290);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.orderTotalLabel.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 312);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.selectedItemsListBox);
            this.Controls.Add(this.walkinOrderRadioButton);
            this.Controls.Add(this.phoneOrderRadioButton);
            this.Controls.Add(this.emailOrderRadioButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.partQuantityNumBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productDescriptionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partDropDownBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Auto Part Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partQuantityNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox partDropDownBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown partQuantityNumBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.RadioButton emailOrderRadioButton;
        private System.Windows.Forms.RadioButton phoneOrderRadioButton;
        private System.Windows.Forms.RadioButton walkinOrderRadioButton;
        private System.Windows.Forms.ListBox selectedItemsListBox;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label orderTotalLabel;
    }
}

