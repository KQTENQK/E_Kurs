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
    public partial class RemoveUserForm : Form
    {
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Run(() =>
                {
                    using (var context = new ClientContext())
                    {
                        var clients = context.Clients;
                        foreach (var client in clients)
                        {
                            string dataToAdd = $"Username: {client.Username}   User Type: {client.UserType}   Id: {client.Id}";
                            listBoxUsers?.Invoke(new Action(() => listBoxUsers.Items.Add(dataToAdd)));
                            listBoxUsers?.Invoke(new Action(() => listBoxUsers.Update()));
                        }
                    }
                });

            });
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                using (var context = new ClientContext())
                {
                    int idIndex = listBoxUsers.SelectedItem.ToString().IndexOf("Id: ");
                    int removingUser = int.Parse(listBoxUsers.SelectedItem.ToString().Substring(idIndex).Replace("Id: ", ""));
                    var client = context.Clients.Where(removingClient => removingClient.Id == removingUser).FirstOrDefault();

                    if (client != null)
                    {
                        context.Clients.Remove(client);
                        context.SaveChanges();
                        listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
                        new RemovedSuccessfully().ShowDialog();
                    }
                    else
                    {
                        new SomethingWentWrongForm().ShowDialog();
                    }
                }
            }
        }
    }
}
