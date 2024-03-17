using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casheer.screens.suppliers
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet4.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.casheerDataSet4.Supplier);

        }

        private void checked_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
