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
    public partial class itemSupplyReport : Form
    {
        public itemSupplyReport()
        {
            InitializeComponent();
        }

        private void itemSupplyReport_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'supplyDataSet.PurchaseDetailFile' table. You can move, or remove it, as needed.
            this.PurchaseDetailFileTableAdapter.Fill(this.supplyDataSet.PurchaseDetailFile,dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports iu = new reports();
            iu.Show();
        }
    }
}
