using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleTracker
{
    public partial class Login : Form
    {

        public static int Id { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            if (context.USERs.Any(c => c.User_ID == txtUserName.Text && c.User_ID == txtPassword.Text))
            {
                Id = context.USERs.Where(c => c.UserName_Email == txtUserName.Text && c.User_ID == txtPassword.Text)
                    .Select(c => Convert.ToInt16(c.User_ID)).First();
                //bring user to next page
                Purchase prod = new Purchase();
                prod.Show();
            }

            else
            {
                MessageBox.Show("No Such Login");
                Create_Login accnt = new Create_Login();
                accnt.Show();
            }
        }



        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form frm = new Sales();
            frm.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

