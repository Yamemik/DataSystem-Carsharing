using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoDealer
{
    public partial class DealerWindow : Window
    {
        
        public DealerWindow()
        {
            InitializeComponent();
            DGCar.ItemsSource = AutoDealerEntities1.GetContext().Car.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Закрыть приложение?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (response == MessageBoxResult.Yes) Application.Current.Shutdown();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditCar addEditCar = new AddEditCar(null);
            addEditCar.Owner = this;
            addEditCar.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = DGCar.SelectedItems.Cast<Car>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().Car.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGCar.ItemsSource = AutoDealerEntities1.GetContext().Car.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnPhoto_click(object sender, RoutedEventArgs e)//мастштаб//открытие в вспылающем окне
        {
            PhotoCarWindow photoCar = new PhotoCarWindow((sender as Button).DataContext as Car);
            photoCar.Owner = this;
            photoCar.ShowDialog();
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditCar addEditCar = new AddEditCar((Car)DGCar.SelectedItems[0]);
            addEditCar.Owner = this;
            addEditCar.Show();
        }
    }
}
