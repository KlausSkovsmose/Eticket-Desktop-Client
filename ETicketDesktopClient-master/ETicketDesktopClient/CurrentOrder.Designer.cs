namespace ETicketDesktopClient
{
    partial class CurrentOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.eventLb = new System.Windows.Forms.Label();
            this.quantityLb = new System.Windows.Forms.Label();
            this.totalpriceLb = new System.Windows.Forms.Label();
            this.ticketsAndSeats = new System.Windows.Forms.DataGridView();
            this.cancelBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsAndSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tickets on this order";
            // 
            // customerLb
            // 
            this.customerLb.AutoSize = true;
            this.customerLb.Location = new System.Drawing.Point(224, 73);
            this.customerLb.Name = "customerLb";
            this.customerLb.Size = new System.Drawing.Size(0, 13);
            this.customerLb.TabIndex = 6;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(227, 100);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(0, 13);
            this.dateLb.TabIndex = 7;
            // 
            // eventLb
            // 
            this.eventLb.AutoSize = true;
            this.eventLb.Location = new System.Drawing.Point(227, 128);
            this.eventLb.Name = "eventLb";
            this.eventLb.Size = new System.Drawing.Size(0, 13);
            this.eventLb.TabIndex = 8;
            // 
            // quantityLb
            // 
            this.quantityLb.AutoSize = true;
            this.quantityLb.Location = new System.Drawing.Point(230, 160);
            this.quantityLb.Name = "quantityLb";
            this.quantityLb.Size = new System.Drawing.Size(0, 13);
            this.quantityLb.TabIndex = 9;
            // 
            // totalpriceLb
            // 
            this.totalpriceLb.AutoSize = true;
            this.totalpriceLb.Location = new System.Drawing.Point(227, 190);
            this.totalpriceLb.Name = "totalpriceLb";
            this.totalpriceLb.Size = new System.Drawing.Size(0, 13);
            this.totalpriceLb.TabIndex = 10;
            // 
            // ticketsAndSeats
            // 
            this.ticketsAndSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsAndSeats.Location = new System.Drawing.Point(521, 89);
            this.ticketsAndSeats.Name = "ticketsAndSeats";
            this.ticketsAndSeats.Size = new System.Drawing.Size(206, 349);
            this.ticketsAndSeats.TabIndex = 11;
            // 
            // cancelBt
            // 
            this.cancelBt.ForeColor = System.Drawing.Color.Red;
            this.cancelBt.Location = new System.Drawing.Point(122, 371);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(163, 67);
            this.cancelBt.TabIndex = 12;
            this.cancelBt.Text = "❌ Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // CurrentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.ticketsAndSeats);
            this.Controls.Add(this.totalpriceLb);
            this.Controls.Add(this.quantityLb);
            this.Controls.Add(this.eventLb);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.customerLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrentOrder";
            this.Text = "ETicket - Manage Order";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsAndSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label eventLb;
        private System.Windows.Forms.Label quantityLb;
        private System.Windows.Forms.Label totalpriceLb;
        private System.Windows.Forms.DataGridView ticketsAndSeats;
        private System.Windows.Forms.Button cancelBt;
    }
}