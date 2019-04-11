namespace ETicketDesktopClient
{
    partial class Events
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
            this.eventsGrid = new System.Windows.Forms.DataGridView();
            this.backBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsGrid
            // 
            this.eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsGrid.Location = new System.Drawing.Point(1, 35);
            this.eventsGrid.Name = "eventsGrid";
            this.eventsGrid.Size = new System.Drawing.Size(799, 416);
            this.eventsGrid.TabIndex = 0;
            this.eventsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsGrid_CellContentClick);
            // 
            // backBt
            // 
            this.backBt.ForeColor = System.Drawing.Color.Red;
            this.backBt.Location = new System.Drawing.Point(3, 3);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(95, 29);
            this.backBt.TabIndex = 1;
            this.backBt.Text = "⬅️ Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // createBt
            // 
            this.createBt.ForeColor = System.Drawing.Color.Red;
            this.createBt.Location = new System.Drawing.Point(113, 3);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(95, 29);
            this.createBt.TabIndex = 2;
            this.createBt.Text = " ➕ Create";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.eventsGrid);
            this.Name = "Events";
            this.Text = "ETicket - Events";
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventsGrid;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button createBt;
    }
}