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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;

            using (var context = new ClientContext())
            {
                var clients = context.Clients.Where(client => client.Username == username && client.Password == password);
                if (clients.Count() > 0)
                {
                    var client = clients.FirstOrDefault();
                    switch (client.UserType)
                    {
                        case "user":
                            User user = new User(client.Id, client.Username, client.Password, client.UserType);
                            new UserPanel(user).Show();
                            Hide();
                            break;
                        case "administrator":
                            Administrator administrator = new Administrator(client.Id, client.Username, client.Password, client.UserType);
                            new AdministratorPanel(administrator).Show();
                            Hide();
                            break;
                        case "moderator":
                            Moderator moderator = new Moderator(client.Id, client.Username, client.Password, client.UserType);
                            new ModeratorPanel(moderator).Show();
                            Hide();
                            break;
                        default:
                            new UserDoesntExistError().ShowDialog();
                            break;
                    }
                }
                else
                {
                    new UserDoesntExistError().ShowDialog();
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm().ShowDialog();
        }
    }
}
