using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditDriverWindow : Window
    {
        public DriverLicense _currentShow = new DriverLicense();
        public AddEditDriverWindow()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            _currentShow.dl_date = thisDay;

            DataContext = _currentShow;

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
            if (_currentShow.dl_id == 0)
            {
                AutoDealerEntities1.GetContext().DriverLicense.Add(_currentShow);
            }
            else if (_currentShow.dl_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Passport
                    //Загрузить тек.строку
                    .Where(c => c.p_id == _currentShow.dl_id)
                    .FirstOrDefault();
                //Внести изменения
                add.ps_series = series.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                this.Owner.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
