using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LocalDatabase : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\ciit\Documents\DB_SIS.mdf;Integrated Security=True;Connect Timeout=30");

        public LocalDatabase()
        {
            InitializeComponent();
        }

        private void LocalDatabase_Load(object sender, EventArgs e)
        {}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [MyTable] (Id,UserName,Password,Email) values ('" + txtID.Text + "','" + txtName.Text + "', '" + txtPassword.Text + "', '" + txtEmailAddress.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                txtID.Text = "";
                txtEmailAddress.Text = "";
                txtName.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("successfully added");
            }
            catch(Exception ex)
            {MessageBox.Show(ex.Message);}
        }
        public void display()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [MyTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dtadap = new SqlDataAdapter(cmd);
            dtadap.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }


        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            display();
        }
    }
}

