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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UsersTable values (@ID,@Name,@Age,@Password,@Email)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();
                
                MessageBox.Show("Seccesfully Saved!");
               
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update UsersTable set Name=@Name, Age=@Age, Password=@Password, Email=@Email where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();

                MessageBox.Show("Seccesfully Updated!");
                
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete UsersTable where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();

                MessageBox.Show("Seccesfully Deleted!");
                
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from UsersTable where ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                data.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }
            else {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from UsersTable", con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                data.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Comments d = new Comments();
            d.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter ID and press Search");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

    }
}
