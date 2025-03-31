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
    /// Логика взаимодействия для Добавить_группу.xaml
    /// </summary>
    public partial class Добавить_группу : Page
    {
        private Группы _Доходы = new Группы();
        public Добавить_группу(Группы доходы)
        {
            InitializeComponent();
            if (доходы != null)
                _Доходы = доходы;

            DataContext = _Доходы;
             ComboBox2.ItemsSource = РасписаниеEntities.GetContext().Объединения.ToList();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

           

            if (_Доходы.Объединения == null)
                errors.AppendLine("Выберите объединение");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
           


            if (_Доходы.ID_Группы == 0)
                РасписаниеEntities.GetContext().Группы.Add(_Доходы);
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

