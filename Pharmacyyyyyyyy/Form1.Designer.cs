namespace Pharmacyyyyyyyy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adminBttn = new System.Windows.Forms.Button();
            this.eyePassBttn = new System.Windows.Forms.Button();
            this.hidePassBttn = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminBttn
            // 
            this.adminBttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBttn.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminBttn.Location = new System.Drawing.Point(97, 306);
            this.adminBttn.Name = "adminBttn";
            this.adminBttn.Size = new System.Drawing.Size(117, 25);
            this.adminBttn.TabIndex = 31;
            this.adminBttn.Text = "Admin Panel";
            this.adminBttn.UseVisualStyleBackColor = false;
            // 
            // eyePassBttn
            // 
            this.eyePassBttn.BackColor = System.Drawing.Color.White;
            this.eyePassBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyePassBttn.BackgroundImage")));
            this.eyePassBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyePassBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyePassBttn.Location = new System.Drawing.Point(242, 166);
            this.eyePassBttn.Name = "eyePassBttn";
            this.eyePassBttn.Size = new System.Drawing.Size(29, 26);
            this.eyePassBttn.TabIndex = 30;
            this.eyePassBttn.UseVisualStyleBackColor = false;
            this.eyePassBttn.Click += new System.EventHandler(this.eyePassBttn_Click);
            // 
            // hidePassBttn
            // 
            this.hidePassBttn.BackColor = System.Drawing.Color.White;
            this.hidePassBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePassBttn.BackgroundImage")));
            this.hidePassBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hidePassBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassBttn.Location = new System.Drawing.Point(242, 166);
            this.hidePassBttn.Name = "hidePassBttn";
            this.hidePassBttn.Size = new System.Drawing.Size(29, 26);
            this.hidePassBttn.TabIndex = 29;
            this.hidePassBttn.UseVisualStyleBackColor = false;
            this.hidePassBttn.Click += new System.EventHandler(this.hidePassBttn_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.AliceBlue;
            this.loginButton.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(87, 220);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(144, 26);
            this.loginButton.TabIndex = 28;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(134, 167);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(137, 25);
            this.passBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ISOCTEUR", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "PASSWORD";
            // 
            // usnameBox
            // 
            this.usnameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usnameBox.Location = new System.Drawing.Point(134, 114);
            this.usnameBox.Name = "usnameBox";
            this.usnameBox.Size = new System.Drawing.Size(137, 25);
            this.usnameBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ISOCTEUR", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "USERNAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 343);
            this.Controls.Add(this.adminBttn);
            this.Controls.Add(this.eyePassBttn);
            this.Controls.Add(this.hidePassBttn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usnameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button adminBttn;
        private Button eyePassBttn;
        private Button hidePassBttn;
        private Button loginButton;
        private TextBox passBox;
        private Label label2;
        private TextBox usnameBox;
        private Label label1;
    }
}