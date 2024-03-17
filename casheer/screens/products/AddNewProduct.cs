using casheer.DB;
using DocumentFormat.OpenXml.EMMA;
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
    public partial class Add_New_Product : Form
    {
        casheerEntities db = new casheerEntities();
        string ImagePath;
        public Add_New_Product()
        {
            InitializeComponent();
        }

        private void Add_New_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.casheerDataSet.Supplier);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = txt_ProductName.Text,
                Code = txt_ProductParcode.Text,
                Price = txt_ProductPrice.Text,
                Quantity = int.Parse(txt_ProductAmount.Text),
                Id_Section = comboBox_supplier.SelectedIndex, 

                //Image = ImagePath
            };


            db.Products.Add(p);
            db.SaveChanges();

            string NewPath = Environment.CurrentDirectory + "\\images\\Suppliers\\" + p.Id + ".png";
            File.Copy(ImagePath, NewPath);

            p.Image = NewPath;
            db.SaveChanges();


            MessageBox.Show("! تم حفظ النتج الجديد بنجاح ");

            p.Name = "";
            p.Code = "";
            p.Price = "";
            p.Quantity = int.Parse("");
            p.Id_Section = int.Parse("");
            p.Image = "";
            picture_product.ImageLocation = "";


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
    }
}
