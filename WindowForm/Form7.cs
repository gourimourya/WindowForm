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

namespace WindowForm
{
    public partial class Form7 : Form
    {
        public Form7()
        {

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO address VALUES (@id,@name,@city,@marks,@subject)",con);
            cmd.Parameters.AddWithValue("@Id", textid.Text);
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@City", textcity.Text);
            cmd.Parameters.AddWithValue("@Marks", textmarks.Text);
            cmd.Parameters.AddWithValue("@Subject", textsubject.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved");

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From address");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update address Set name=@name,city=@city,marks=@marks,subject=@subject Where id=@id" , con);
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@City", textcity.Text);
            cmd.Parameters.AddWithValue("@Marks", int.Parse(textmarks.Text));
            cmd.Parameters.AddWithValue("@Subject", textsubject.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From address Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted");

        }

    }
}
