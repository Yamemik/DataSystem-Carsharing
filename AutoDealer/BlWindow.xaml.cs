using System;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class BlWindow : Window
    {
        public BlWindow()
        {
            InitializeComponent();
            DGBl.ItemsSource = AutoDealerEntities1.GetContext().BlackList.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //this.Owner.Activate();
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditBl bl  = new AddEditBl();
            bl.Owner = this;
            bl.ShowDialog();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemForRemoving = DGBl.SelectedItems.Cast<BlackList>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().BlackList.RemoveRange(itemForRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGBl.ItemsSource = AutoDealerEntities1.GetContext().BlackList.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
