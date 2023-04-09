using Gazprom2.DataBase;
using Gazprom2.Help_classes;
using Gazprom2.PageUsers;
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

namespace Gazprom2.PageApllications
{
    /// <summary>
    /// Логика взаимодействия для PageAddApllicationGasConnection.xaml
    /// </summary>
    public partial class PageAddApllicationGasConnection : Page
    {
        User _user = new User();
        ApplicationForGasConnection _applicationForGasConnection = new ApplicationForGasConnection();
        public PageAddApllicationGasConnection(User user)
        {
            
            InitializeComponent();
            DataContext = _applicationForGasConnection;
            CmbConnection.ItemsSource = ODBConnectHelper.entObj.GasSupplyMethods.ToList() ;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            ApplicationForGasConnection ap = new ApplicationForGasConnection()
            {
                idUser = _user.id,
                idGasSupplyMethods = (CmbConnection.SelectedItem as GasSupplyMethods).id,
                Adress = AdressAdd.Text,
                idApplicationStatus = 1
            };
            ODBConnectHelper.entObj.ApplicationForGasConnection.Add(ap);
            ODBConnectHelper.entObj.SaveChanges();
            FrameApp.frmObj.GoBack();
         
        }

        private void CmbConnection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageClient(null));
        }
    }
}
