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
    /// Логика взаимодействия для Добавитьпредметтт.xaml
    /// </summary>
    public partial class Добавитьпредметтт : Page
    {
        private Объединения _Доходы = new Объединения();
        public Добавитьпредметтт(Объединения доходы)
        {
            InitializeComponent();
            if (доходы != null)
                _Доходы = доходы;

            DataContext = _Доходы;
             ComboBox2.ItemsSource = РасписаниеEntities.GetContext().Педагоги.ToList();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            

            if (_Доходы.Педагоги == null)
                errors.AppendLine("Выберите педагога");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
           



            if (_Доходы.ID_Объединения == 0)
                РасписаниеEntities.GetContext().Объединения.Add(_Доходы);
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

