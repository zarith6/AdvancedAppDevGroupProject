namespace GroupProjectUIMockUp
{
    partial class IntroForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create new account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Use existing account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Vandevan Auto Parts!";
            // 
            // addPartsButton
            // 
            this.addPartsButton.Location = new System.Drawing.Point(227, 53);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(95, 35);
            this.addPartsButton.TabIndex = 3;
            this.addPartsButton.Text = "button3";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.addPartsButton_Click_1);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 209);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPartsButton;
    }
}