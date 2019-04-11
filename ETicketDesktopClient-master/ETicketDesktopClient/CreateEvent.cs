using ETicketDesktopClient.ETicketServiceClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketDesktopClient
{
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
            CustomDateFields();
        }

        private void CustomDateFields()
        {
            gateOpenTb.Format = DateTimePickerFormat.Custom;
            gateOpenTb.Text = DateTime.Now.ToString();
            gateOpenTb.MinDate = DateTime.Now;
            gateOpenTb.CustomFormat = "MM/dd/yyyy HH:mm";

            startTimeTb.Format = DateTimePickerFormat.Custom;
            startTimeTb.Text = DateTime.Now.ToString();
            startTimeTb.MinDate = DateTime.Now;
            startTimeTb.CustomFormat = "MM/dd/yyyy HH:mm";

            dateTb.Format = DateTimePickerFormat.Custom;
            dateTb.Text = DateTime.Now.Date.ToString();
            dateTb.MinDate = DateTime.Now;
            dateTb.CustomFormat = "MM/dd/yyyy";
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            using (ETicketServiceClient.EventServiceClient eventClient = new ETicketServiceClient.EventServiceClient())
            {
                Event newEvent = new Event();
                eventClient.ClientCredentials.UserName.UserName = "ETicket";
                eventClient.ClientCredentials.UserName.Password = "ETicketPass";


                if (checkFields())
                {
                    newEvent.Title = titleTb.Text;
                    newEvent.Description = descriptionTb.Text;
                    newEvent.Gate = gateTb.Text;
                    newEvent.GateOpens = DateTime.Parse(gateOpenTb.Text);
                    newEvent.StartTime = DateTime.Parse(startTimeTb.Text);
                    newEvent.Date = DateTime.Parse(dateTb.Text);
                    newEvent.AvailableTickets = Convert.ToInt32(availableTicketTb.Text);
                    newEvent.TicketPrice = Convert.ToDecimal(ticketPriceTb.Text);

                    if (eventClient.CreateEvent(newEvent) > 0)
                    {
                        MessageBox.Show("Event Created");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Event not created, try again");
                    }
                }

            }
        }

        private void ticketPriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void availableTicketTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool checkFields()
        {
            bool status = true;
            foreach (Control c in this.Controls)
            {
                if (c is RichTextBox)
                {
                    RichTextBox textBox = c as RichTextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show(c.AccessibleName + " is empty");
                        status = false;
                    }
                }
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show(c.AccessibleName + " is empty");
                        status = false;
                    }
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker textBox = c as DateTimePicker;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show(c.AccessibleName + " is empty");
                        status = false;
                    }
                }
            }
            return status;
        }


    }
}
