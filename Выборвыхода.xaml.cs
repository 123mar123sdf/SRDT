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
    /// Логика взаимодействия для Выборвыхода.xaml
    /// </summary>
    public partial class Выборвыхода : Window
    {
        public Выборвыхода()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show($"Вы точно хотите сменить пользователя?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    MainWindow расписание1 = new MainWindow();
                    расписание1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show($"Вы точно хотите выйте из системы?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Главное_окно_Администратор расписание1 = new Главное_окно_Администратор();
            расписание1.Show();
            this.Hide();
        }
    }
}

