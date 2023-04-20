using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditUserWindow : Window
    {
        private LogUser _currentShow = new LogUser();

        public AddEditUserWindow(LogUser selectedService)
        {
            InitializeComponent();

            if (selectedService != null) _currentShow = selectedService;

            DataContext = _currentShow;

            employee.ItemsSource = AutoDealerEntities1.GetContext().Employee.ToList();

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
            //добавление
            if (_currentShow.lu_id == 0)
            {
                AutoDealerEntities1.GetContext().LogUser.Add(_currentShow);
            }
            else if (_currentShow.lu_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().LogUser
                    //Загрузить тек.строку
                    .Where(c => c.lu_id == _currentShow.lu_id)
                    .FirstOrDefault();
                //Внести изменения через дата  контекст
                //add.e_name = name.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                LogUserWindow logUser = new LogUserWindow();
                logUser.Owner = this.Owner.Owner;
                logUser.Show();

                this.Owner.Close();
                //this.Owner.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
