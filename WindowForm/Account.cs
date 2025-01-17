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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Accounts Value (@id,@accounttype,@balance,@dataopened,@customername)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@AccountType", textaccounttype.Text);
            cmd.Parameters.AddWithValue("@Balance", int.Parse(textbalance.Text));
            cmd.Parameters.AddWithValue("@DataOpened", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@CustomerName", textname.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, EventArgs e)
        {
            if (e.keyCode == Keys.Back)
            {
                dateTimePicker1 CustomFormat = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Accounts", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Customer Set ,accounttype=@accounttype,balance=@balance,dataopened=@dataopened,customername=@customername Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@AccountType", textaccounttype.Text);
            cmd.Parameters.AddWithValue("@Balance", int.Parse(textbalance.Text));
            cmd.Parameters.AddWithValue("@DataOpened", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@CustomerName", textname.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Customer Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!");
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Accounts Where Accounts Where customername=@customername ", con);
            cmd.Parameters.AddWithValue("@CustomerName", textname.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }
    }
}
