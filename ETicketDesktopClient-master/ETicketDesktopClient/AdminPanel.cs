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
    public partial class AdminPanel : Form
    {
        Thread thread;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenOrderWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void eventBt_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenEventWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenOrderWindow(object obj)
        {
            Application.Run(new Orders());
        }

        private void OpenEventWindow(object obj)
        {
            Application.Run(new Events());
        }

       
    }
}
