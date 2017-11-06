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
    public partial class stockStatusReport : Form
    {
        public stockStatusReport()
        {
            InitializeComponent();
        }

        private void stockStatusReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Item' table. You can move, or remove it, as needed.
            this.ItemTableAdapter.Fill(this.stockDataSet.Item);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            reports nm = new reports();
            nm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Item' table. You can move, or remove it, as needed.
            this.ItemTableAdapter.Fill(this.stockDataSet.Item);

            this.reportViewer1.RefreshReport();
        }
    }
}
