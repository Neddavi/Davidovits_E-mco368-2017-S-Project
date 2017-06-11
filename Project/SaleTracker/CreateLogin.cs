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
    public partial class Create_Login : Form
    {
        public Create_Login()
        {
            InitializeComponent();
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                USER user = new USER
                {
                    UserName_Email = txtGmail.Text,
                    User_ID = txtUserID.Text,
                    REP_FNAME = txtFirstN.Text,
                    REP_LNAME = txtLastN.Text,
                    Gender = char.Parse(txtGender.Text),
                    Balance = decimal.Parse(txtBalance.Text)

                };

                context.USERs.InsertOnSubmit(user);
                context.SubmitChanges();
                MessageBox.Show("Created A Login");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form frm = new Sales();
            frm.Show();
        }
    }
}
