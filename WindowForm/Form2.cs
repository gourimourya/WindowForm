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
using System.Data.SqlClient;

namespace WindowForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saved_Click(object sender, EventArgs e)
        {
            //1.address of sql server and database
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.establish connectiom
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open connection
            con.Open();

            //4.prepare query
            String FirstName = textfirstname.Text;
            String SecondName = textsecondname.Text;
            String Query = "INSERT INTO student (firstname,secondname) VALUES ('" + FirstName + "' , '" + SecondName + "')";

            //5.excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //6.close connection
            con.Close();

            MessageBox.Show("Data has been saved");
        }

        private void show_Click(object sender, EventArgs e)
        {
            //1.address of sql server and databse (connection string) 
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.established connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open conection
            con.Open();

            //4.prepare query
            String Query = "SELECT *FROM student";
            SqlCommand cmd = new SqlCommand(Query, con);

            //5.excuted query
            var reader = cmd.ExecuteNonQuery();

            while(reader.Read())
            {
                btshowdata.Rows.Add(reader["ID"], reader["FirstName"].ToString().ToUpper() + " " + reader["SecondName"]);
            }

           /*
            DataTable table = new DataTable();
            table.Load(reader);

            btshowdata.DataSource = table;*/

            //6.close connection
            con.Close();
        }

        
    }
}
