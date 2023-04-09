using Gazprom2.DataBase;
using Gazprom2.Help_classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gazprom2.PageUsers
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            Users.ItemsSource = ODBConnectHelper.entObj.Worker.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddUsers(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var animalsForRemoving = Users.SelectedItems.Cast<Worker>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {animalsForRemoving.Count()} элементов", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)


            {
                try
                {
                    ODBConnectHelper.entObj.Worker.RemoveRange(animalsForRemoving);
                    ODBConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            FrameApp.frmObj.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ODBConnectHelper.entObj.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Users.ItemsSource = ODBConnectHelper.entObj.Worker.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddUsers((sender as Button).DataContext as Worker));
        }
    }
}
