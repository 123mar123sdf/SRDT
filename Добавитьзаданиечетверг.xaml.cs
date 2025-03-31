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
    /// Логика взаимодействия для Добавитьзаданиечетверг.xaml
    /// </summary>
    public partial class Добавитьзаданиечетверг : Page
    {
        private Расписание_четверг _Рас = new Расписание_четверг();
        public Добавитьзаданиечетверг(Расписание_четверг ремонт)
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


            if (_Рас.ID_Четверг == 0)
                РасписаниеEntities.GetContext().Расписание_четверг.Add(_Рас);
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
