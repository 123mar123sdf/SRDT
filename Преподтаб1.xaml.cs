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
    /// Логика взаимодействия для Преподтаб1.xaml
    /// </summary>
    public partial class Преподтаб1 : Window
    {
        РасписаниеEntities context = new РасписаниеEntities();

        public Преподтаб1()
        {
            InitializeComponent();
            ConnectOdb.conObj = new РасписаниеEntities();


            MainFrame.Navigate(new Преподтаб2());

            Manager.MainFrame = MainFrame;
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

     

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}

