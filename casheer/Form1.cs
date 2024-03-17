using casheer.DB;
using System;
using System.Linq;
using System.Windows.Forms;
using Menu = casheer.screens.menu.Menu;

namespace casheer
{
    public partial class Form1 : Form
    {
        public string NameNoww;
        casheerEntities db = new casheerEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            var result = db.Users.FirstOrDefault(x => x.UserName == txt_UserName.Text && x.Password == txt_Password.Text);


            if (result != null)
            {
                new Menu().Show();

                this.Hide();

                user.Name = result.UserName;
                user.Id = result.Id;
                user.Path = result.Image;

                //    Thread th = new Thread(OpenForm);

                //    th.SetApartmentState(ApartmentState.STA);
                //    th.Start();




            }
            else
            {
                MessageBox.Show("بيانات المستخدم التي ادخلتها ليست صحيحه");
            }
            void OpenForm()
            {
                Application.Run(new Menu());
            }


        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    static class user
    {
        static public string Name { get; set; }
        static public string Path { get; set; }
        static public int Id { get; set; }

    }

}
