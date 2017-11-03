using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            sales.Show();
            Hide();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            stockStatusReport stock = new stockStatusReport();
            stock.Show();
            Hide();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            itemSupplyReport supply = new itemSupplyReport();
            supply.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m3 = new MainMenu();
            m3.Show();
            Hide();
        }
    }
}
