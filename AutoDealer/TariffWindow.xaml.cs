using System;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class TariffWindow : Window
    {
        public TariffWindow()
        {
            InitializeComponent();
            dg_client.ItemsSource = AutoDealerEntities1.GetContext().Tariff.ToList();

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //this.Owner.Activate();
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditTariffWindow add = new AddEditTariffWindow(null);
            add.Owner = this;
            add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = dg_client.SelectedItems.Cast<Tariff>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().Tariff.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dg_client.ItemsSource = AutoDealerEntities1.GetContext().Tariff.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditTariffWindow add = new AddEditTariffWindow((Tariff)dg_client.SelectedItems[0]);
            add.Owner = this;
            add.Show();
        }
    }
}
