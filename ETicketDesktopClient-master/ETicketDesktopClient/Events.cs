using ETicketDesktopClient.ETicketServiceClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketDesktopClient
{
    public partial class Events : Form
    {
        Thread thread;
        private List<Event> events;
        public Events()
        {
            InitializeComponent();
            GetGridData();
        }

        public List<Event> getAllEvents()
        {
            using (ETicketServiceClient.EventServiceClient eventClient = new ETicketServiceClient.EventServiceClient())

            {
                eventClient.ClientCredentials.UserName.UserName = "ETicket";
                eventClient.ClientCredentials.UserName.Password = "ETicketPass";
                events = new List<Event>(eventClient.GetAllEvents());
                return events;
            }
        }

        public void GetGridData()
        {
            var events = new BindingList<Event>(getAllEvents());
            if (events.Count > 0)
            {
                eventsGrid.DataSource = events;
                eventsGrid.Columns["TicketPrice"].DefaultCellStyle.Format = "0.00##";
                eventsGrid.ReadOnly = true;
                eventsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                eventsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                eventsGrid.ClearSelection();
                eventsGrid.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("No events found!");
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAdminPanelWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAdminPanelWindow(object obj)
        {
            Application.Run(new AdminPanel());
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            CreateEvent ce = new CreateEvent();
            ce.ShowDialog();
            GetGridData();
        }

        private void eventsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eventId = eventsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (!string.IsNullOrEmpty(eventId))
            {
                //MessageBox.Show(eventId + ".");
                int id = Convert.ToInt32(eventId);
                CurrentEvent ce = new CurrentEvent(id);
                ce.ShowDialog();
                GetGridData();
            }
        }
    }
}
