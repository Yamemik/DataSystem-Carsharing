using Microsoft.Win32;
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AutoDealer
{
    public partial class AddEditCar : Window
    {
        private Car _currentShow = new Car();
        private BitmapSource img;

        public AddEditCar(Car selectedService)
        {
            InitializeComponent();

            comboTariff.ItemsSource = AutoDealerEntities1.GetContext().Tariff.ToList();
            comboServ.ItemsSource = AutoDealerEntities1.GetContext().AddService.ToList();

            if (selectedService != null)
            {
                _currentShow = selectedService;
            }
            DataContext = _currentShow;
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Выйти без сохранения", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (response == MessageBoxResult.Yes) this.Close();
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            //добавление
            if (_currentShow.c_id == 0)
            {
                //_currentShow.c_photo = img;
                AutoDealerEntities1.GetContext().Car.Add(_currentShow);
            }
            else if (_currentShow.c_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Car
                    //Загрузить тек.строку
                    .Where(c => c.c_id == _currentShow.c_id)
                    .FirstOrDefault();
                //Внести изменения через дата  контекст
                //add.c_mark = mark.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                DealerWindow dealer = new DealerWindow();
                dealer.Owner = this.Owner.Owner;
                dealer.Show();

                this.Owner.Close();
                //this.Owner.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddImg_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                img = new BitmapImage(new Uri(op.FileName));
                img_car.Source = img;
            }
        }
    }
}

