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
using System.Windows.Threading;

namespace Расписание_занятий
{
    /// <summary>
    /// Логика взаимодействия для Расписание2.xaml
    /// </summary>
    public partial class Расписание2 : Page
    {
       
        private РасписаниеEntities _context = new РасписаниеEntities();
        public Расписание2()
        {
            InitializeComponent();
            
            GridSaleProduct.ItemsSource = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();
            GridSaleProduct1.ItemsSource = РасписаниеEntities.GetContext().Расписание_вторник.ToList();
            GridSaleProduct2.ItemsSource = РасписаниеEntities.GetContext().Расписание_среда.ToList();
            GridSaleProduct3.ItemsSource = РасписаниеEntities.GetContext().Расписание_четверг.ToList();
            GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Расписание_пятница.ToList();

            Педагоги поступление = new Педагоги();
            // Расписание_вторник поступление1 = new Расписание_вторник();
            // Расписание_среда поступление2 = new Расписание_среда();
            // Расписание_четверг поступление3 = new Расписание_четверг();
            //Расписание_пятница поступление4 = new Расписание_пятница();

            //  КлассПрепод.ID_Группы = поступление.ID_Группы;
            //   Вторник.ID_Вторник = поступление.ID_Группы;
            //   Среда.ID_Среда = поступление.ID_Группы;
            //  Четверг.ID_Четверг = поступление.ID_Группы;
            //  Пятница.ID_Пятница = поступление.ID_Группы;


            CmbxProduct.DisplayMemberPath = "ФИО";
            CmbxProduct.SelectedValuePath = "ID_Педагога";
            CmbxProduct.ItemsSource = ConnectOdb.conObj.Педагоги.ToList();

            GridSaleProduct.IsReadOnly = true;

            GridSaleProduct.ItemsSource = ConnectOdb.conObj.Расписание_понедельник.Where
            (x => x.ID_Педагога == КлассПрепод.ID_Педагога).ToList();

             GridSaleProduct1.ItemsSource = ConnectOdb.conObj.Расписание_вторник.Where
            (x => x.ID_Педагога == КлассПрепод.ID_Педагога).ToList();

            GridSaleProduct2.ItemsSource = ConnectOdb.conObj.Расписание_среда.Where
                (x => x.ID_Педагога == КлассПрепод.ID_Педагога).ToList();

            GridSaleProduct3.ItemsSource = ConnectOdb.conObj.Расписание_четверг.Where
          (x => x.ID_Педагога == КлассПрепод.ID_Педагога).ToList();

          GridSaleProduct4.ItemsSource = ConnectOdb.conObj.Расписание_пятница.Where
           (x => x.ID_Педагога == КлассПрепод.ID_Педагога).ToList();

          
           
           
            
            var currentTours = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();
            var currentTours1 = РасписаниеEntities.GetContext().Расписание_вторник.ToList();
            var currentTours2 = РасписаниеEntities.GetContext().Расписание_среда.ToList();
            var currentTours3 = РасписаниеEntities.GetContext().Расписание_четверг.ToList();
            var currentTours4 = РасписаниеEntities.GetContext().Расписание_пятница.ToList();
            GridSaleProduct.ItemsSource = currentTours;
            GridSaleProduct1.ItemsSource = currentTours1;
            GridSaleProduct2.ItemsSource = currentTours2;
            GridSaleProduct3.ItemsSource = currentTours3;
            GridSaleProduct4.ItemsSource = currentTours4;


        }
       
       

        private void UpdateTours()

        {
            
            var currentTours = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();
            var currentTours1 = РасписаниеEntities.GetContext().Расписание_вторник.ToList();
            var currentTours2 = РасписаниеEntities.GetContext().Расписание_среда.ToList();
            var currentTours3 = РасписаниеEntities.GetContext().Расписание_четверг.ToList();
            var currentTours4 = РасписаниеEntities.GetContext().Расписание_пятница.ToList();
               }

        private void CmbxProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            GridSaleProduct.ItemsSource = null;
            int SelectProduct = Convert.ToInt32(CmbxProduct.SelectedValue);
           GridSaleProduct.ItemsSource = ConnectOdb.conObj.Расписание_понедельник.Where
             (x => x.ID_Педагога == SelectProduct).ToList();

           GridSaleProduct1.ItemsSource = ConnectOdb.conObj.Расписание_вторник.Where
              (x => x.ID_Педагога == SelectProduct).ToList();

           GridSaleProduct2.ItemsSource = ConnectOdb.conObj.Расписание_среда.Where
                (x => x.ID_Педагога == SelectProduct).ToList();

            GridSaleProduct3.ItemsSource = ConnectOdb.conObj.Расписание_четверг.Where
                (x => x.ID_Педагога == SelectProduct).ToList();

            GridSaleProduct4.ItemsSource = ConnectOdb.conObj.Расписание_пятница.Where
                 (x => x.ID_Педагога == SelectProduct).ToList();
            GridSaleProduct.SelectedIndex = 0;
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (Visibility == Visibility.Visible)
            {
                РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridSaleProduct.ItemsSource = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();

              РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridSaleProduct1.ItemsSource = РасписаниеEntities.GetContext().Расписание_вторник.ToList();


                РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridSaleProduct2.ItemsSource = РасписаниеEntities.GetContext().Расписание_среда.ToList();


                РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
               GridSaleProduct3.ItemsSource = РасписаниеEntities.GetContext().Расписание_четверг.ToList();


                 РасписаниеEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
               GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Расписание_пятница.ToList();

            }

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавитьпон(null));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct.SelectedItems.Cast<Расписание_понедельник>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Расписание_понедельник.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct.ItemsSource = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
            

        
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Редактированиепон((sender as Button).DataContext as Расписание_понедельник));
        }
        private void BtnEdit1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Редвторник((sender as Button).DataContext as Расписание_вторник));
        }
        private void BtnEdit2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Редсреда((sender as Button).DataContext as Расписание_среда));
        }
        private void BtnEdit3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new редчетверг((sender as Button).DataContext as Расписание_четверг));
        }
        private void BtnEdit4_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new редпятница((sender as Button).DataContext as Расписание_пятница));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавитьвторник(null));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавить_среду(null));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавить_четверг(null));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Добавитьпятницу(null));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct1.SelectedItems.Cast<Расписание_вторник>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Расписание_вторник.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct1.ItemsSource = РасписаниеEntities.GetContext().Расписание_вторник.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct2.SelectedItems.Cast<Расписание_среда>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Расписание_среда.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct2.ItemsSource = РасписаниеEntities.GetContext().Расписание_среда.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct3.SelectedItems.Cast<Расписание_четверг>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Расписание_четверг.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct3.ItemsSource = РасписаниеEntities.GetContext().Расписание_четверг.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var hotelFor = GridSaleProduct4.SelectedItems.Cast<Расписание_пятница>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие{hotelFor.Count()} элементов?", " Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    РасписаниеEntities.GetContext().Расписание_пятница.RemoveRange(hotelFor);
                    РасписаниеEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Расписание_пятница.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }
        public void UpdateData(object sender, object e)
        {
            // var HistoryProdyct = ConnectOdb.conObj.Расписание_понедельник.ToList();
            //GridSaleProduct.ItemsSource = HistoryProdyct;
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {

            DispatcherTimer timer = new DispatcherTimer();
            GridSaleProduct.ItemsSource = ConnectOdb.conObj.Расписание_понедельник.ToList();
            GridSaleProduct1.ItemsSource = ConnectOdb.conObj.Расписание_вторник.ToList();
            GridSaleProduct2.ItemsSource = ConnectOdb.conObj.Расписание_среда.ToList();
            GridSaleProduct3.ItemsSource = ConnectOdb.conObj.Расписание_четверг.ToList();
            GridSaleProduct4.ItemsSource = ConnectOdb.conObj.Расписание_пятница.ToList();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
            GridSaleProduct.ItemsSource = РасписаниеEntities.GetContext().Расписание_понедельник.ToList();
            GridSaleProduct1.ItemsSource = РасписаниеEntities.GetContext().Расписание_вторник.ToList();
            GridSaleProduct2.ItemsSource = РасписаниеEntities.GetContext().Расписание_среда.ToList();
            GridSaleProduct3.ItemsSource = РасписаниеEntities.GetContext().Расписание_четверг.ToList();
            GridSaleProduct4.ItemsSource = РасписаниеEntities.GetContext().Расписание_пятница.ToList();


            GridSaleProduct.IsReadOnly = true;
            GridSaleProduct1.IsReadOnly = true;
            GridSaleProduct2.IsReadOnly = true;
            GridSaleProduct3.IsReadOnly = true;
            GridSaleProduct4.IsReadOnly = true;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ОтчетРасписание расписание1 = new ОтчетРасписание();
            расписание1.Show();
        }
    }
}
