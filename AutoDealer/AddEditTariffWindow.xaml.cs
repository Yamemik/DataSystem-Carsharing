using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoDealer
{
    public partial class AddEditTariffWindow : Window
    {
        private Tariff _currentShow = new Tariff();

        public AddEditTariffWindow(Tariff selectedService)
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
            if (_currentShow.t_id == 0)
            {
                AutoDealerEntities1.GetContext().Tariff.Add(_currentShow);
            }
            else if (_currentShow.t_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Tariff
                    //Загрузить тек.строку
                    .Where(c => c.t_id == _currentShow.t_id)
                    .FirstOrDefault();
                //Внести изменения
                add.t_name = name.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                TariffWindow client = new TariffWindow();
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
    }
}
