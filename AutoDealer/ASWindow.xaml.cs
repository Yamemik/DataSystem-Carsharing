using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace AutoDealer
{
    public partial class ASWindow : Window
    {
        public ASWindow()
        {
            InitializeComponent();
            DGAs.ItemsSource = AutoDealerEntities1.GetContext().AddService.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //this.Owner.Activate();
            this.Close();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditAsWindow add = new AddEditAsWindow(null);
            add.Owner = this;
            add.ShowDialog();
            //add.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var itemFoRemoving = DGAs.SelectedItems.Cast<AddService>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {itemFoRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AutoDealerEntities1.GetContext().AddService.RemoveRange(itemFoRemoving);
                    AutoDealerEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGAs.ItemsSource = AutoDealerEntities1.GetContext().AddService.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditAsWindow add = new AddEditAsWindow((AddService)DGAs.SelectedItems[0]);
            add.Owner = this;
            add.ShowDialog();

            //if (DGAs.SelectedItems.Count > 0)
            //{
            //    DataRowView row = (DataRowView)DGAs.SelectedItems[0];

            //    add.id.Text = row["as_id"].ToString();
            //    add.enu.Text = row["as_enu"].ToString();
            //    add.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Выберите строку для изменения");
            //}
        }
    }
}
