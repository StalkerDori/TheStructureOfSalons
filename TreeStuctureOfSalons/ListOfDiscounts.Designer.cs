namespace TreeStuctureOfSalons
{
    partial class ListOfDiscounts
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
            this.DiscountList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DiscountList
            // 
            this.DiscountList.BackColor = System.Drawing.Color.Black;
            this.DiscountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountList.Font = new System.Drawing.Font("Nina", 18F, System.Drawing.FontStyle.Bold);
            this.DiscountList.ForeColor = System.Drawing.Color.White;
            this.DiscountList.FormattingEnabled = true;
            this.DiscountList.ItemHeight = 29;
            this.DiscountList.Location = new System.Drawing.Point(0, 0);
            this.DiscountList.Name = "DiscountList";
            this.DiscountList.Size = new System.Drawing.Size(797, 459);
            this.DiscountList.TabIndex = 0;
            this.DiscountList.SelectedIndexChanged += new System.EventHandler(this.DiscountList_SelectedIndexChanged);
            this.DiscountList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiscountList_MouseDown);
            this.DiscountList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DiscountList_MouseMove);
            // 
            // ListOfDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 459);
            this.Controls.Add(this.DiscountList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfDiscounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfDiscounts";
            this.Load += new System.EventHandler(this.ListOfDiscounts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DiscountList;
    }
}
