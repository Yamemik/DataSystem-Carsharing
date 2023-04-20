using System;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class PositionWindow : Window
    {
        public PositionWindow()
        {
            InitializeComponent();
            dg_pos.ItemsSource = AutoDealerEntities1.GetContext().Position.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditPositionWindow add = new AddEditPositionWindow(null);
            add.Owner = this;
            add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = dg_pos.SelectedItems.Cast<Position>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().Position.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dg_pos.ItemsSource = AutoDealerEntities1.GetContext().Position.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditPositionWindow add = new AddEditPositionWindow((Position)dg_pos.SelectedItems[0]);
            add.Owner = this;
            add.Show();
        }
    }
}
