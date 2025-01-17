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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Customers customersInfo = new Customers();
            customersInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account accountInfo = new Account();
            accountInfo.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Transaction transactionInfo = new Transaction();
            transactionInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loans loanInfo = new Loans();
            loanInfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employeeInfo = new Employee();
            employeeInfo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboardInfo = new Dashboard();
            dashboardInfo.Show();
        }
    }
}
