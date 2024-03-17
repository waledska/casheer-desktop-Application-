using casheer.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casheer.screens.clients
{
    public partial class UpdateClient : Form
    {
        casheerEntities db = new casheerEntities();
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checked_Client.SelectedIndex; 
            if (index == 0 )
            {
                //updating
                checked_Client.SetItemChecked(1, false);
                dataGridView_Customers.DataSource = db.Customers.ToList();
                
                



            }
            else if (index == 1)
            {
                //add new client
                checked_Client.SetItemChecked(0, false);
                dataGridView_Customers.DataSource = null;

            }
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.casheerDataSet3.Customer);

        }
    }
}
