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
    public partial class customerB : Form
    {
        public customerB()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Customer Value (@id,@name,@phone,@email,@address)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Phone", textphone.Text);
            cmd.Parameters.AddWithValue("@Email", textemail.Text);
            cmd.Parameters.AddWithValue("@Address", textaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Customer Set name=@name,phone=@phone,email=@email,address=@address Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Phone", textphone.Text);
            cmd.Parameters.AddWithValue("@Email", textemail.Text);
            cmd.Parameters.AddWithValue("@Address", textaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Customer Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id",int.Parse( textid.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
