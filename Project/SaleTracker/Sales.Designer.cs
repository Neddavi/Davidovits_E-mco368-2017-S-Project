namespace SaleTracker
{
    partial class Sales
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
            this.Header = new System.Windows.Forms.Label();
            this.Loginbuton = new System.Windows.Forms.Button();
            this.Itembutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(7, 58);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(259, 24);
            this.Header.TabIndex = 0;
            this.Header.Text = "What Do You Want To Do?";
            // 
            // Loginbuton
            // 
            this.Loginbuton.Location = new System.Drawing.Point(12, 111);
            this.Loginbuton.Name = "Loginbuton";
            this.Loginbuton.Size = new System.Drawing.Size(126, 38);
            this.Loginbuton.TabIndex = 1;
            this.Loginbuton.Text = "Login";
            this.Loginbuton.UseVisualStyleBackColor = true;
            this.Loginbuton.Click += new System.EventHandler(this.Loginbuton_Click);
            // 
            // Itembutton
            // 
            this.Itembutton.Location = new System.Drawing.Point(147, 111);
            this.Itembutton.Name = "Itembutton";
            this.Itembutton.Size = new System.Drawing.Size(125, 40);
            this.Itembutton.TabIndex = 2;
            this.Itembutton.Text = "Create Login";
            this.Itembutton.UseVisualStyleBackColor = true;
            this.Itembutton.Click += new System.EventHandler(this.Itembutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(202, 223);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(64, 25);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Itembutton);
            this.Controls.Add(this.Loginbuton);
            this.Controls.Add(this.Header);
            this.Name = "Sales";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button Loginbuton;
        private System.Windows.Forms.Button Itembutton;
        private System.Windows.Forms.Button ExitButton;
    }
}