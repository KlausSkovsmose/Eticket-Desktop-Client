namespace ETicketDesktopClient
{
    partial class CurrentEvent
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
            this.dateTb = new System.Windows.Forms.DateTimePicker();
            this.startTimeTb = new System.Windows.Forms.DateTimePicker();
            this.gateOpenTb = new System.Windows.Forms.DateTimePicker();
            this.ticketPriceTb = new System.Windows.Forms.TextBox();
            this.availableTicketTb = new System.Windows.Forms.TextBox();
            this.gateTb = new System.Windows.Forms.TextBox();
            this.descriptionTb = new System.Windows.Forms.RichTextBox();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.createBt = new System.Windows.Forms.Button();
            this.ticketPriceLb = new System.Windows.Forms.Label();
            this.availableTicketsLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.startTimeLb = new System.Windows.Forms.Label();
            this.gateOpensLb = new System.Windows.Forms.Label();
            this.gateLb = new System.Windows.Forms.Label();
            this.descriptionLb = new System.Windows.Forms.Label();
            this.titleLb = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTb
            // 
            this.dateTb.AccessibleName = "Date";
            this.dateTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.dateTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTb.Location = new System.Drawing.Point(199, 254);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(517, 20);
            this.dateTb.TabIndex = 36;
            // 
            // startTimeTb
            // 
            this.startTimeTb.AccessibleName = "Start time";
            this.startTimeTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.startTimeTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeTb.Location = new System.Drawing.Point(199, 228);
            this.startTimeTb.Name = "startTimeTb";
            this.startTimeTb.Size = new System.Drawing.Size(517, 20);
            this.startTimeTb.TabIndex = 35;
            // 
            // gateOpenTb
            // 
            this.gateOpenTb.AccessibleName = "Gate opens";
            this.gateOpenTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.gateOpenTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gateOpenTb.Location = new System.Drawing.Point(199, 202);
            this.gateOpenTb.Name = "gateOpenTb";
            this.gateOpenTb.Size = new System.Drawing.Size(517, 20);
            this.gateOpenTb.TabIndex = 34;
            // 
            // ticketPriceTb
            // 
            this.ticketPriceTb.AccessibleName = "Ticket price";
            this.ticketPriceTb.Location = new System.Drawing.Point(199, 306);
            this.ticketPriceTb.Name = "ticketPriceTb";
            this.ticketPriceTb.Size = new System.Drawing.Size(517, 20);
            this.ticketPriceTb.TabIndex = 33;
            this.ticketPriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ticketPriceTb_KeyPress);
            // 
            // availableTicketTb
            // 
            this.availableTicketTb.AccessibleName = "Available tickets";
            this.availableTicketTb.Location = new System.Drawing.Point(199, 280);
            this.availableTicketTb.Name = "availableTicketTb";
            this.availableTicketTb.Size = new System.Drawing.Size(517, 20);
            this.availableTicketTb.TabIndex = 32;
            this.availableTicketTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.availableTicketTb_KeyPress);
            // 
            // gateTb
            // 
            this.gateTb.AccessibleName = "Gate";
            this.gateTb.Location = new System.Drawing.Point(199, 169);
            this.gateTb.Name = "gateTb";
            this.gateTb.Size = new System.Drawing.Size(517, 20);
            this.gateTb.TabIndex = 31;
            // 
            // descriptionTb
            // 
            this.descriptionTb.AccessibleName = "Description";
            this.descriptionTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTb.Location = new System.Drawing.Point(199, 56);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(517, 96);
            this.descriptionTb.TabIndex = 30;
            this.descriptionTb.Text = "";
            // 
            // titleTb
            // 
            this.titleTb.AccessibleName = "Title";
            this.titleTb.Location = new System.Drawing.Point(199, 28);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(517, 20);
            this.titleTb.TabIndex = 29;
            // 
            // createBt
            // 
            this.createBt.Location = new System.Drawing.Point(362, 366);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(142, 56);
            this.createBt.TabIndex = 28;
            this.createBt.Text = "Update";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // ticketPriceLb
            // 
            this.ticketPriceLb.AutoSize = true;
            this.ticketPriceLb.Location = new System.Drawing.Point(88, 313);
            this.ticketPriceLb.Name = "ticketPriceLb";
            this.ticketPriceLb.Size = new System.Drawing.Size(67, 13);
            this.ticketPriceLb.TabIndex = 27;
            this.ticketPriceLb.Text = "Ticket Price:";
            // 
            // availableTicketsLb
            // 
            this.availableTicketsLb.AutoSize = true;
            this.availableTicketsLb.Location = new System.Drawing.Point(88, 283);
            this.availableTicketsLb.Name = "availableTicketsLb";
            this.availableTicketsLb.Size = new System.Drawing.Size(91, 13);
            this.availableTicketsLb.TabIndex = 26;
            this.availableTicketsLb.Text = "Available Tickets:";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(88, 257);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(33, 13);
            this.dateLb.TabIndex = 25;
            this.dateLb.Text = "Date:";
            // 
            // startTimeLb
            // 
            this.startTimeLb.AutoSize = true;
            this.startTimeLb.Location = new System.Drawing.Point(88, 231);
            this.startTimeLb.Name = "startTimeLb";
            this.startTimeLb.Size = new System.Drawing.Size(55, 13);
            this.startTimeLb.TabIndex = 24;
            this.startTimeLb.Text = "StartTime:";
            // 
            // gateOpensLb
            // 
            this.gateOpensLb.AutoSize = true;
            this.gateOpensLb.Location = new System.Drawing.Point(88, 202);
            this.gateOpensLb.Name = "gateOpensLb";
            this.gateOpensLb.Size = new System.Drawing.Size(64, 13);
            this.gateOpensLb.TabIndex = 23;
            this.gateOpensLb.Text = "GateOpens:";
            // 
            // gateLb
            // 
            this.gateLb.AutoSize = true;
            this.gateLb.Location = new System.Drawing.Point(88, 172);
            this.gateLb.Name = "gateLb";
            this.gateLb.Size = new System.Drawing.Size(33, 13);
            this.gateLb.TabIndex = 22;
            this.gateLb.Text = "Gate:";
            // 
            // descriptionLb
            // 
            this.descriptionLb.AutoSize = true;
            this.descriptionLb.Location = new System.Drawing.Point(87, 56);
            this.descriptionLb.Name = "descriptionLb";
            this.descriptionLb.Size = new System.Drawing.Size(63, 13);
            this.descriptionLb.TabIndex = 21;
            this.descriptionLb.Text = "Description:";
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Location = new System.Drawing.Point(84, 28);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(30, 13);
            this.titleLb.TabIndex = 20;
            this.titleLb.Text = "Title:";
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(510, 366);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(142, 56);
            this.deleteBt.TabIndex = 37;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click_1);
            // 
            // CurrentEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.dateTb);
            this.Controls.Add(this.startTimeTb);
            this.Controls.Add(this.gateOpenTb);
            this.Controls.Add(this.ticketPriceTb);
            this.Controls.Add(this.availableTicketTb);
            this.Controls.Add(this.gateTb);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.ticketPriceLb);
            this.Controls.Add(this.availableTicketsLb);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.startTimeLb);
            this.Controls.Add(this.gateOpensLb);
            this.Controls.Add(this.gateLb);
            this.Controls.Add(this.descriptionLb);
            this.Controls.Add(this.titleLb);
            this.Name = "CurrentEvent";
            this.Text = "ETicket - Manage Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTb;
        private System.Windows.Forms.DateTimePicker startTimeTb;
        private System.Windows.Forms.DateTimePicker gateOpenTb;
        private System.Windows.Forms.TextBox ticketPriceTb;
        private System.Windows.Forms.TextBox availableTicketTb;
        private System.Windows.Forms.TextBox gateTb;
        private System.Windows.Forms.RichTextBox descriptionTb;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Label ticketPriceLb;
        private System.Windows.Forms.Label availableTicketsLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label startTimeLb;
        private System.Windows.Forms.Label gateOpensLb;
        private System.Windows.Forms.Label gateLb;
        private System.Windows.Forms.Label descriptionLb;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Button deleteBt;
    }
}