namespace ChatApplication
{
    partial class UserHomePage
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
            this.MyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MyGrid
            // 
            this.MyGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGrid.Location = new System.Drawing.Point(0, 0);
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.Size = new System.Drawing.Size(800, 345);
            this.MyGrid.TabIndex = 0;
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyGrid);
            this.Name = "UserHomePage";
            this.Text = "UserHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MyGrid;
    }
}