using ETicketDesktopClient.ETicketServiceClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketDesktopClient
{
    public partial class CurrentEvent : Form
    {
        private int eventId;
        public CurrentEvent(int id)
        {
            this.eventId = id;
            InitializeComponent();
            SetCustomDateFields();
            SetEventData(id);

        }

        private void SetEventData(int id)
        {
            var theEvent = getEventData(id);
            titleTb.Text = theEvent.Title;
            descriptionTb.Text = theEvent.Description;
            gateTb.Text = theEvent.Gate;
            gateOpenTb.Text = theEvent.GateOpens.ToString("dd/MM/yyyy HH:mm");
            startTimeTb.Text = theEvent.StartTime.ToString("dd/MM/yyyy HH:mm");
            dateTb.Text = theEvent.Date.ToString("dd/MM/yyyy");
            availableTicketTb.Text = theEvent.AvailableTickets.ToString();
            ticketPriceTb.Text = theEvent.TicketPrice.ToString("0.00##");
        }

        public Event getEventData(int id)
        {
            Event myEvent = new Event();
            using (ETicketServiceClient.EventServiceClient eventClient = new ETicketServiceClient.EventServiceClient())
            {
                eventClient.ClientCredentials.UserName.UserName = "ETicket";
                eventClient.ClientCredentials.UserName.Password = "ETicketPass";
                myEvent = eventClient.GetEvent(id);
                return myEvent;
            }
        }

   

     
        private void SetCustomDateFields()
        {
            gateOpenTb.Format = DateTimePickerFormat.Custom;
            gateOpenTb.CustomFormat = "MM/dd/yyyy HH:mm";

            startTimeTb.Format = DateTimePickerFormat.Custom;
            startTimeTb.CustomFormat = "MM/dd/yyyy HH:mm";

            dateTb.Format = DateTimePickerFormat.Custom;
            dateTb.CustomFormat = "MM/dd/yyyy";
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

    

   
        private void createBt_Click(object sender, EventArgs e)
        {
            using (ETicketServiceClient.EventServiceClient eventClient = new ETicketServiceClient.EventServiceClient())
            {
                Event newEvent = new Event();
                eventClient.ClientCredentials.UserName.UserName = "ETicket";
                eventClient.ClientCredentials.UserName.Password = "ETicketPass";


                if (checkFields())
                {
                    newEvent.EventId = eventId;
                    newEvent.Title = titleTb.Text;
                    newEvent.Description = descriptionTb.Text;
                    newEvent.Gate = gateTb.Text;
                    newEvent.GateOpens = DateTime.ParseExact(gateOpenTb.Text, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                    newEvent.StartTime = DateTime.ParseExact(startTimeTb.Text, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                    newEvent.Date = DateTime.ParseExact(dateTb.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    newEvent.AvailableTickets = Convert.ToInt32(availableTicketTb.Text);
                    newEvent.TicketPrice = Convert.ToDecimal(ticketPriceTb.Text);


                    try
                    {
                        eventClient.UpdateEvent(newEvent);
                        MessageBox.Show("Event updated");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR: Event not created, try again");
                        throw;
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

        private void deleteBt_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                "Confirm Delete!",
                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                using (ETicketServiceClient.EventServiceClient eventClient = new ETicketServiceClient.EventServiceClient())
                {

                    eventClient.ClientCredentials.UserName.UserName = "ETicket";
                    eventClient.ClientCredentials.UserName.Password = "ETicketPass";

                    try
                    {
                        eventClient.DeleteEvent(eventId);
                        MessageBox.Show("Event deleted");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Event not deleted, try again");
                        throw;
                    }
                }
            }
        }
    }
}
