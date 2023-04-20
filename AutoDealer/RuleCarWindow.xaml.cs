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
    /// <summary>
    /// Логика взаимодействия для RuleCarWindow.xaml
    /// </summary>
    public partial class RuleCarWindow : Window
    {
        public RuleCarWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
