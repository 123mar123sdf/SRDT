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

namespace Расписание_занятий
{
    /// <summary>
    /// Логика взаимодействия для Группытаб1.xaml
    /// </summary>
    public partial class Группытаб1 : Window
    {
        РасписаниеEntities context = new РасписаниеEntities();
        public Группытаб1()
        {
            InitializeComponent();
            ConnectOdb.conObj = new РасписаниеEntities();

            MainFrame.Navigate(new Группытаб2());

            Manager.MainFrame = MainFrame;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Back.Visibility = Visibility.Visible;

            }
            else
            {
                Back.Visibility = Visibility.Visible;

            }
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
