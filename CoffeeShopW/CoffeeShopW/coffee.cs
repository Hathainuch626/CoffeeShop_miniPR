using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopW
{
    public partial class Coffee : Form
    {
        string coffee;
        string drink;
        string cake;
        SQLiteConnection con = new SQLiteConnection(@"Data Source= E:/source/repos/FinalProject/CoffeeShopW/CoffeeShopW/database/mydb.db; ");

        public Coffee()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Menu(coffee, drink, cake) VALUES('"+coffee+ "','" +drink+ "','" +cake+ "')";
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("เพิ่มเรียบร้อยแล้ว");
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void lattecheck_CheckedChanged(object sender, EventArgs e)
        {
            coffee = "ลาเต้ร้อน";
        }

        private void cappuccinocheck_CheckedChanged(object sender, EventArgs e)
        {
            coffee = "คาปูชิโน";
        }

        private void mochacheck_CheckedChanged(object sender, EventArgs e)
        {
            coffee = "มอคค่า";
        }

        private void cocoacheck_CheckedChanged(object sender, EventArgs e)
        {
            drink = "โกโก้ปั่น";
        }

        private void chocolatecheck_CheckedChanged(object sender, EventArgs e)
        {
            drink = "ช็อคโกแลต";
        }

        private void Thaiteacheck_CheckedChanged(object sender, EventArgs e)
        {
            drink = "ชาไทยปั่น";
        }

        private void coconutcakecheck_CheckedChanged(object sender, EventArgs e)
        {
            cake = "เค้กมะพร้าว";
        }

        private void crepecakecheck_CheckedChanged(object sender, EventArgs e)
        {
            cake = "เครปเค้ก";
        }

        private void honeytoastcheck_CheckedChanged(object sender, EventArgs e)
        {
            cake = "ฮันนีโทสต์";
        }

        private void freshmilkcheck_CheckedChanged(object sender, EventArgs e)
        {
            drink = "นมสดปั่น";
        }

        private void greenteacheck_CheckedChanged(object sender, EventArgs e)
        {
            drink = "ชาเขียว";
        }

        private void Affogatocheck_CheckedChanged(object sender, EventArgs e)
        {
            coffee = "อัฟโฟกาโตร้อน";
        }

        private void americanocheck_CheckedChanged(object sender, EventArgs e)
        {
            coffee = "อเมริกาโน่ร้อน";
        }

        private void chocolatecakecheck_CheckedChanged(object sender, EventArgs e)
        {
            cake = "เค้กช็อกโกแลต";
        }

        private void pancakescheck_CheckedChanged(object sender, EventArgs e)
        {
            cake = "แพนเค้ก";
        }
    }
}
