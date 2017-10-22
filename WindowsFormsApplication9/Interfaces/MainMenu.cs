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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            item item = new item();
            item.Show();
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            reports report = new reports();
            report.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Inventory inventory= new Inventory();
            inventory.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerOrder order = new CustomerOrder();
            order.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Quotation q = new Quotation();
            q.Show();
            Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();
            Hide();
        }

        private void btn_Lo_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            Hide();
        }
    }
}
