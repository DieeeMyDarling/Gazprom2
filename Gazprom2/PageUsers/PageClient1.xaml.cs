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
    /// Логика взаимодействия для PageClient1.xaml
    /// </summary>
    public partial class PageClient1 : Page
    {
        User _user = new User();
        public PageClient1(User user)
        {
           
            _user = user;
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageClient(_user));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
