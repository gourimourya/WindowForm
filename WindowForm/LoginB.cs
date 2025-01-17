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
    public partial class LoginB : Form
    {
        public LoginB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            String UserName = textusername.Text;
            String Password = textpassword.Text;
            SqlCommand cmd = new SqlCommand("Select UserName,Password From logins Where UserName = '" + UserName + "' and Password='" + Password + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed. Please Check Your UserName And Password");
            }
            con.Close();
        }
    }
}
