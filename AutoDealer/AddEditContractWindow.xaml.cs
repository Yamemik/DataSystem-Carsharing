using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace AutoDealer
{
    public partial class AddEditContractWindow : Window
    {
        private Contract _currentShow = new Contract();
        public bool flag = true;
        decimal coast_sum;
        double? sum_tarif = 0;
        double? sum_as = 0;
        int countday = 0;
        public AddEditContractWindow(Contract selectedService)
        {
            InitializeComponent();

            DateTime thisDay = DateTime.Today;

            _currentShow.con_if = "";
            if (selectedService != null) _currentShow = selectedService;
            else 
            {
                _currentShow.con_date = thisDay;
                _currentShow.con_dateend = thisDay.AddDays(1);
            }

            DataContext = _currentShow;    
            
            //сортировка клиента по ЧС{
            var bl = AutoDealerEntities1.GetContext().BlackList.ToList();
            var clientDb = AutoDealerEntities1.GetContext().Client.ToList();
            List<Client> people = new List<Client>();
            foreach (var a in clientDb)
            {
                foreach (var b in bl)
                {
                    if (a.cl_id == b.Client.cl_id)
                        people.Add(a);
                } 
            }
            foreach (var a in people)
            {
                clientDb.Remove(a);
            }
            //}
            //сортировка авто по{
            var car_all = AutoDealerEntities1.GetContext().Car.ToList();
            var contract_all = AutoDealerEntities1.GetContext().Contract.ToList();
            List<Car> car_selected = new List<Car>();

            foreach (var a in car_all)
            {
                foreach (var b in contract_all)
                {
                    if (a.c_id == b.Car.c_id && thisDay < b.con_dateend)
                        car_selected.Add(a);
                }
            }
            foreach (var a in car_selected)
            {
                car_all.Remove(a);
            }
            if(selectedService != null) car_all.Add(_currentShow.Car);
            //}
            client.ItemsSource = clientDb;
            car.ItemsSource = car_all;
            if1.ItemsSource = AutoDealerEntities1.GetContext().AddService.ToList();
            if2.ItemsSource = AutoDealerEntities1.GetContext().Tariff.ToList();
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
            if (_currentShow.con_id == 0)
            {
                AutoDealerEntities1.GetContext().Contract.Add(_currentShow);
            }
            else if (_currentShow.con_id > 0)
            {
                var add = AutoDealerEntities1.GetContext().Contract
                    //Загрузить тек.строку
                    .Where(c => c.con_id == _currentShow.con_id)
                    .FirstOrDefault();
                //Внести изменения
                add.con_cost = (decimal)coast_sum;
                add.con_dateend = dateend.SelectedDate;
                add.con_long = countday;
            }
            try
            {
                AutoDealerEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                ContractWindow client = new ContractWindow();
                client.Owner = this.Owner.Owner;
                client.Show();

                this.Owner.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSum_click(object sender, RoutedEventArgs e)
        {
            //dateend.SelectedDate = _currentShow.con_date.AddDays(_currentShow.con_long);

            double summ = 0;
            coast_sum = (decimal)(sum_as + sum_tarif);
            cost.Text = coast_sum.ToString();

            summ = Convert.ToDouble(long1.Text) * Convert.ToDouble(cost.Text);
            sum.Text = summ.ToString();
            _currentShow.con_sum = summ;
            _currentShow.con_cost = coast_sum;

            DataContext = _currentShow;
        }

        private void combobox_as_selected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //dateend.SelectedDate = _currentShow.con_date.AddDays(_currentShow.con_long);

            sum_as = _currentShow.Car.AddService.as_sum;
            sum_tarif = _currentShow.Car.Tariff.t_sum;

            double summ = 0;
            coast_sum = (decimal)(sum_as + sum_tarif);
            cost.Text = coast_sum.ToString();

            summ = Convert.ToDouble(long1.Text) * Convert.ToDouble(cost.Text);
            sum.Text = summ.ToString();
            _currentShow.con_sum = summ;
            _currentShow.con_cost = coast_sum;

            DataContext = _currentShow;
        }

        private void combobox_tariff_selected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //dateend.SelectedDate = _currentShow.con_date.AddDays(_currentShow.con_long);

            sum_as = _currentShow.Car.AddService.as_sum;
            sum_tarif = _currentShow.Car.Tariff.t_sum;

            double summ = 0;
            coast_sum = (decimal)(sum_as + sum_tarif);
            cost.Text = coast_sum.ToString();

            summ = Convert.ToDouble(long1.Text) * Convert.ToDouble(cost.Text);
            sum.Text = summ.ToString();
            _currentShow.con_sum = summ;
            _currentShow.con_cost = coast_sum;

            DataContext = _currentShow;
        }

        private void Datepicker_selected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (_currentShow.con_id != 0)
            {
                countday = _currentShow.con_dateend.Value.Subtract(_currentShow.con_date).Days;
                long1.Text = countday.ToString();

                //сортировка авто по{
                var car_all = AutoDealerEntities1.GetContext().Car.ToList();
                var contract_all = AutoDealerEntities1.GetContext().Contract.ToList();
                List<Car> car_selected = new List<Car>();

                foreach (var a in car_all)
                {
                    foreach (var b in contract_all)
                    {
                        if (a.c_id == b.Car.c_id && _currentShow.con_date < b.con_dateend)
                            car_selected.Add(a);
                    }
                }
                foreach (var a in car_selected)
                {
                    car_all.Remove(a);
                }
                car_all.Add(_currentShow.Car);
            }
            else
            {
                countday = _currentShow.con_dateend.Value == null ? 0 :_currentShow.con_dateend.Value.Subtract(_currentShow.con_date).Days;
                long1.Text = countday != 0 ? countday.ToString() : "";

                //сортировка авто по{
                var car_all = AutoDealerEntities1.GetContext().Car.ToList();
                var contract_all = AutoDealerEntities1.GetContext().Contract.ToList();
                List<Car> car_selected = new List<Car>();

                foreach (var a in car_all)
                {
                    foreach (var b in contract_all)
                    {
                        if (a.c_id == b.Car.c_id && _currentShow.con_date < b.con_dateend)
                            car_selected.Add(a);
                    }
                }
                foreach (var a in car_selected)
                {
                    car_all.Remove(a);
                }
                car_all.Add(_currentShow.Car);
            }
        }
    }
}
