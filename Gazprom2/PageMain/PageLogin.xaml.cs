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
using Gazprom2.PageMain;
using Gazprom2.PageUsers;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace Gazprom2
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var workerObj = ODBConnectHelper.entObj.Worker.FirstOrDefault(
                x => x.login == txtUser.Text && x.password ==
                txtPass.Password
                );
                var userObj = ODBConnectHelper.entObj.User.FirstOrDefault(
                x => x.Login == txtUser.Text && x.Password ==
                txtPass.Password
                );
                

                            if (workerObj != null)
                            {
                                switch (workerObj.idRole)
                                {
                                    case 2:
                                        FrameApp.frmObj.Navigate(new PageSotrudnik());
                                        MessageBox.Show("Здравствуйте 'Сотрудник'");
                                        break;

                                    case 3:
                                        FrameApp.frmObj.Navigate(new PageAdmin());
                                        MessageBox.Show("Здравствуйте 'Администратор'");
                                        break;

                                }
                            }
                            if (userObj != null)
                            {
                                switch (userObj.idRole)
                                {
                                    case 1:
                                        FrameApp.frmObj.Navigate(new PageClient1(userObj));
                                        MessageBox.Show("Здравствуйте пользователь " + userObj.fullName);
                                        break;
                                }
                            }

                            if (userObj == null && workerObj == null)
                            {
                                MessageBox.Show("Такой пользователь не найден");
                            }
                        
                       
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения: " + ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);





                //    {
                //             if (workerObj == null)



                //        else

                //        switch (workerObj.idRole)
                //        {
                //            case 2:
                //                FrameApp.frmObj.Navigate(new PageSotrudnik());
                //                MessageBox.Show("Здравствуйте 'Сотрудник'");

                //                break;

                //            case 3:
                //                FrameApp.frmObj.Navigate(new PageAdmin());
                //                MessageBox.Show("Здравствуйте 'Администратор'");
                //                break;

                //        }
                //}




                //catch (Exception ex)
                //{
                //    MessageBox.Show("Критический сбой в работе приложения: " +
                //    ex.Message.ToString(),
                //    "Уведомление",
                //    MessageBoxButton.OK,
                //    MessageBoxImage.Warning);
                //}

            }
    }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
