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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void buttonshow_Click(object sender, EventArgs e)
        {
            //1.address of sql server and databse (connection string) 
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.established connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open conection
            con.Open();

            //4.prepare query
            String Query = "SELECT * FROM student";
            SqlCommand cmd = new SqlCommand(Query, con);

            //5.excuted query
            var reader = cmd.ExecuteNonQuery();

            //..rows clear..
            btshowdata.Rows.Clear();

            while(reader.Read())
            {
                btshowdata.Rows.Add(reader["ID"], reader["FirstName"], reader["SecondName"],"Edit" , "Delete");
            }
                

            /*
            //..this is using upper and lower case this rows and columns....
             while (reader.Read())
            {
                btshowdata.Rows.Add(reader["ID"], reader["FirstName"].ToString().ToUpper() + " " + reader["SecondName"]);
            }

            //..this is using full table...
             DataTable table = new DataTable();
             table.Load(reader);

             btshowdata.DataSource = table;*/

            //6.close connection
            con.Close();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            //1.address of sql server and database
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.establish connectiom
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open connection
            con.Open();

            //4.prepare query
            String NameID = textid.Text;
            String FirstName = textBoxfirstname.Text;
            String SecondName = textBoxsecondname.Text;
            String Query = "\r\nUPDATE student SET firstname = '"+FirstName+"' , secondname = '"+SecondName+"' WHERE id = "+NameID;

            //5.excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //6.close connection
            con.Close();

            MessageBox.Show("Data has been updated");

            textBoxfirstname.Text = "";
            textBoxsecondname.Text = "";
            textid.Text = "";
        }

        private void textfetch_Click(object sender, EventArgs e)
        {
            //1.address of sql server and database
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.establish connectiom
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open connection
            con.Open();

            //4.prepare query
            String NameID = textid.Text;
           
            String Query = "SELECT * FROM student WHERE id = "+ NameID;

            //5.excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteNonQuery();

            if (reader.Read())
            {
                textfirstname.Text = reader["FirstName"].ToString();
                textsecondname.Text = reader["SecondName"].ToString();
            }
            else
                MessageBox.Show("No record found");

            //6.close connection
            con.Close();



        }

        private void btshowdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.this is using Edit button...
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                textid.Text = btshowdata.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if(e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                String NameID = btshowdata.Rows[e.RowIndex].Cells[0].Value.ToString();

               if(MessageBox.Show("Do you want to delete this record?", "Confirm delete" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //1.address of sql server and database
                    String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

                    //2.establish connectiom
                    SqlConnection con = new SqlConnection(ConnectionString);

                    //3.open connection
                    con.Open();

                    //4.prepare query

                    String Query = "DELETE FROM student WHERE id = " + NameID;

                    //5.excute query
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    //6.close connection
                    con.Close();

                    MessageBox.Show("Data has been deleted");

                    textBoxfirstname.Text = "";
                    textBoxsecondname.Text = "";
                    textid.Text = "";

                    //.this is using direct deleted the row don't using show data button chick...
                    buttonshow_Click(null, null);
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //1.address of sql server and database
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.establish connectiom
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open connection
            con.Open();

            //4.prepare query
            String NameID = textid.Text;
           
            String Query = "DELETE FROM student WHERE id = "+ NameID;

            //5.excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //6.close connection
            con.Close();

            MessageBox.Show("Data has been deleted");

            textfirstname.Text = "";
            textsecondname.Text = "";
            textid.Text = "";

            //.this is using direct deleted the row don't using show data button chick...
            buttonshow_Click(null, null);

            //.this is using choose the column..
            //..textcolumn.SelectedIndex = 0;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            //1.address of sql server and databse (connection string) 
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.established connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open conection
            con.Open();

            //4.prepare query
            String Search = textsearch.Text;
            String Query = "SELECT * FROM student\r\nWHERE firstname LIKE '%"+Search+"%' OR  secondname LIKE '%"+Search+"%'";
            SqlCommand cmd = new SqlCommand(Query, con);

            //5.excuted query
            var reader = cmd.ExecuteNonQuery();

            btshowdata.Rows.Clear();

            while (reader.Read())
            {
                btshowdata.Rows.Add(reader["ID"], reader["FirstName"], reader["SecondName"], "Edit" , "Delete");
            }

            //6.close connection
            con.Close();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            //1.address of sql server and databse (connection string) 
            String ConnectionString = "Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True";

            //2.established connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3.open conection
            con.Open();

            //4.prepare query
            String Search = textsearch.Text;
            String Query = "SELECT * FROM student\r\nWHERE firstname LIKE '%" + Search + "%' OR  secondname LIKE '%" + Search + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);

            //5.excuted query
            var reader = cmd.ExecuteNonQuery();

            btshowdata.Rows.Clear();

            while (reader.Read())
            {
                btshowdata.Rows.Add(reader["ID"], reader["FirstName"], reader["SecondName"], "Edit", "Delete");
            }

            //6.close connection
            con.Close();
        }
    }
}

