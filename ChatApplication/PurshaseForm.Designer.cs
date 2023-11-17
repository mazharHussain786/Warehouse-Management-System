namespace ChatApplication
{
    partial class PurshaseForm
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
            this.Quantity = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(159, 250);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(121, 23);
            this.Quantity.TabIndex = 0;
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(159, 190);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(121, 21);
            this.List.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // Quan
            // 
            this.Quan.AutoSize = true;
            this.Quan.Location = new System.Drawing.Point(161, 224);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(46, 13);
            this.Quan.TabIndex = 3;
            this.Quan.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(159, 57);
            this.orderId.Multiline = true;
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(121, 23);
            this.orderId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OrderID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Delivery Date";
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(297, 235);
            this.Cart.Multiline = true;
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(323, 113);
            this.Cart.TabIndex = 19;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(328, 124);
            this.Adress.Multiline = true;
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(121, 23);
            this.Adress.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Adress";
            // 
            // EmailBox
            // 
            this.EmailBox.FormattingEnabled = true;
            this.EmailBox.Location = new System.Drawing.Point(159, 124);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(121, 21);
            this.EmailBox.TabIndex = 22;
            // 
            // PurshaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Quantity);
            this.Name = "PurshaseForm";
            this.Size = new System.Drawing.Size(837, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.ComboBox List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cart;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EmailBox;
    }
}
