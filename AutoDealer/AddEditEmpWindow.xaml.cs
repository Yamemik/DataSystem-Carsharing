using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditEmpWindow : Window
    {
        private Employee _currentShow = new Employee();

        public AddEditEmpWindow(Employee selectedService)
        {
            InitializeComponent();

            DateTime thisDay = DateTime.Today;

            if (selectedService != null) _currentShow = selectedService;
            if (selectedService == null) _currentShow.e_birthday = thisDay;

            DataContext = _currentShow;

            position.ItemsSource = AutoDealerEntities1.GetContext().Position.ToList();

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
            if (_currentShow.e_id == 0)
            {
                AutoDealerEntities1.GetContext().Employee.Add(_currentShow);
            }
            else if (_currentShow.e_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Employee
                    //Загрузить тек.строку
                    .Where(c => c.e_id == _currentShow.e_id)
                    .FirstOrDefault();
                //Внести изменения через дата  контекст
                //add.e_name = name.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                EmployeeWindow employee = new EmployeeWindow();
                employee.Owner = this.Owner.Owner;
                employee.Show();

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
