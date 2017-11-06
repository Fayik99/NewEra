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
    public partial class itemSupplyReportNew : Form
    {
        public itemSupplyReportNew()
        {
            InitializeComponent();
        }

        private void itemSupplyReportNew_Load(object sender, EventArgs e)
        {
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NewEraDBDataSetItemSupply.itemSupply' table. You can move, or remove it, as needed.
            this.itemSupplyTableAdapter.Fill(this.NewEraDBDataSetItemSupply.itemSupply, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            reports re = new reports();
            re.Show();
            Hide();
        }
    }
}
