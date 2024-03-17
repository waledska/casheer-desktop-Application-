using casheer.screens.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using casheer.screens.products;


namespace casheer.screens.menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            UserNow.Text = user.Name;
            lbl_Id.Text = Convert.ToString(user.Id);
            picture_Now.ImageLocation = user.Path;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void اضافهموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اغلاقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void اضافهمستخدمجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();



        }
           
    void OpenForm()
    {
        Application.Run(new NewUser());
    }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void UserNow_Click(object sender, EventArgs e)
        {

        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمنتجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenFormNewProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
     void OpenFormNewProduct()
     {
            Application.Run(new Add_New_Product());
     }

        private void اضافهمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(UbdatUser);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();



        }

        void UbdatUser()
        {
            Application.Run(new UpdateUser());
        }

        private void btn_BillsSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {

        }

        private void btn_SalesBills_Click(object sender, EventArgs e)
        {

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {

        }
    }
    
}
    

