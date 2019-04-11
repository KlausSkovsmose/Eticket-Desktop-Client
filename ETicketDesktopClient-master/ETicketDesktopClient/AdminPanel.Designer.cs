namespace ETicketDesktopClient
{
    partial class AdminPanel
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
            this.eventBt = new System.Windows.Forms.Button();
            this.orderBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventBt
            // 
            this.eventBt.Location = new System.Drawing.Point(264, 84);
            this.eventBt.Name = "eventBt";
            this.eventBt.Size = new System.Drawing.Size(283, 112);
            this.eventBt.TabIndex = 0;
            this.eventBt.Text = "Events";
            this.eventBt.UseVisualStyleBackColor = true;
            this.eventBt.Click += new System.EventHandler(this.eventBt_Click);
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(264, 263);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(283, 112);
            this.orderBt.TabIndex = 1;
            this.orderBt.Text = "Orders";
            this.orderBt.UseVisualStyleBackColor = true;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.eventBt);
            this.Name = "AdminPanel";
            this.Text = "ETicket - Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventBt;
        private System.Windows.Forms.Button orderBt;
    }
}