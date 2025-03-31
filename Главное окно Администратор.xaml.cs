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
using Расписание_занятий.ApplicationData;

namespace Расписание_занятий
{
    /// <summary>
    /// Логика взаимодействия для Главное_окно_Администратор.xaml
    /// </summary>
    public partial class Главное_окно_Администратор : Window
    {
        РасписаниеEntities context = new РасписаниеEntities();
        public Главное_окно_Администратор()
        {
            InitializeComponent();

            Button_Click(this, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Расписание2());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }
           // Расписание1 расписание1 = new Расписание1();
           // расписание1.Show();
            
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
 
    }
        int i = 0;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(i==0)
            { 
                 ConnectOdb.conObj = new РасписаниеEntities();

            MainFrame.Navigate(new Преподтаб2());

            Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }


            //  Преподтаб1 расписание1 = new Преподтаб1();
            // расписание1.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           Выборвыхода расписание1 = new Выборвыхода();
            расписание1.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Группытаб2());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }

           // Группытаб1  расписание1 = new Группытаб1();
           // расписание1.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Кабинетытаб2());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }
            //Кабинетытаб1 расписание1 = new Кабинетытаб1();
            //расписание1.Show();
            //this.Hide();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Кабинетытаб2());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }
           // Кабинетытаб1 расписание1 = new Кабинетытаб1();
            //расписание1.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Предметытаб2());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }

           // Предметытаб1 расписание1 = new Предметытаб1();
           // расписание1.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow расписание1 = new MainWindow();
            расписание1.Show();
            this.Hide();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Отчетыст());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Справочники расписание1 = new Справочники();
            расписание1.Show();
           
        }

      

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           
        
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Главнаяст());

                Manager.MainFrame = MainFrame;

            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите выйти из системы?"
               , "Выход - Расписание занятий", MessageBoxButton.YesNo,
               MessageBoxImage.Question);


            if (result == MessageBoxResult.Yes)
            {

                this.Visibility = Visibility.Hidden;
                Environment.Exit(0);

            }
            else
            {
                Главное_окно_Администратор mainWindow = new Главное_окно_Администратор();
                mainWindow.Show();
                this.Hide();

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                ConnectOdb.conObj = new РасписаниеEntities();

                MainFrame.Navigate(new Отчетыст());

                Manager.MainFrame = MainFrame;

            }
            else
            { Close(); }

        }
    }
}
