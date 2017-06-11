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
    public partial class PriceRange : Form
    {
        
        DataClasses1DataContext context;

        public PriceRange()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();    
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int minAmnt = 0;
            int maxAmnt = 0;
            minAmnt= int.Parse(min.Text);
            maxAmnt = int.Parse(max.Text);
           
    var priceRanges = context.ORDERs.Where(c => c.USER_ID == Login.Id 
                 && c.Total_ORDERS >= minAmnt && c.Total_ORDERS <= maxAmnt)
                .Select(c => new
                {
                    Date = c.Date,
                    ITEM = c.ITEM.Description,
                    Total = c.Total_ORDER,
                    Qty = c.Qty
                }).ToList();
            pricerange.DataSource = priceRanges;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase prod = new Purchase();
            prod.Show();
        }

        
    }
}
