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
    /// Логика взаимодействия для Добавитьзаданиепон.xaml
    /// </summary>
    public partial class Добавитьзаданиепон : Page
    {
        private Расписание_понедельник _Рас = new Расписание_понедельник();
        public Добавитьзаданиепон(Расписание_понедельник ремонт)
        {
            InitializeComponent();
            if (ремонт != null)
                _Рас = ремонт;

            DataContext = _Рас;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_Рас.Группы == null)
                errors.AppendLine("Выберите группу");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            //if (_Рас.Преподаватели == null)
            //  errors.AppendLine("Выберите преподавателя");
            // if (errors.Length > 0)
            // {
            //    MessageBox.Show(errors.ToString());
            //    return;
            //}


            if (_Рас.ID_Понедельник == 0)
                РасписаниеEntities.GetContext().Расписание_понедельник.Add(_Рас);
            try
            {
                РасписаниеEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
