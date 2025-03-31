using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Расписание_занятий
{
    /// <summary>
    /// Логика взаимодействия для Группытаб2.xaml
    /// </summary>
    public partial class Группытаб2 : Page
    {
        private РасписаниеEntities _context = new РасписаниеEntities();
        public Группытаб2()
        {
            InitializeComponent();
            доходыDataGrid.ItemsSource = РасписаниеEntities.GetContext().Группы.ToList();
          
            var allTypes = РасписаниеEntities.GetContext().Группы.ToList();
         
            
           

            UpdateTours();
        }
        private void UpdateTours()
        {
            var currentTours = РасписаниеEntities.GetContext().Группы.ToList();




           
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (Visibility == Visibility.Visible)
            {
                РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                доходыDataGrid.ItemsSource = РасписаниеEntities.GetContext().Группы.ToList();
            }



        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавить_группу(null));
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавить_группу((sender as Button).DataContext as Группы));
        }
     

        private void Chec_Checked(object sender, RoutedEventArgs e)
        {

            UpdateTours();
        }

        private void Chec_Unchecked(object sender, RoutedEventArgs e)
        {

            UpdateTours();
        }

        private void TBoxSe_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            string filterText = TBoxSez.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(доходыDataGrid.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {

                cv.Filter = o =>
                {
                    Группы p = o as Группы;
                    return (p.Название_группы.ToUpper().StartsWith(filterText.ToUpper()));
                };


            }
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            UpdateTours();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var hotelFor = доходыDataGrid.SelectedItems.Cast<Группы>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Группы.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    доходыDataGrid.ItemsSource = РасписаниеEntities.GetContext().Группы.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }



            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExportExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExportWord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            ОтчетГруппы расписание1 = new ОтчетГруппы();
            расписание1.Show();
        }
    }
}
