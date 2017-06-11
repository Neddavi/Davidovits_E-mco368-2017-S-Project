using Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIStore
{
    public partial class MyAccount : Form
    {
        DataClasses1DataContext context;
        public static decimal Credit = 150.00M;

        public MyAccount()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();
            //balance is what they owe
            displayBal.Text = context.USERs.Where(c => c.USER_ID ==Login.Id)
                    .Select(c => c.Balance).First().ToString();
            //credit is how much could spend
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase prod = new Purchase();
            prod.Show();
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {

            int amnt = 0;
            amnt = int.Parse(addMoney.Text);
            USER cust = context.USERs.Single(c => c.USER_ID == Login.Id);
            cust.Balance -= amnt;

            context.SubmitChanges();
            MessageBox.Show("Adding $" + amnt + " to your account balance");
            this.Refresh();
            this.Hide();
            MyAccount accnt = new MyAccount();
            accnt.Show();

        }
    }
}
