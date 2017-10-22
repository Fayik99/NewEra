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
    public partial class RecordSupplyOrder : Form
    {
        public RecordSupplyOrder()
        {
          
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Supplier s2 = new Supplier();
            s2.Show();
            Hide();
        }

        private void RecordSupplyOrder_Load(object sender, EventArgs e)
        {
            string a= DateTime.Today.ToString("dd-MM-yyyy");
            lbl_date.Text = "Current Date: " + a;
        }
    }
}
