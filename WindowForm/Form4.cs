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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            //1.address sql server and database
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open connection
            con.Open();

            //4.prepare query
            String FirstName = textfirst.Text;
            String LastName = textlast.Text;
           
            String Query = "INSERT INTO register\r\n(firstname,lastname,username,password,confirmpassword)\r\nVALUES\r\n('"+FirstName+"','"+LastName+"')";

            //5.excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //6.close connection
            con.Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@\"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) From registor Where UserName = '" + textuser.Text + "' and Password = '" + textpass.Text + "' and ConfirmPassword = '" + textconfirm.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "3")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();

            }
            else
            {
                MessageBox.Show("Please Check You Username and Password and Confirmpassword");
            }

        }
    }
}
