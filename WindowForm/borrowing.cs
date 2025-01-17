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
    public partial class borrowing : Form
    {
        public borrowing()
        {
            InitializeComponent();
        }

        private void borrowing_Load(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into borrowings Values(@id,@name,@book,@databorrowed,@datareturn)", con);
            cmd.Parameters.AddWithValue("@Id", textid.Text);
            cmd.Parameters.AddWithValue("@Name", textboxname.Text);
            cmd.Parameters.AddWithValue("@Book", textboxbook.Text);
            cmd.Parameters.AddWithValue("@DataBorrowed", textdataborrowing.Text);
            cmd.Parameters.AddWithValue("@DataReturn", textreturn.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved SUccessfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From borrowings", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update borrowings Set name=@name,book=@book,databorrowed=@databorrowed,datareturn=@datareturn Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id", textid.Text);
            cmd.Parameters.AddWithValue("@Name", textboxname.Text);
            cmd.Parameters.AddWithValue("@Book", textboxbook.Text);
            cmd.Parameters.AddWithValue("@DataBorrowed", textdataborrowing.Text);
            cmd.Parameters.AddWithValue("@DataReturn", textreturn.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated SUccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From borrowings Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted SUccessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From borrowings", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
