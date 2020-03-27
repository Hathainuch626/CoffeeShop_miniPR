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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Trim() == "" && textFirst.Text.Trim() == "" && textLast.Text.Trim() == "" && textPass.Text.Trim() == "" && textPhone.Text.Trim() == "" && textEmail.Text.Trim() == "" )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ระบบผิดพลาด");
                return;
            }

            string Query = "INSERT INTO Register(Username, First name, Last name, Password, Phone Number, Email)";
            SQLiteConnection con = new SQLiteConnection(@"Data Source= E:/source/repos/FinalProject/CoffeeShopW/CoffeeShopW/database/mydb.db; ");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(Query, con);
            //cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("สมัครสมาชิกสำเร็จ");
            Loginpage ln = new Loginpage();
            ln.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Loginpage ln = new Loginpage();
            ln.ShowDialog();
        }
    }
}
