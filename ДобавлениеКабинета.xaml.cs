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
    /// Логика взаимодействия для ДобавлениеКабинета.xaml
    /// </summary>
    public partial class ДобавлениеКабинета : Page
    {
        private Кабинеты _Доходы = new Кабинеты();
        public ДобавлениеКабинета(Кабинеты доходы)
        {
            InitializeComponent();
            if (доходы != null)
                _Доходы = доходы;

            DataContext = _Доходы;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

          


            if (_Доходы.ID_Кабинета == 0)
                РасписаниеEntities.GetContext().Кабинеты.Add(_Доходы);
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Главное_окно_Администратор главное_Окно_Администратор = new Главное_окно_Администратор();
            главное_Окно_Администратор.Show();
            

        }
    }
}
