using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopW
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void coffeebutton_Click(object sender, EventArgs e)
        {
            Coffee cf = new Coffee();
            cf.ShowDialog();
        }

        private void staffbutton_Click(object sender, EventArgs e)
        {
            Staff sf = new Staff();
            sf.ShowDialog();
        }

        private void customerbutton_Click(object sender, EventArgs e)
        {
            Customer ct = new Customer();
            ct.ShowDialog();
        }

        private void Promotionbutton_Click(object sender, EventArgs e)
        {
            Promotion pm = new Promotion();
            pm.ShowDialog();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
