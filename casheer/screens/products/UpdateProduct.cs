using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casheer.screens.products
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.casheerDataSet2.Product);

        }

        private void dataGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
