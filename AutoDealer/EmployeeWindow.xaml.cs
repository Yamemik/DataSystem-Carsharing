using System;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();

            dg_emp.ItemsSource = AutoDealerEntities1.GetContext().Employee.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //this.Owner.Activate();
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditEmpWindow add = new AddEditEmpWindow(null);
            add.Owner = this;
            add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = dg_emp.SelectedItems.Cast<Employee>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().Employee.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dg_emp.ItemsSource = AutoDealerEntities1.GetContext().Employee.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditEmpWindow add = new AddEditEmpWindow((Employee)dg_emp.SelectedItems[0]);
            add.Owner = this;
            add.Show();
        }

    }

}

