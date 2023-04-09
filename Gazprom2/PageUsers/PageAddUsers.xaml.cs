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
    /// Логика взаимодействия для PageAddUsers.xaml
    /// </summary>
    public partial class PageAddUsers : Page
    {
        private Worker _addWorker = new Worker();

        public PageAddUsers(Worker selectedWorker)
        {
            InitializeComponent();

            if (selectedWorker != null)
            {
                _addWorker = selectedWorker;
            }

            DataContext = _addWorker;
            CmbDolzh.ItemsSource = ODBConnectHelper.entObj.Role.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAdmin());
        }

        private void CmbDolzh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            _addWorker.idRole = (CmbDolzh.SelectedItem as Role).id;




            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_addWorker.id == 0)
                ODBConnectHelper.entObj.Worker.Add(_addWorker);
            try
            {
                ODBConnectHelper.entObj.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                FrameApp.frmObj.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
