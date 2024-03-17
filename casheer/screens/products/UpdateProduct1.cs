using casheer.DB;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casheer.screens.products
{
    public partial class UpdateProduct1 : Form
    {
        casheerEntities db = new casheerEntities();
        Product p = new Product();
        string ImagePath;
        public UpdateProduct1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProduct1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet6.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.casheerDataSet6.Product);

        }

        private void btn_srch_Click(object sender, EventArgs e)

        {
            string name;
            if(txt_ProductNameSrch.Text == "")
            {
                name = "jgnbkj";
            }
            else
            {
                name = txt_ProductNameSrch.Text;
            }
            //txt_ProductNameSrch.Text = "hjgkkhj";

            dataGridView_Product.DataSource = db.Products.Where(x =>  x.Code == txt_Parecode.Text || x.Name.Contains(name)).ToList();
            //x.Name.Contains(txt_ProductNameSrch.Text) ||
        }

        private void btn_rfrch_Click(object sender, EventArgs e)
        {
            dataGridView_Product.DataSource = db.Products.ToList();
        }

        private void dataGridView_Product_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Product_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_Product.CurrentRow.Cells[0].Value.ToString());

            p = db.Products.FirstOrDefault(m => m.Id == id);

            txt_ProductName.Text = p.Name;
            txt_Quantity.Text = p.Quantity.ToString();
            picture_product.ImageLocation = p.Image;
        }

        private void picture_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                picture_product.ImageLocation = dialog.FileName;

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            p.Name = txt_ProductName.Text;
            p.Quantity = int.Parse(txt_Quantity.Text);

            if (ImagePath != "")
            {
                string NewPath = Environment.CurrentDirectory + "\\images\\users\\" + p.Id + ".png";
                File.Copy(ImagePath, NewPath, true);

                p.Image = NewPath;
                db.SaveChanges();
            }



            db.SaveChanges();



            MessageBox.Show("! تم تعديل بيانات المنتج بنجاح ");
        }
    }
}
