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

namespace WindowForm
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into teacherdb values (@name,@age,@gender)", con);
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Age", textage.Text);
            cmd.Parameters.AddWithValue("@Gender", textgender.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From teacherdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update teacherdb Set age=@age,gender=@gender Where name=@name", con);
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Age", textage.Text);
            cmd.Parameters.AddWithValue("@Gender",textgender.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From teacherdb Where name=@name", con);
            cmd.Parameters.AddWithValue("@Name", textname.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From teacherdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
