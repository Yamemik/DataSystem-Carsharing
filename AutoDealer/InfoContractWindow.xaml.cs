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
    public partial class InfoContractWindow : Window
    {
        private Contract _currentShow = new Contract();

        public InfoContractWindow(Contract selectedService)
        {
            InitializeComponent();

            if (selectedService != null) _currentShow = selectedService;

            DataContext = _currentShow;
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
