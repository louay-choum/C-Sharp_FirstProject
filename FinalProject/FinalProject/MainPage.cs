using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comments c = new Comments();
            c.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS IS A SIMPLE APPLICATION THAT I MADE AS MY FINAL PROJECT I HOPE THAT YOU LIKE IT!\nID:2163024\nBEST REGARDS!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Binding b = new Binding();
            b.Show();
        }
    }
}
