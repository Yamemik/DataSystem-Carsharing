using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditAsWindow : Window
    {
        private AddService _currentShow = new AddService();

        public AddEditAsWindow(AddService selectedService)
        {
            InitializeComponent();

            if (selectedService != null) _currentShow = selectedService;

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
            if (_currentShow.as_id == 0)
            {
                AutoDealerEntities1.GetContext().AddService.Add(_currentShow);                
            }
            else if (_currentShow.as_id > 0)
            {
                var addService = AutoDealerEntities1.GetContext().AddService
                    //Загрузить тек.строку
                    .Where(c => c.as_id == _currentShow.as_id)
                    .FirstOrDefault();
                //Внести изменения
                addService.as_enu = enu.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                ASWindow aS = new ASWindow();
                aS.Owner = this.Owner.Owner;
                aS.Show();

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
