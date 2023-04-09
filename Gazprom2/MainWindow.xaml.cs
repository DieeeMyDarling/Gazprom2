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

namespace Gazprom2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frmObj = FrmMain;
            FrmMain.Navigate(new PageLogin());
            ODBConnectHelper.entObj = new DataBase.Gazprom2Entities();
        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
