namespace ChatApplication
{
    partial class RegisterUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PassText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(233, 172);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(213, 30);
            this.PassText.TabIndex = 0;
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(233, 251);
            this.UserText.Multiline = true;
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(213, 28);
            this.UserText.TabIndex = 1;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(233, 88);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(213, 31);
            this.EmailText.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.White;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EmailLabel.Location = new System.Drawing.Point(234, 56);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(236, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(235, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserName";
            // 
            // Regbtn
            // 
            this.Regbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Regbtn.Location = new System.Drawing.Point(276, 300);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(105, 33);
            this.Regbtn.TabIndex = 7;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = false;
            this.Regbtn.Click += new System.EventHandler(this.Register);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChatApplication.Properties.Resources._83196_chat_1024x1024;
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.PassText);
            this.Name = "RegisterUser";
            this.Size = new System.Drawing.Size(799, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Regbtn;
    }
}
