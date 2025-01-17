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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Transaction Value (@id,@transactiontype,@amount,@transactiontype,@accountid)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@TransactionType", texttransactiontype.Text);
            cmd.Parameters.AddWithValue("@Amount", int.Parse(textamount.Text));
            cmd.Parameters.AddWithValue("@TransactionDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@AccountId", textaccountid.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.keyCode == Keys.Back)
            {
                dateTimePicker1 CustomFormat = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From Transaction", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Transaction Set transactiontype=@transactiontype,amount=@amount,transactiontype=@transactiontype,accountid=@accountid Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@TransactionType", texttransactiontype.Text);
            cmd.Parameters.AddWithValue("@Amount", int.Parse(textamount.Text));
            cmd.Parameters.AddWithValue("@TransactionDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@AccountId", textaccountid.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Transaction Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!");
        }
    }
}
