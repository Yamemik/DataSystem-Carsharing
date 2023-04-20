using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoDealer
{
    public partial class ContractWindow : Window
    {
        public ObservableCollection<Contract> films = new ObservableCollection<Contract>();
        public ContractWindow()
        {
            InitializeComponent();
            dg_con.ItemsSource = AutoDealerEntities1.GetContext().Contract.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditContractWindow add = new AddEditContractWindow(null);
            add.Owner = this;
            add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = dg_con.SelectedItems.Cast<Contract>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().Contract.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dg_con.ItemsSource = AutoDealerEntities1.GetContext().Contract.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditContractWindow add = new AddEditContractWindow((Contract)dg_con.SelectedItems[0]);
            add.Owner = this;
            add.flag = false;
            add.Show();
        }

        private void btnCon_click(object sender, RoutedEventArgs e)
        {
            InfoContractWindow add = new InfoContractWindow((sender as Button).DataContext as Contract);
            add.Owner = this;
            add.ShowDialog();
        }

        private void btnFind_click(object sender, RoutedEventArgs e)
        {
            string s = txtFind.Text;

            var add = AutoDealerEntities1.GetContext().Contract
            .Where(c => c.Client.cl_name.Contains(s))
            .FirstOrDefault();

            if (add != null)
            {
                films.Add(add);
                dg_con.ItemsSource = films;
            }
        }

        private void btnFindCanceled_click(object sender, RoutedEventArgs e)
        {
            dg_con.ItemsSource = AutoDealerEntities1.GetContext().Contract.ToList();
            txtFind.Text = "";
            films.Clear();
        }
    }
}
