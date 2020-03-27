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
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (usernametextBox.Text.Trim() == "" && passwordtextBox.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน","ระบบผิดพลาด");
            }
            else
            {
               
                string Query = "SELECT * FROM admin WHERE username= @user AND password = @pass";
                SQLiteConnection con = new SQLiteConnection(@"Data Source= E:/source/repos/FinalProject/CoffeeShopW/CoffeeShopW/database/mydb.db; ");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(Query, con);
                cmd.Parameters.AddWithValue("@user", usernametextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordtextBox.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                Home hm = new Home();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("เข้าสู่ระบบเรียบร้อย", "ชื่อผู้ใช้และรหัสผ่านถูกต้อง");
                    hm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้และรหัสผ่านผิดพลาด", "ระบบผิดพลาด");
                }
            }
        }
    
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {
            
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rt = new Register();
            rt.ShowDialog();
        }
    }
}
