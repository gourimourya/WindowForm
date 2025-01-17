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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into students Values(@id,@book,@number,@author,@publisher)", con);
            cmd.Parameters.AddWithValue("@Id", textid.Text);
            cmd.Parameters.AddWithValue("@Book", textbook.Text);
            cmd.Parameters.AddWithValue("@Number", textnumber.Text);
            cmd.Parameters.AddWithValue("@Author", textauthor.Text);
            cmd.Parameters.AddWithValue("@Publisher", textpublisher.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved SUccessfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From students", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update books Set book=@book,number=@number,author=@author,publisher=@publisher Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@Book", textbook.Text);
            cmd.Parameters.AddWithValue("@Number", int.Parse(textnumber.Text));
            cmd.Parameters.AddWithValue("@Author", textauthor.Text);
            cmd.Parameters.AddWithValue("@Publisher", textpublisher.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated SUccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From books Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted SUccessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From books", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
