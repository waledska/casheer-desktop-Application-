using casheer.DB;
using DocumentFormat.OpenXml.Office2010.Excel;
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

namespace casheer.screens.Users
{
    public partial class UpdateUser : Form
    {
        public User u = new User();
        casheerEntities db = new casheerEntities();
        string ImagePath ;
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            u.UserName = txt_UserName.Text;
            u.Password = txt_Password.Text;

            if (ImagePath != "")
            {
                string NewPath = Environment.CurrentDirectory + "\\images\\users\\" + u.Id + ".png";
                File.Copy(ImagePath, NewPath,true);

                u.Image = NewPath;
                db.SaveChanges();
            }



            db.SaveChanges();


           
            MessageBox.Show("! تم تعديل بيانات المستخدم بنجاح ");

            
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'casheerDataSet5.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.casheerDataSet5.Product);
            // TODO: This line of code loads data into the 'casheerDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.casheerDataSet1.Users);

        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            

            dataGridView_Users.DataSource = db.Users.Where(x=>x.UserName == txt_UserNameSrch.Text).ToList();
            




        }

        private void dataGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                pictureBox.ImageLocation = dialog.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Users.Remove(u);
            db.SaveChanges();
        }

        private void txt_UserNameSrch_TextChanged(object sender, EventArgs e)
        {
            if(txt_UserNameSrch.Text == "")
            {
                dataGridView_Users.DataSource = db.Users.ToList();
            }

        }

        private void btn_rfrch_Click(object sender, EventArgs e)
        {
            dataGridView_Users.DataSource = db.Users.ToList();
        }

        private void dataGridView_Users_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_Users.CurrentRow.Cells[0].Value.ToString());
            
            u = db.Users.SingleOrDefault(m => m.Id == id );

            txt_Password.Text = u.Password;
            txt_UserName.Text = u.UserName;
            pictureBox.ImageLocation = u.Image;
        }
    }
}
