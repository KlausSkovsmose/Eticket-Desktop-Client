namespace ETicketDesktopClient
{
    partial class CreateEvent
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
            this.titleLb = new System.Windows.Forms.Label();
            this.descriptionLb = new System.Windows.Forms.Label();
            this.gateLb = new System.Windows.Forms.Label();
            this.gateOpensLb = new System.Windows.Forms.Label();
            this.startTimeLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.availableTicketsLb = new System.Windows.Forms.Label();
            this.ticketPriceLb = new System.Windows.Forms.Label();
            this.createBt = new System.Windows.Forms.Button();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.descriptionTb = new System.Windows.Forms.RichTextBox();
            this.gateTb = new System.Windows.Forms.TextBox();
            this.availableTicketTb = new System.Windows.Forms.TextBox();
            this.ticketPriceTb = new System.Windows.Forms.TextBox();
            this.gateOpenTb = new System.Windows.Forms.DateTimePicker();
            this.startTimeTb = new System.Windows.Forms.DateTimePicker();
            this.dateTb = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Location = new System.Drawing.Point(77, 44);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(30, 13);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "Title:";
            // 
            // descriptionLb
            // 
            this.descriptionLb.AutoSize = true;
            this.descriptionLb.Location = new System.Drawing.Point(80, 72);
            this.descriptionLb.Name = "descriptionLb";
            this.descriptionLb.Size = new System.Drawing.Size(63, 13);
            this.descriptionLb.TabIndex = 1;
            this.descriptionLb.Text = "Description:";
            // 
            // gateLb
            // 
            this.gateLb.AutoSize = true;
            this.gateLb.Location = new System.Drawing.Point(81, 188);
            this.gateLb.Name = "gateLb";
            this.gateLb.Size = new System.Drawing.Size(33, 13);
            this.gateLb.TabIndex = 2;
            this.gateLb.Text = "Gate:";
            // 
            // gateOpensLb
            // 
            this.gateOpensLb.AutoSize = true;
            this.gateOpensLb.Location = new System.Drawing.Point(81, 218);
            this.gateOpensLb.Name = "gateOpensLb";
            this.gateOpensLb.Size = new System.Drawing.Size(64, 13);
            this.gateOpensLb.TabIndex = 3;
            this.gateOpensLb.Text = "GateOpens:";
            // 
            // startTimeLb
            // 
            this.startTimeLb.AutoSize = true;
            this.startTimeLb.Location = new System.Drawing.Point(81, 247);
            this.startTimeLb.Name = "startTimeLb";
            this.startTimeLb.Size = new System.Drawing.Size(55, 13);
            this.startTimeLb.TabIndex = 4;
            this.startTimeLb.Text = "StartTime:";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(81, 273);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(33, 13);
            this.dateLb.TabIndex = 5;
            this.dateLb.Text = "Date:";
            // 
            // availableTicketsLb
            // 
            this.availableTicketsLb.AutoSize = true;
            this.availableTicketsLb.Location = new System.Drawing.Point(81, 299);
            this.availableTicketsLb.Name = "availableTicketsLb";
            this.availableTicketsLb.Size = new System.Drawing.Size(91, 13);
            this.availableTicketsLb.TabIndex = 6;
            this.availableTicketsLb.Text = "Available Tickets:";
            // 
            // ticketPriceLb
            // 
            this.ticketPriceLb.AutoSize = true;
            this.ticketPriceLb.Location = new System.Drawing.Point(81, 329);
            this.ticketPriceLb.Name = "ticketPriceLb";
            this.ticketPriceLb.Size = new System.Drawing.Size(67, 13);
            this.ticketPriceLb.TabIndex = 7;
            this.ticketPriceLb.Text = "Ticket Price:";
            // 
            // createBt
            // 
            this.createBt.Location = new System.Drawing.Point(355, 382);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(142, 56);
            this.createBt.TabIndex = 8;
            this.createBt.Text = "Create";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // titleTb
            // 
            this.titleTb.AccessibleName = "Title";
            this.titleTb.Location = new System.Drawing.Point(192, 44);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(517, 20);
            this.titleTb.TabIndex = 9;
            // 
            // descriptionTb
            // 
            this.descriptionTb.AccessibleName = "Description";
            this.descriptionTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTb.Location = new System.Drawing.Point(192, 72);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(517, 96);
            this.descriptionTb.TabIndex = 10;
            this.descriptionTb.Text = "";
            // 
            // gateTb
            // 
            this.gateTb.AccessibleName = "Gate";
            this.gateTb.Location = new System.Drawing.Point(192, 185);
            this.gateTb.Name = "gateTb";
            this.gateTb.Size = new System.Drawing.Size(517, 20);
            this.gateTb.TabIndex = 11;
            // 
            // availableTicketTb
            // 
            this.availableTicketTb.AccessibleName = "Available tickets";
            this.availableTicketTb.Location = new System.Drawing.Point(192, 296);
            this.availableTicketTb.Name = "availableTicketTb";
            this.availableTicketTb.Size = new System.Drawing.Size(517, 20);
            this.availableTicketTb.TabIndex = 15;
            this.availableTicketTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.availableTicketTb_KeyPress);
            // 
            // ticketPriceTb
            // 
            this.ticketPriceTb.AccessibleName = "Ticket price";
            this.ticketPriceTb.Location = new System.Drawing.Point(192, 322);
            this.ticketPriceTb.Name = "ticketPriceTb";
            this.ticketPriceTb.Size = new System.Drawing.Size(517, 20);
            this.ticketPriceTb.TabIndex = 16;
            this.ticketPriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ticketPriceTb_KeyPress);
            // 
            // gateOpenTb
            // 
            this.gateOpenTb.AccessibleName = "Gate opens";
            this.gateOpenTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.gateOpenTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gateOpenTb.Location = new System.Drawing.Point(192, 218);
            this.gateOpenTb.Name = "gateOpenTb";
            this.gateOpenTb.Size = new System.Drawing.Size(517, 20);
            this.gateOpenTb.TabIndex = 17;
            // 
            // startTimeTb
            // 
            this.startTimeTb.AccessibleName = "Start time";
            this.startTimeTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.startTimeTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeTb.Location = new System.Drawing.Point(192, 244);
            this.startTimeTb.Name = "startTimeTb";
            this.startTimeTb.Size = new System.Drawing.Size(517, 20);
            this.startTimeTb.TabIndex = 18;
            // 
            // dateTb
            // 
            this.dateTb.AccessibleName = "Date";
            this.dateTb.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.dateTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTb.Location = new System.Drawing.Point(192, 270);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(517, 20);
            this.dateTb.TabIndex = 19;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "CreateEvent";
            this.Text = "ETicket - Create Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label descriptionLb;
        private System.Windows.Forms.Label gateLb;
        private System.Windows.Forms.Label gateOpensLb;
        private System.Windows.Forms.Label startTimeLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label availableTicketsLb;
        private System.Windows.Forms.Label ticketPriceLb;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.RichTextBox descriptionTb;
        private System.Windows.Forms.TextBox gateTb;
        private System.Windows.Forms.TextBox availableTicketTb;
        private System.Windows.Forms.TextBox ticketPriceTb;
        private System.Windows.Forms.DateTimePicker gateOpenTb;
        private System.Windows.Forms.DateTimePicker startTimeTb;
        private System.Windows.Forms.DateTimePicker dateTb;
    }
}