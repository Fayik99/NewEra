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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void btn_so_Click(object sender, EventArgs e)
        {
            RecordSupplyOrder rsp = new RecordSupplyOrder();
            rsp.Show();
            Hide();
        }

        private void btn_rsd_Click(object sender, EventArgs e)
        {
            ManageSupplier ms = new ManageSupplier();
            ms.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m7 = new MainMenu();
            m7.Show();
            Hide();
        }
    }
}
