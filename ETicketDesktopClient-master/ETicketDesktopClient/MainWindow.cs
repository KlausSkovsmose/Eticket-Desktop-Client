using Microsoft.AspNet.Identity;
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
    public partial class MainWindow : Form
    {
        Thread thread;
        string username;
        public MainWindow()
        {
            InitializeComponent();
        }

      
        //public async Task<bool> VerifyUserNamePassword(string userName, string passWord)
        //{
        //    var usermanager = new UserManager<>;
        //    return await usermanager.FindAsync(userName, passWord) != null;
        //}

        public bool Login()
        {
            using (ETicketServiceClient.AdminServiceClient adminClient = new ETicketServiceClient.AdminServiceClient())
            {

                adminClient.ClientCredentials.UserName.UserName = "ETicket";
                adminClient.ClientCredentials.UserName.Password = "ETicketPass";

                string Username = usernameTb.Text;
                string Password = passwordTb.Text;
                if (adminClient.GetAdminInfo(Username) != null)
                {
                    ETicketServiceClient.AdminInfo adminInfo = adminClient.GetAdminInfo(Username);
                    string passwordhashed = adminInfo.Password;
                    username = adminInfo.Username;

                    PasswordHasher hasher = new PasswordHasher();
                    if (hasher.VerifyHashedPassword(passwordhashed, Password) != PasswordVerificationResult.Failed)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    //return hasher.HashPassword("User1234!");
                }
                else
                {
                    return false;
                }
            }
        }


        private void loginBt_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                MessageBox.Show("Welcome "+username);
                this.Close();
                thread = new Thread(OpenNewWindow);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void OpenNewWindow(object obj)
        {
            Application.Run(new AdminPanel());
        }
    }
}
