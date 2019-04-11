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
    public partial class CurrentOrder : Form
    {
        int orderId;
        private Order myCurrentOrder;
        public CurrentOrder(int orderId)
        {
            this.orderId = orderId;
            InitializeComponent();
            getOrder();
        }

        public Order getOrder()
        {
            using (ETicketServiceClient.OrderServiceClient orderClient = new ETicketServiceClient.OrderServiceClient())
            {
                using (ETicketServiceClient.SeatServiceClient seatClient = new ETicketServiceClient.SeatServiceClient())
                {
                    orderClient.ClientCredentials.UserName.UserName = "ETicket";
                    orderClient.ClientCredentials.UserName.Password = "ETicketPass";
                    seatClient.ClientCredentials.UserName.UserName = "ETicket";
                    seatClient.ClientCredentials.UserName.Password = "ETicketPass";
                    myCurrentOrder = orderClient.GetOrder(orderId);

                    customerLb.Text = myCurrentOrder.CustomerId;
                    dateLb.Text = myCurrentOrder.Date.ToString().Substring(0, 10);
                    eventLb.Text = myCurrentOrder.EventId.ToString();
                    quantityLb.Text = myCurrentOrder.Quantity.ToString();
                    totalpriceLb.Text = myCurrentOrder.TotalPrice.ToString("0.00##");
                    List <Ticket> tickets = new List<Ticket>(orderClient.GetOrderTickets(orderId).Cast<Ticket>());
                    List<Seat> saets = new List<Seat>();
                    List<TicketAndSeat> ticketAndSeatsList = new List<TicketAndSeat>();

                    foreach (var ticket in tickets)
                    {
                        Seat currentSeat = seatClient.GetSeat(ticket.SeatId);
                        TicketAndSeat currentTicketAndSeat = new TicketAndSeat();
                        currentTicketAndSeat.TicketId = ticket.TicketId;
                        currentTicketAndSeat.SeatNumber = currentSeat.SeatNumber;
                        ticketAndSeatsList.Add(currentTicketAndSeat);
                    }

                    var data = new BindingList<TicketAndSeat>(ticketAndSeatsList);
                    if (data.Count > 0)
                    {
                        ticketsAndSeats.DataSource = data;
                        ticketsAndSeats.ReadOnly = true;
                        ticketsAndSeats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        ticketsAndSeats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ticketsAndSeats.ClearSelection();
                        ticketsAndSeats.MultiSelect = false;
                    }
                    else
                    {
                        MessageBox.Show("No tickets found!");
                    }


                    return myCurrentOrder;
                }
            }
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                using (ETicketServiceClient.OrderServiceClient orderClient = new ETicketServiceClient.OrderServiceClient())
                {

                    orderClient.ClientCredentials.UserName.UserName = "ETicket";
                    orderClient.ClientCredentials.UserName.Password = "ETicketPass";

                    try
                    {
                        orderClient.Cancel(myCurrentOrder);
                        MessageBox.Show("Order canceled");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Order not canceled, try again");
                        throw;
                    }


                }


            }
        }
    }
}
