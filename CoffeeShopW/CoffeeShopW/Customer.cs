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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Showstaffbutton_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source= E:/source/repos/FinalProject/CoffeeShopW/CoffeeShopW/database/mydb.db; ");
            con.Open();
            string query = "SELECT* from Customer";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            dataGridView.DataSource = dt;
        }
    }
}
