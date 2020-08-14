using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaker.Forms
{
    public partial class CheckInForm : Form
    {
        public static List<User> user;
        public static IQueryable<User> UserEnum;

        public CheckInForm()
        {
            InitializeComponent();

            GetDB();
            
           
        }
     

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            //string s = ;
            //int i = Convert.ToInt32("123");
            int i = 0;
            if (Phone.Text != "" ) i = Int32.Parse(Phone.Text);
            //uConvert(s, NumberStyles.AllowExponent);
            if (Login.Text != "" && Phone.Text != "" && Password.Text != "")
                AddUser(Login.Text, Password.Text, i, this);
            else
            {
                MessageBox.Show("Error");

                return;
            }



        }
        private static void GetDB()
        {
            var context = new ShakeDbEntities3();

            UserEnum = context.User;

            user = UserEnum.ToList();
        }
        public static void AddUser(string UserName, string UserPassword, int UserPhone, Form form)
        {
            
            foreach (var s in user)
            {
                bool Collision = false;
                if (UserName == s.Login) Collision = true;

                if (!Collision)
                {
                    using (ShakeDbEntities3 context = new ShakeDbEntities3())
                    {
                        User user = new User();

                        user.Login = UserName;
                        user.Password = UserPassword;
                        user.Phone = UserPhone;

                        context.User.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("Done");
                        form.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                    
                    return;
                }

                
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
