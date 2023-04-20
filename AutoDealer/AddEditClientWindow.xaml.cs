using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditClientWindow : Window
    {
        private Client _currentShow = new Client();
        //public Passport passportNew = new Passport(); 

        public AddEditClientWindow(Client selectedService)
        {
            InitializeComponent();

            if (selectedService != null) _currentShow = selectedService;

            DataContext = _currentShow;

            passport.ItemsSource = AutoDealerEntities1.GetContext().Passport.ToList();
            driver.ItemsSource = AutoDealerEntities1.GetContext().DriverLicense.ToList();

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
            if (_currentShow.cl_id == 0)
            {
                AutoDealerEntities1.GetContext().Client.Add(_currentShow);
            }
            else if (_currentShow.cl_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Client
                    //Загрузить тек.строку
                    .Where(c => c.cl_id == _currentShow.cl_id)
                    .FirstOrDefault();
                //Внести изменения
                add.cl_name = name.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                ClientWindow client = new ClientWindow();
                client.Owner = this.Owner.Owner;
                client.Show();

                this.Owner.Close();
                //this.Owner.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPassport_click(object sender, RoutedEventArgs e)
        {
            AddEditPassportWindow passportWindow = new AddEditPassportWindow();
            passportWindow.Owner = this;
            passportWindow.ShowDialog();
            if(passportWindow.DialogResult == false)
            {
                passport.ItemsSource = AutoDealerEntities1.GetContext().Passport.ToList();
                passport.SelectedItem = passportWindow._currentShow;
            }
        }

        private void btnDriver_click(object sender, RoutedEventArgs e)
        {
            AddEditDriverWindow drivertWindow = new AddEditDriverWindow();
            drivertWindow.Owner = this;
            drivertWindow.ShowDialog();
            if (drivertWindow.DialogResult == false)
            {
                driver.ItemsSource = AutoDealerEntities1.GetContext().DriverLicense.ToList();
                driver.SelectedItem = drivertWindow._currentShow;
            }
        }
    }
}
