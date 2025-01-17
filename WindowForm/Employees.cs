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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Employes Value (@id,@name,@position,@salary)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Position", textposition.Text);
            cmd.Parameters.AddWithValue("@Salary", textsalary.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Employes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Employes Set name=@name,position=@position,salary=@salary Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@Name", textname.Text);
            cmd.Parameters.AddWithValue("@Position", textposition.Text);
            cmd.Parameters.AddWithValue("@Salary", textsalary.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Employes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
