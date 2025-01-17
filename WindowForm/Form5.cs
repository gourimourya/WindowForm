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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection(@"Data Source=DESKTOP-CC5PJC1\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO studentt values(@name,@gender,@mobile,@email,@address,@course");
            cmd.Parameters.AddWithValue("@Name",textname.Text);
            cmd.Parameters.AddWithValue("@Gender", textgender.Text);
            cmd.Parameters.AddWithValue("@Mobile", textmobile.Text);
            cmd.Parameters.AddWithValue("@Email", textemail.Text);
            cmd.Parameters.AddWithValue("@Address", textaddress.Text);
            cmd.Parameters.AddWithValue("@Course", textcourse.Text);
            con.Close();
            MessageBox.Show("Successful Registration", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
