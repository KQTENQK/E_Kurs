using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kurs
{
    public partial class SighUpAdministratorForm : Form
    {
        public SighUpAdministratorForm()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string userpassword = inputPassword.Text;
            string userType = "administrator";
            if (username != null && userpassword != null)
            {
                using (var context = new ClientContext())
                {
                    var existingClients = context.Clients.Where(existingClient => existingClient.Username == username);
                    if (existingClients.Count() > 0)
                    {
                        new UserAlreadyExistForm().ShowDialog();
                    }
                    else
                    {
                        var client = new DefaultClient()
                        {
                            Username = username,
                            Password = userpassword,
                            UserType = userType
                        };

                        context.Clients.Add(client);
                        context.SaveChanges(); 
                        
                        new SuccessfulSignUp().ShowDialog();

                        Close();
                    }
                }
            }
            else
            {
                new InvalidSignUpData().ShowDialog();
            }
        }
    }
}
