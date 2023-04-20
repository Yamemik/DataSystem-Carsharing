using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AuthorWindow : Window
    {
        static public bool flag = false;
        public string name = "Вы не авторизованы!";
        public LogUser user = new LogUser();
        public AuthorWindow()
        {
            InitializeComponent();

            //DataContext = _currentShow;
            user = null;

            //passport.ItemsSource = AutoDealerEntities1.GetContext().Passport.ToList();
            //driver.ItemsSource = AutoDealerEntities1.GetContext().DriverLicense.ToList();
        }

        private void BtnCancel_click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (response == MessageBoxResult.Yes)
            {
                this.Close();
                this.Owner.Activate();
            }
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            var add = AutoDealerEntities1.GetContext().LogUser
                .Where(c => c.lu_login == login.Text && c.lu_password == password.Text)
                .FirstOrDefault();
            if(add != null)
            {
                flag = true;
                name = add.Employee.e_all;
                user = add;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!!");
            }
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
