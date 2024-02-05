using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FilterWindow : Form
    {
        public decimal? PriceFrom => string.IsNullOrEmpty(txtPriceFrom.Text) ? (decimal?)null : decimal.Parse(txtPriceFrom.Text);
        public decimal? PriceTo => string.IsNullOrEmpty(txtPriceTo.Text) ? (decimal?)null : decimal.Parse(txtPriceTo.Text);
        public int? SizeFrom => string.IsNullOrEmpty(txtSizeFrom.Text) ? (int?)null : int.Parse(txtSizeFrom.Text);
        public int? SizeTo => string.IsNullOrEmpty(txtSizeTo.Text) ? (int?)null : int.Parse(txtSizeTo.Text);
        public FilterWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FilterWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
