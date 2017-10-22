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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void invoice_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Sales m = new Sales();
            m.Show();
            Hide();
        }
    }
}
