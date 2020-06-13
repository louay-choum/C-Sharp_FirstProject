using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{

    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
           // SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["FinalProject.Properties.Settings.finalprojectConnectionString"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [ComTable] , [UsersTable] Where Cid=ID ", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "User ID";
            dataGridView1.Columns[0].DataPropertyName = "Cid";
            dataGridView1.Columns[2].HeaderText = "User Comments";
            dataGridView1.Columns[2].DataPropertyName = "Comments";
            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.DataSource = dt;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comments_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            bindgrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }

        }
    }

