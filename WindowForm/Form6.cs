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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student StudentInfo = new student();
            StudentInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course courseInfo = new Course();
            courseInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacherInfo = new Teacher();
            teacherInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fee feeInfo = new fee();
            feeInfo.Show();
        }
    }
}
