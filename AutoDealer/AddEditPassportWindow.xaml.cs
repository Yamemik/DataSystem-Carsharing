using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditPassportWindow : Window
    {
        public Passport _currentShow = new Passport();

        public AddEditPassportWindow()
        {
            InitializeComponent();

            DateTime thisDay = DateTime.Today;
            _currentShow.ps_when = thisDay;
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
            if (_currentShow.p_id == 0)
            {
                AutoDealerEntities1.GetContext().Passport.Add(_currentShow);
            }
            else if (_currentShow.p_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Passport
                    //Загрузить тек.строку
                    .Where(c => c.p_id == _currentShow.p_id)
                    .FirstOrDefault();
                //Внести изменения
                add.ps_series = series.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                this.Owner.Activate();
                //add.passport.SelectedItem = _currentShow;
                //add.name.Text = fio;
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
