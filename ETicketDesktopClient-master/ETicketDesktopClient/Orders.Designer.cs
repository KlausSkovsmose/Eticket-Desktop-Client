namespace ETicketDesktopClient
{
    partial class Orders
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
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBt = new System.Windows.Forms.Button();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.backBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(416, 54);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(290, 20);
            this.usernameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Customer orders by Username";
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(713, 53);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(75, 23);
            this.searchBt.TabIndex = 2;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(21, 82);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new System.Drawing.Size(767, 356);
            this.ordersGrid.TabIndex = 3;
            this.ordersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGrid_CellContentClick);
            // 
            // backBt
            // 
            this.backBt.ForeColor = System.Drawing.Color.Red;
            this.backBt.Location = new System.Drawing.Point(21, 9);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(95, 29);
            this.backBt.TabIndex = 4;
            this.backBt.Text = "⬅️ Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTb);
            this.Name = "Orders";
            this.Text = "ETikcet  - Orders";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Button backBt;
    }
}