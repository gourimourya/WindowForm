using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class form10 : Form
    {
        public form10()
        {
            InitializeComponent();
        }

        private void form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student studentInfo = new student();
            studentInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book bookInfo = new book();
            bookInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            borrowing borrowingInfo = new borrowing();
            borrowingInfo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            library libraryInfo = new library();
            libraryInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
