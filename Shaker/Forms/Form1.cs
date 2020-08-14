using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaker
{
    public partial class Form1 : Form
    {
        public static List<Shake> shake;
        public static IQueryable<Shake> ShakeEnum;

        public static string name;

        public Form1()
        {
            InitializeComponent();

            GetDB();
            DeleteDB("BloodMarry");
            //AddShake("BloodMarry", 0,0);

            //EditShake("Nigroni", 4, 3);

            //GetDB();
            //NameLabel.Text = name;

            NameLabel.Text = ShowAll(shake);
        }
        public static string ShowAll(List<Shake> shake)
        {
            string ShowingText = "";

            foreach (var s in shake)
            {
                ShowingText += s.Name + "\t";
                ShowingText += s.Layers + "\t";
                ShowingText += s.SpiritNumber + "\n";
            }

            return ShowingText;
        }
        public static void AddShake(string ShakeName, int ShakeLayers, int ShakeSpiritNumber)
        {

            bool Collision = false;
            foreach (var s in shake)
            {
                if (ShakeName == s.Name) Collision = true;

                if(!Collision)
                { 
                    using (ShakeDbEntities1 context = new ShakeDbEntities1())
                    {
                        Shake shake = new Shake();
                        shake.Name = ShakeName;
                        shake.Layers = ShakeLayers;
                        shake.SpiritNumber = ShakeSpiritNumber;

                        context.Shake.Add(shake);
                        context.SaveChanges();
                    }
                }
            }
        }

        public static void DeleteDB(string ShakeName)
        {

            ShakeDbEntities1 context = new ShakeDbEntities1();

            //var customer = context.Shake.Single(s => s.Name == ShakeName);

            var cus = context.Shake.Where(s => s.ShakeId > 5);

            foreach (var s in cus)
            {
                context.Shake.Remove(s);
            }
            context.SaveChanges();

            //context.Shake.Attach(order);
            /*using (ShakeDbEntities1 context = new ShakeDbEntities1())
            {
                context.Remove(context.Shake.Single(a => a.ShakeId == 4));
            }*/
            /*using (ShakeDbEntities1 context = new ShakeDbEntities1())
            {
                Shake shake = new Shake();
                shake.Name = ShakeName;
                
                context.Shake.Remove(shake);
                context.SaveChanges();
            }*/
        }
        private static void GetDB()
        {
            var context = new ShakeDbEntities1();

            ShakeEnum = context.Shake;

            shake = ShakeEnum.ToList();
        }

        private static void EditShake(string ShakeName, int ShakeLayers, int ShakeSpiritNumber)
        {
            foreach (var s in shake)
            {
                if(ShakeName == s.Name)
                {
                    s.Layers = ShakeLayers;
                    s.SpiritNumber = ShakeSpiritNumber;
                }
            }
        }
    }
}
