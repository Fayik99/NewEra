﻿using System;
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
   
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Proprietor proprietor = new Proprietor()
            {
                ProprietorUsername = txt_user.Text,
                ProprietorPassword=txt_pwd.Text
            };
            var result=proprietor.PLogin(proprietor);


            if (result == true)
            {
               
                MainMenu mainmenu = new MainMenu();
                mainmenu.Show();
                Hide();
            }
            else
                MessageBox.Show("Invalid Username or password");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
