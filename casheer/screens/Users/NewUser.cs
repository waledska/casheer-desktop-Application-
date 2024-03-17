using casheer.DB;
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
using casheer;

namespace casheer.screens.Users
{
    public partial class NewUser : Form
    {
        casheerEntities db = new casheerEntities();
        string ImagePath ;
        
        public NewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {


            User u = new User
            {
                UserName = txt_UserName.Text,
                Password = txt_Password.Text,
                //Image = ImagePath
            };

            db.Users.Add(u);
            db.SaveChanges();

            string NewPath = Environment.CurrentDirectory + "\\images\\users\\" + u.Id + ".png";
            File.Copy(ImagePath, NewPath);

            u.Image = NewPath;
            db.SaveChanges();


            MessageBox.Show("! تم حفظ المستخدم الجديد بنجاح ");

            ResetFun();

        }

        public void ResetFun()
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
            pictureBox.ImageLocation = "";
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                pictureBox.ImageLocation = dialog.FileName;

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
