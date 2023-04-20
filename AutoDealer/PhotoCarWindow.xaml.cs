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
    public partial class PhotoCarWindow : Window
    {
        private Car _currentShow = new Car();
        public PhotoCarWindow(Car selectedService)
        {
            InitializeComponent();

            if (selectedService != null) _currentShow = selectedService;

            DataContext = _currentShow;

            switch (_currentShow.c_id)
            {
                case 7: imgcar.Source = new BitmapImage(new Uri("CarImage/3.jpg", UriKind.RelativeOrAbsolute));break;
                case 1020: imgcar.Source = new BitmapImage(new Uri("CarImage/1.jpg", UriKind.RelativeOrAbsolute));break;
                case 1022: imgcar.Source = new BitmapImage(new Uri("CarImage/13.jpg", UriKind.RelativeOrAbsolute));break;
                default: MessageBox.Show("Нет фото");break;
            }

            special.Text = _currentShow.c_specific;
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
