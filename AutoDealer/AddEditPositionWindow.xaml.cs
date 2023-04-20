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
    public partial class AddEditPositionWindow : Window
    {
        private Position _currentShow = new Position();

        public AddEditPositionWindow(Position selectedService)
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
            if (_currentShow.p_id == 0)
            {
                AutoDealerEntities1.GetContext().Position.Add(_currentShow);
            }
            else if (_currentShow.p_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Position
                    //Загрузить тек.строку
                    .Where(c => c.p_id == _currentShow.p_id)
                    .FirstOrDefault();
                //Внести изменения
                add.p_name = name.Text;
                //add.p_bet = bet.Text;
                //add.p_salary = sal.Text;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                PositionWindow position = new PositionWindow();
                position.Owner = this.Owner.Owner;
                position.ShowDialog();

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
