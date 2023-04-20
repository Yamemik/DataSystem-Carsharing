using System;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class LogUserWindow : Window
    {
        public LogUserWindow()
        {
            InitializeComponent();

            dg_user.ItemsSource = AutoDealerEntities1.GetContext().LogUser.ToList();

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Activate();
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditUserWindow add = new AddEditUserWindow(null);
            add.Owner = this;
            add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = dg_user.SelectedItems.Cast<LogUser>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().LogUser.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dg_user.ItemsSource = AutoDealerEntities1.GetContext().LogUser.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditUserWindow add = new AddEditUserWindow((LogUser)dg_user.SelectedItems[0]);
            add.Owner = this;
            add.Show();
        }

    }
}
