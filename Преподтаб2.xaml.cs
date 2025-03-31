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
    /// Логика взаимодействия для Преподтаб2.xaml
    /// </summary>
    public partial class Преподтаб2 : Page
    {
        private РасписаниеEntities _context = new РасписаниеEntities();
        public Преподтаб2()
        {
            InitializeComponent();
          
            GridSaleProduct4.ItemsSource = ConnectOdb.conObj.Педагоги.ToList();
           
            GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Педагоги.ToList();
          

            GridSaleProduct4.IsReadOnly = true;
            UpdateTours();
            var currentTours = РасписаниеEntities.GetContext().Педагоги.ToList();
             GridSaleProduct4.ItemsSource = currentTours;

        }
        private void UpdateTours()
        {
           
            var currentTours = РасписаниеEntities.GetContext().Педагоги.ToList();

            GridSaleProduct4.ItemsSource = currentTours.OrderBy(p => p.ФИО).ToList();
          
        }
       // public void UpdateData(object sender, object e)
       // {
          //  var HistoryProdyct = ConnectOdb.conObj.Педагоги.ToList();
          //  GridSaleProduct4.ItemsSource = HistoryProdyct;
          //  GridSaleProduct4.ItemsSource = ConnectOdb.conObj.Педагоги.Where(x => x.ФИО.StartsWith(TBoxSez.Text) || x.ФИО.StartsWith(TBoxSez.Text)).ToList();
      //  }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (Visibility == Visibility.Visible)
            {
                РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Педагоги.ToList();
            }



        }

     

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct4.SelectedItems.Cast<Педагоги>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Педагоги.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Педагоги.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }



            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавитьпрепод((sender as Button).DataContext as Педагоги));
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
            ICollectionView cv = CollectionViewSource.GetDefaultView(GridSaleProduct4.ItemsSource);

            if (!string.IsNullOrEmpty(filterText))
            {

                cv.Filter = o =>
                {
                    Педагоги p = o as Педагоги;
                    return (p.ФИО.ToUpper().StartsWith(filterText.ToUpper()));
                };


            }
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            UpdateTours();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавитьпрепод(null));
        }

        private void GridSaleProduct4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ОтчетПреподаватель расписание1 = new ОтчетПреподаватель();
            расписание1.Show();
        }
    }
    }

