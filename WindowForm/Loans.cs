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
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Loans Value (@id,@loantype,@amount,@interestrate,@loandate,@customername)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@LoanType", textloantype.Text);
            cmd.Parameters.AddWithValue("@Amount", int.Parse(textamount.Text));
            cmd.Parameters.AddWithValue("@InterestRate", textinterestrate.Text);
            cmd.Parameters.AddWithValue("@LoanDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@CustomerName", textname.Text);
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
            SqlCommand cmd = new SqlCommand("Select * From Loans", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Loans Set @loantype,@amount,@interestrate,@loandate,@customername Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@LoanType", textloantype.Text);
            cmd.Parameters.AddWithValue("@Amount", int.Parse(textamount.Text));
            cmd.Parameters.AddWithValue("@InterestRate", textinterestrate.Text);
            cmd.Parameters.AddWithValue("@LoanDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@CustomerName", textname.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Upadted Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete From Loans Where id=@id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!");
        }
    }
}
