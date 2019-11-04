using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TreeStuctureOfSalons
{
    public partial class ListOfDiscounts : Form
    {
        public ListOfDiscounts()
        {
            InitializeComponent();
        }

        private void DiscountList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListOfDiscounts_Load(object sender, EventArgs e)
        {

        }

        Point LastPoint;
        private void DiscountList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void DiscountList_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
