using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kurs
{
    public partial class ModeratorPanel : Form
    {
        private Moderator _moderator;
        public ModeratorPanel(Moderator moderator)
        {
            InitializeComponent();
            _moderator = moderator;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedItem != null)
            {
                int idIndex = listBoxGoods.SelectedItem.ToString().IndexOf("Id: ");
                int buyingItemId = int.Parse(listBoxGoods.SelectedItem.ToString().Substring(idIndex).Replace("Id: ", ""));

                using (var context = new ModelsContext())
                {
                    var models = context.Models.Where(model => model.Id == buyingItemId);
                    if (models.Count() > 0)
                    {
                        var model = models.First();
                        context.Models.Remove(model);

                        context.SaveChanges();
                        listBoxGoods.Items.RemoveAt(listBoxGoods.SelectedIndex);

                        new RemovedSuccessfully().ShowDialog();
                    }
                }
            }
        }

        private void ModeratorPanel_Load(object sender, EventArgs e)
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

        private void ModeratorPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }
    }
}
