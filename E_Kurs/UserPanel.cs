using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kurs
{
    public partial class UserPanel : Form
    {
        private User _user;
        public UserPanel(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await Task.Run(() =>
                {
                    using (var context = new ModelsContext())
                    {
                        var models = context.Models;
                        foreach (var model in models)
                        {
                            string dataToAdd = $"Model: {model.Name}   Price: {model.Price}   Serial number: {model.SerialNumber}   Id: {model.Id}";
                            listBoxGoods?.Invoke(new Action(() => listBoxGoods.Items.Add(dataToAdd)));
                            listBoxGoods?.Invoke(new Action(() => listBoxGoods.Update()));
                        }
                    }
                });

            });
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedItem != null)
            {
                using (var context = new ClientContext())
                {
                    int idIndex = listBoxGoods.SelectedItem.ToString().IndexOf("Id: ");
                    int buyingItemId = int.Parse(listBoxGoods.SelectedItem.ToString().Substring(idIndex).Replace("Id: ", ""));

                    using (var ctx = new ModelsContext())
                    {
                        var models = ctx.Models.Where(model => model.Id == buyingItemId);
                        if (models.Count() > 0)
                        {
                            var model = models.First();
                            var buyedModel = new BuyedByModels()
                            {
                                BuyedById = _user.Id,
                                ByuedId = model.Id,
                                Name = model.Name,
                                SerialNumber = model.SerialNumber
                            };

                            context.BuyedModels.Add(buyedModel);
                            ctx.Models.Remove(model);

                            context.SaveChanges();
                            ctx.SaveChanges();
                            listBoxGoods.Items.RemoveAt(listBoxGoods.SelectedIndex);

                            new BoughtSuccessfullyForm().ShowDialog();
                        }
                    }
                }
            }
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }
    }
}
