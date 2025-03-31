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
    /// Логика взаимодействия для Добавитьпрепод.xaml
    /// </summary>
    public partial class Добавитьпрепод : Page
    {
        private Педагоги _Педагоги = new Педагоги();
       
        public Добавитьпрепод(Педагоги Педагоги)
        {
            InitializeComponent();
            if (Педагоги != null)
                _Педагоги = Педагоги;

            DataContext = _Педагоги;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

           


            if (_Педагоги.ID_Педагога == 0)
                РасписаниеEntities.GetContext().Педагоги.Add(_Педагоги);
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
            
            
        }
    }
}
