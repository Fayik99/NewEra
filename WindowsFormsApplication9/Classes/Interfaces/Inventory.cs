using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication9.Classes;

namespace WindowsFormsApplication9
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m5 = new MainMenu();
            m5.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ic.Text) == false)
            {
                Item ab = new Item()
                {

                    ItemCode = Convert.ToInt32(txt_ic.Text)



                };
                var dt = ab.checkInventory(ab);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("field cannot be blank", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
