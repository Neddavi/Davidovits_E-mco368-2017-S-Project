namespace SaleTracker
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.itemLable = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.dataGridView_Item = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTDataSet = new SaleTracker.PROJECTDataSet();
            this.iTEMTableAdapter = new SaleTracker.PROJECTDataSetTableAdapters.ITEMTableAdapter();
            this.LogoutmenuStrip = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).BeginInit();
            this.LogoutmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemLable
            // 
            this.itemLable.AutoSize = true;
            this.itemLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLable.Location = new System.Drawing.Point(133, 26);
            this.itemLable.Name = "itemLable";
            this.itemLable.Size = new System.Drawing.Size(158, 20);
            this.itemLable.TabIndex = 0;
            this.itemLable.Text = "ALL ITEMS SOLD:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(162, 228);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(129, 35);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // dataGridView_Item
            // 
            this.dataGridView_Item.AllowUserToAddRows = false;
            this.dataGridView_Item.AllowUserToDeleteRows = false;
            this.dataGridView_Item.AutoGenerateColumns = false;
            this.dataGridView_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView_Item.DataSource = this.iTEMBindingSource;
            this.dataGridView_Item.Location = new System.Drawing.Point(23, 49);
            this.dataGridView_Item.Name = "dataGridView_Item";
            this.dataGridView_Item.ReadOnly = true;
            this.dataGridView_Item.Size = new System.Drawing.Size(424, 173);
            this.dataGridView_Item.TabIndex = 7;
            this.dataGridView_Item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Item_CellContentClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMBindingSource
            // 
            this.iTEMBindingSource.DataMember = "ITEM";
            this.iTEMBindingSource.DataSource = this.pROJECTDataSet;
            // 
            // pROJECTDataSet
            // 
            this.pROJECTDataSet.DataSetName = "PROJECTDataSet";
            this.pROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMTableAdapter
            // 
            this.iTEMTableAdapter.ClearBeforeFill = true;
            // 
            // LogoutmenuStrip
            // 
            this.LogoutmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.myAccountToolStripMenuItem});
            this.LogoutmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.LogoutmenuStrip.Name = "LogoutmenuStrip";
            this.LogoutmenuStrip.Size = new System.Drawing.Size(523, 24);
            this.LogoutmenuStrip.TabIndex = 8;
            this.LogoutmenuStrip.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPurchaseToolStripMenuItem,
            this.dataRangeToolStripMenuItem,
            this.priceRangeToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myAccountToolStripMenuItem.Text = "My Account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // viewPurchaseToolStripMenuItem
            // 
            this.viewPurchaseToolStripMenuItem.Name = "viewPurchaseToolStripMenuItem";
            this.viewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewPurchaseToolStripMenuItem.Text = "Shopping Cart";
            this.viewPurchaseToolStripMenuItem.Click += new System.EventHandler(this.viewPurchaseToolStripMenuItem_Click);
            // 
            // dataRangeToolStripMenuItem
            // 
            this.dataRangeToolStripMenuItem.Name = "dataRangeToolStripMenuItem";
            this.dataRangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataRangeToolStripMenuItem.Text = "Data Range";
            this.dataRangeToolStripMenuItem.Click += new System.EventHandler(this.dataRangeToolStripMenuItem_Click);
            // 
            // priceRangeToolStripMenuItem
            // 
            this.priceRangeToolStripMenuItem.Name = "priceRangeToolStripMenuItem";
            this.priceRangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.priceRangeToolStripMenuItem.Text = "Price Range";
            this.priceRangeToolStripMenuItem.Click += new System.EventHandler(this.priceRangeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "QTY";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(476, 111);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(35, 20);
            this.textBox.TabIndex = 10;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 294);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Item);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.itemLable);
            this.Controls.Add(this.LogoutmenuStrip);
            this.MainMenuStrip = this.LogoutmenuStrip;
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTDataSet)).EndInit();
            this.LogoutmenuStrip.ResumeLayout(false);
            this.LogoutmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemLable;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridView dataGridView_Item;
        private PROJECTDataSet pROJECTDataSet;
        private System.Windows.Forms.BindingSource iTEMBindingSource;
        private PROJECTDataSetTableAdapters.ITEMTableAdapter iTEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip LogoutmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
    }
}