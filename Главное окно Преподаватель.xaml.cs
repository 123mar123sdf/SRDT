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
    /// Логика взаимодействия для Главное_окно_Преподаватель.xaml
    /// </summary>
    public partial class Главное_окно_Преподаватель : Window
    {
        public Главное_окно_Преподаватель()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Расписаниеучитель расписание1 = new Расписаниеучитель();
            расписание1.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow расписание1 = new MainWindow();
            расписание1.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Выборвыхода расписание1 = new Выборвыхода();
            расписание1.Show();
            this.Hide();
        }
    }
}
