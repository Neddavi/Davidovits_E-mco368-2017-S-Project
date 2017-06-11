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
    public partial class Purchase : Form
    {
        public String ItemId { get; private set; }
        DataClasses1DataContext context;
        

        public Purchase()
        {
            InitializeComponent();
            context = new DataClasses1DataContext();

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
            // DateTime date = new DateTime();
            int qty;
            
            //making sure the user enters an integer
            if (int.TryParse(textBox.Text, out qty))
            {
                if (qty > 0)
                {
                    if (qty <= context.ITEMs.Select(b => b.QTY_ITEM).First())
                    {
                        //check balance-if able to buy it, then change balance amount
                        if (context.USERs.Where(c => Convert.ToInt16(c.User_ID)== Login.Id)
                            .Select(c => c.Balance).First() +
                          (context.ITEMs.Where(b => b.Item_ID.Equals(ItemId))
                          .Select(b => b.Price).First() * qty) <= Payment.Credit)
                        {

                            //now need to subtract qty
                            ITEM item = context.ITEMs.Single(b => b.Item_ID == ItemId);
                          


                            //increase the balance
                            USER user = context.USERs.Single(c => Convert.ToInt16(c.User_ID) == Login.Id);
                            user.Balance += context.ITEMs.Where(b => b.Item_ID == ItemId)
                                .Select(b => b.Price).First() * qty;

                            //insert into the Order_Line table    
                           ORDER order = new ORDER
                            {
                                ITEM_ID = ItemId,
                                User_ID =Convert.ToString( Login.Id),
                                Total_Cost = context.ITEMs.Where(b => b.Item_ID == ItemId)
                                                          .Select(b => b.Price).First() * qty,
                                ORDER_DATE = date.Value,
                                QTY=qty

                            };
                            context.ORDERs.InsertOnSubmit(order);
                            //submit ALL the changes...
                            context.SubmitChanges();
                            MessageBox.Show("Item is being shipped!");
                        }//end if
                        else
                        {
                            MessageBox.Show("You have gone over your Balance");
                        }
                    }//end if
                    else
                    {
                        if (context.ITEMs.Select(b => b.QTY_ITEM).First() == 0) MessageBox.Show("Out of stock\nPick another book");
                        else MessageBox.Show("Not enough in stock, reenter quantity");
                    }
                }//end if
                else
                {
                    MessageBox.Show("Enter quantity amount");
                }
            }//end if

        }

        private void dataGridView_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ItemId = context.ITEMs.Where(c => c.Description
               .Equals(dataGridView_Item.Rows[e.RowIndex].Cells["ItemNameDataGridViewTextBoxColumn"].Value))
               .Select(c => c.Item_ID)
               .First();

            dataGridView_Item.Text = dataGridView_Item.Rows[e.RowIndex].Cells["ItemNameDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJECTDataSet.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter.Fill(this.pROJECTDataSet.ITEM);

        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment accnt = new Payment();
            accnt.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting Store, have a nice day!");
            Application.Exit();
        }

        private void viewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCart purchase = new ShoppingCart();
            purchase.Show();
        }

        private void dataRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataRange date = new DataRange();
            date.Show();
        
           }

        private void priceRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceRange priceRange = new PriceRange();
            priceRange.Show();
        }
    }
}
