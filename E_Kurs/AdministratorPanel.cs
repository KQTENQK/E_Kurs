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
    public partial class AdministratorPanel : Form
    {
        private Administrator _administrator;

        public AdministratorPanel(Administrator administrator)
        {
            InitializeComponent();
            _administrator = administrator;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = inputModelName.Text;
            string serialNumber = inputSerialNumber.Text;
            int price;
            bool isValid = int.TryParse(inputPrice.Text, out price);

            if (name != null && serialNumber != null && isValid)
            {
                using (var context = new ModelsContext())
                {
                    var model = new Model()
                    {
                        AddedById = _administrator.Id,
                        Name = name,
                        SerialNumber = serialNumber,
                        Price = price
                    };

                    context.Models.Add(model);

                    context.SaveChanges();
                }

                new SuccessfullyAddedForm().ShowDialog();
            }
        }

        private void AdministratorPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }

        private void buttonAddAdministrator_Click(object sender, EventArgs e)
        {
            new SighUpAdministratorForm().ShowDialog();
        }

        private void buttonAddModerator_Click(object sender, EventArgs e)
        {
            new SignUpModerator().ShowDialog();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            new RemoveUserForm().ShowDialog();
        }
    }
}
