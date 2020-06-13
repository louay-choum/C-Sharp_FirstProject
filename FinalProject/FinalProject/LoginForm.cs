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
       
     public partial class LoginForm : Form
    {
        int id;
        string pass;
      

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
          
            
           if (txtID.Text.Equals(""))
                MessageBox.Show("Please Enter ID");

               

             else if (txtPassword.Text.Equals(""))
                MessageBox.Show("Please Enter Password!");


           else if (!txtID.Text.Equals("") && !txtPassword.Text.Equals(""))
           {
                 this.id= int.Parse(txtID.Text);
                 this.pass= txtPassword.Text;

                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True");
                string query = "Select * from UsersTable where ID=" + id + "AND Password = '" + pass + "'";
                SqlDataAdapter sadapter = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sadapter.Fill(dtable);

                if (dtable.Rows.Count == 1)
                {
                    MainPage objMain = new MainPage();
                    this.Hide();
                    con.Open();
                    SqlCommand sadapter2 = new SqlCommand("Select Name from UsersTable where ID=" + id, con);
                    SqlDataReader dr = sadapter2.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            MessageBox.Show("Welcome back, " + dr[0]+"! ");
                        }
                    }
                    objMain.Show();
                    con.Close();
                }
                else
                    MessageBox.Show("Incorrect password or ID");
            }
            

           

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPassword.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there, if you're not a member then try loging in with the following credentials : \n\n ID: 1 \t Password: 123");
                                
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
