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

namespace Расписание_занятий
{
    /// <summary>
    /// Логика взаимодействия для Отчетыст.xaml
    /// </summary>
    public partial class Отчетыст : Page
    {
        public Отчетыст()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ОтчетПреподаватель расписание1 = new ОтчетПреподаватель();
            расписание1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ОтчетРасписание расписание1 = new ОтчетРасписание();
            расписание1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ОтчетКабинеты расписание1 = new ОтчетКабинеты();
            расписание1.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ОтчетПредметы расписание1 = new ОтчетПредметы();
            расписание1.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ОтчетГруппы расписание1 = new ОтчетГруппы();
            расписание1.Show();
        }
    }
}
