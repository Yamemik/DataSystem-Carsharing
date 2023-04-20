using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditBl : Window
    {
        private BlackList _currentShow = new BlackList();
        public AddEditBl()
        {
            InitializeComponent();
            DataContext = _currentShow;
            comboClient.ItemsSource = AutoDealerEntities1.GetContext().Client.ToList();
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Выйти без сохранения", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (response == MessageBoxResult.Yes)
            {
                this.Close();
                this.Owner.Activate();
            }
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (comboClient.SelectedItem == null) errors.AppendLine("Выберите клиента!");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            //if (AutoDealerEntities1.GetContext().BlackList.Find(_currentShow) != null)
            //{
            //    MessageBox.Show("Этот клиент уже в списке!");
            //    return;
            //}
            //}
            //добавление
            if (_currentShow.bl_id == 0)
            {
                AutoDealerEntities1.GetContext().BlackList.Add(_currentShow);
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                BlWindow aS = new BlWindow();
                aS.Owner = this.Owner.Owner;
                aS.Show();

                this.Owner.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
