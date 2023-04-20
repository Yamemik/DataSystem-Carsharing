using System;
using System.ComponentModel;
using System.Windows;

namespace AutoDealer
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string imageUri;
        private bool flag = false;
        private string name = "Вы не авторизованы!";
        public string ImageUri
        {
            get
            {
                return imageUri;
            }
            set
            {
                imageUri = value;
                OnPropChanged("ImageUri");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropChanged(string prop)
        {
            var ev = PropertyChanged;
            if (ev == null) return;
            ev(this, new PropertyChangedEventArgs(prop));
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, RoutedEventArgs e)
        {
            DealerWindow dealerWindow = new DealerWindow();
            dealerWindow.Owner = this;
            dealerWindow.ShowDialog();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение для каршеринга автомобилей\n" +
                            "Выполнил: Прыгунов Михаил\n");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Закрыть приложение?","Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (response == MessageBoxResult.Yes) Application.Current.Shutdown();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            testWindow.Owner = this;
            testWindow.ShowDialog();
        }

        private void btnDBAccess_Click(object sender, RoutedEventArgs e)
        {
            StatusAutoWindow testWindow = new StatusAutoWindow();
            testWindow.Owner = this;
            testWindow.ShowDialog();
        }

        private void btnEntry(object sender, RoutedEventArgs e)
        {
            AuthorWindow author = new AuthorWindow();
            author.Owner = this;
            author.ShowDialog();
            if (author.DialogResult == false)
            {
                flag = AuthorWindow.flag;
                name = author.name;
                if (author.user != null)
                {
                    if (author.user.Employee.e_position == 1) OpenApp1(flag, name);
                    if (author.user.Employee.e_position == 2) OpenApp2(flag, name);
                }
                try
                {
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void OpenApp1(bool flag,string name)
        {
            if (flag)
            {
                service.Visibility = Visibility.Visible;
                rental.Visibility = Visibility.Visible;
                car.Visibility = Visibility.Visible;
                adm.Visibility = Visibility.Visible;
                userName.Text = name;
            }
            else
            {
                service.Visibility = Visibility.Hidden;
                rental.Visibility = Visibility.Hidden;
                car.Visibility = Visibility.Hidden;
                adm.Visibility = Visibility.Hidden;
                userName.Text = name;
            }
        }
        private void OpenApp2(bool flag, string name)
        {
            if (flag)
            {
                rental.Visibility = Visibility.Visible;
                car.Visibility = Visibility.Visible;
                userName.Text = name;
            }
            else
            {
                rental.Visibility = Visibility.Hidden;
                car.Visibility = Visibility.Hidden;
                userName.Text = name;
            }
        }


        private void btnEmployee_click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employee = new EmployeeWindow();
            employee.Owner = this;
            employee.ShowDialog();
        }

        private void btnRepair_click(object sender, RoutedEventArgs e)
        {
            ASWindow sWindow = new ASWindow();
            sWindow.Owner = this;
            sWindow.ShowDialog();
        }

        private void btnDoc_click(object sender, RoutedEventArgs e)
        {
            ContractWindow contract = new ContractWindow();
            contract.Owner = this;
            contract.ShowDialog();
        }

        private void btnClient_click(object sender, RoutedEventArgs e)
        {
            ClientWindow client = new ClientWindow();
            client.Owner = this;
            client.ShowDialog();
        }

        private void btnRule_click(object sender, RoutedEventArgs e)
        {
            TariffWindow tariff = new TariffWindow();
            tariff.Owner = this;
            tariff.ShowDialog();
        }

        private void btnBlackList_click(object sender, RoutedEventArgs e)
        {
            BlWindow bl = new BlWindow();
            bl.Owner = this;
            bl.ShowDialog();
        }

        private void btnUser_click(object sender, RoutedEventArgs e)
        {
            LogUserWindow logUser = new LogUserWindow();
            logUser.Owner = this;
            logUser.ShowDialog();
        }

        private void btnLaw_click(object sender, RoutedEventArgs e)
        {
            PositionWindow position = new PositionWindow();
            position.Owner = this;
            position.ShowDialog();
        }

        private void BtnEx_click(object sender, RoutedEventArgs e)
        {
            flag = false;
            name = "Вы не авторизованы!";
            OpenApp1(flag, name);
        }

        private void btnRuleCar_click(object sender, RoutedEventArgs e)
        {
            RuleCarWindow ruleCar = new RuleCarWindow();
            ruleCar.Owner = this;
            ruleCar.ShowDialog();
        }
    }   
}
