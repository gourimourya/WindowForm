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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=hotelDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into booking Value (@id,@guestname,@roomno,@roomtype,@hotelcode)",con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@GuestName", textguestname.Text);
            cmd.Parameters.AddWithValue("@RoomNo", int.Parse(textroomno.Text));
            cmd.Parameters.AddWithValue("@RoomType", textroomtype.Text);
            cmd.Parameters.AddWithValue("@HotelCode", texthotelcode.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved Successfully" , "Save" , MessageBoxButtons.OK , MessageBoxIcon.Information);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=hotelDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From booking", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=hotelDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update booking Set guestname=@guestname,roomno=@roomno,roomtype=@roomtype,hotelcode=@hotelcode Where id=@id ", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textid.Text));
            cmd.Parameters.AddWithValue("@GuestName", textguestname.Text);
            cmd.Parameters.AddWithValue("@RoomNo", int.Parse(textroomno.Text));
            cmd.Parameters.AddWithValue("@RoomType", textroomtype.Text);
            cmd.Parameters.AddWithValue("@HotelCode", texthotelcode.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=hotelDb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select * From booking", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
