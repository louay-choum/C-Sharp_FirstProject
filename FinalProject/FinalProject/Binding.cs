using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Binding : Form
    {
        public Binding()
        {
            InitializeComponent();
        }

        private void Binding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalprojectDataSet1.UsersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.finalprojectDataSet1.UsersTable);
            // TODO: This line of code loads data into the 'finalprojectDataSet1.ComTable' table. You can move, or remove it, as needed.
            this.comTableTableAdapter.Fill(this.finalprojectDataSet1.ComTable);
            // TODO: This line of code loads data into the 'marketDBDataSet.Category' table. You can move, or remove it, as needed.

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

       

      

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableTableAdapter.Fill(this.finalprojectDataSet1.UsersTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
