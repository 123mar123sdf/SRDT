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
    /// Логика взаимодействия для Добавить_среду.xaml
    /// </summary>
    public partial class Добавить_среду : Page
    {
        private Расписание_среда _Рас = new Расписание_среда();
        public Добавить_среду(Расписание_среда ремонт)
        {
            InitializeComponent();




            if (ComboBox1_Copy4.Text == "Младшая группа: художественный отдел")
            { textq.Visibility = Visibility.Visible; }
            if (ремонт != null)
                _Рас = ремонт;

            DataContext = _Рас;
            ComboBox1_Copy4.ItemsSource = РасписаниеEntities.GetContext().Объединения.ToList();

            ComboBox1_Copy3.ItemsSource = РасписаниеEntities.GetContext().Кабинеты.ToList();




        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_Рас.Объединения == null)
                errors.AppendLine("Выберите объединение");
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


            if (_Рас.ID_Среда == 0)
                РасписаниеEntities.GetContext().Расписание_среда.Add(_Рас);
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

        private void ComboBox1_Copy4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void ComboBox1_Copy2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void ComboBox1_Copy4_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1_Copy4.SelectedItem != null)
            {
                switch (ComboBox1_Copy4.SelectedIndex)
                {
                    case 0:
                        {
                            Педагог1.Visibility = Visibility.Visible;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Visible;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 1:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Visible;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Visible;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 2:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Visible;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Visible;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 3:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Visible;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Visible;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;

                    case 4:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Visible;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Visible;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 5:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Visible;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Visible;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 6:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Visible;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Visible;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 7:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Visible;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Visible;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 8:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Visible;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Visible;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;
                        }
                        break;
                    case 9:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Visible;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Visible;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 10:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Visible;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Visible;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 11:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Visible;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Visible;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 12:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Visible;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Visible;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 13:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Visible;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Visible;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 14:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Visible;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Visible;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 15:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Visible;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Visible;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 16:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Visible;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Visible;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 17:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Visible;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Visible;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 18:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Visible;
                            Педагог15.Visibility = Visibility.Hidden;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Visible;
                            Группа20.Visibility = Visibility.Hidden;

                        }
                        break;
                    case 19:
                        {
                            Педагог1.Visibility = Visibility.Hidden;
                            Педагог2.Visibility = Visibility.Hidden;
                            Педагог3.Visibility = Visibility.Hidden;
                            Педагог4.Visibility = Visibility.Hidden;
                            Педагог5.Visibility = Visibility.Hidden;
                            Педагог6.Visibility = Visibility.Hidden;
                            Педагог7.Visibility = Visibility.Hidden;
                            Педагог8.Visibility = Visibility.Hidden;
                            Педагог9.Visibility = Visibility.Hidden;
                            Педагог10.Visibility = Visibility.Hidden;
                            Педагог11.Visibility = Visibility.Hidden;
                            Педагог12.Visibility = Visibility.Hidden;
                            Педагог13.Visibility = Visibility.Hidden;
                            Педагог14.Visibility = Visibility.Hidden;
                            Педагог15.Visibility = Visibility.Visible;
                            Группа1.Visibility = Visibility.Hidden;
                            Группа2.Visibility = Visibility.Hidden;
                            Группа3.Visibility = Visibility.Hidden;
                            Группа4.Visibility = Visibility.Hidden;
                            Группа5.Visibility = Visibility.Hidden;
                            Группа6.Visibility = Visibility.Hidden;
                            Группа7.Visibility = Visibility.Hidden;
                            Группа8.Visibility = Visibility.Hidden;
                            Группа9.Visibility = Visibility.Hidden;
                            Группа10.Visibility = Visibility.Hidden;
                            Группа11.Visibility = Visibility.Hidden;
                            Группа12.Visibility = Visibility.Hidden;
                            Группа13.Visibility = Visibility.Hidden;
                            Группа14.Visibility = Visibility.Hidden;
                            Группа15.Visibility = Visibility.Hidden;
                            Группа16.Visibility = Visibility.Hidden;
                            Группа17.Visibility = Visibility.Hidden;
                            Группа18.Visibility = Visibility.Hidden;
                            Группа19.Visibility = Visibility.Hidden;
                            Группа20.Visibility = Visibility.Visible;

                        }
                        break;
                }
            }
        }

        private void Text_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Педагог1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог1.SelectedItem != null)
            {
                switch (Педагог1.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "1";
                        }
                        break;

                }
            }
        }
        private void Педагог2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог2.SelectedItem != null)
            {
                switch (Педагог2.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "2";
                        }
                        break;

                }
            }
        }
        private void Педагог3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог3.SelectedItem != null)
            {
                switch (Педагог3.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "3";
                        }
                        break;

                }
            }
        }
        private void Педагог4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог4.SelectedItem != null)
            {
                switch (Педагог4.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "4";
                        }
                        break;

                }
            }
        }
        private void Педагог5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог5.SelectedItem != null)
            {
                switch (Педагог5.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "5";
                        }
                        break;

                }
            }
        }
        private void Педагог6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог6.SelectedItem != null)
            {
                switch (Педагог6.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "6";
                        }
                        break;

                }
            }
        }
        private void Педагог7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог7.SelectedItem != null)
            {
                switch (Педагог7.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "7";
                        }
                        break;

                }
            }
        }
        private void Педагог8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог8.SelectedItem != null)
            {
                switch (Педагог8.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "8";
                        }
                        break;

                }
            }
        }
        private void Педагог9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог9.SelectedItem != null)
            {
                switch (Педагог9.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "9";
                        }
                        break;

                }
            }
        }
        private void Педагог10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог10.SelectedItem != null)
            {
                switch (Педагог10.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "10";
                        }
                        break;

                }
            }
        }
        private void Педагог11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог11.SelectedItem != null)
            {
                switch (Педагог11.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "11";
                        }
                        break;

                }
            }
        }
        private void Педагог12_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог12.SelectedItem != null)
            {
                switch (Педагог12.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "12";
                        }
                        break;

                }
            }
        }
        private void Педагог13_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог13.SelectedItem != null)
            {
                switch (Педагог13.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "13";
                        }
                        break;

                }
            }
        }
        private void Педагог14_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог14.SelectedItem != null)
            {
                switch (Педагог14.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "14";
                        }
                        break;

                }
            }
        }
        private void Педагог15_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Педагог15.SelectedItem != null)
            {
                switch (Педагог15.SelectedIndex)
                {
                    case 0:
                        {
                            textq.Text = "15";
                        }
                        break;

                }
            }

        }


        private void ComboBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                switch (ComboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            text.Text = "08:30-09:30";
                        }
                        break;
                    case 1:
                        {
                            text.Text = "09:45-10:45";

                        }
                        break;
                    case 2:
                        {
                            text.Text = "11:15-12:15";

                        }
                        break;
                    case 3:
                        {
                            text.Text = "12:25-13:25";

                        }
                        break;
                    case 4:
                        {
                            text.Text = "13:30-14:30";

                        }
                        break;
                    case 5:
                        {
                            text.Text = "14:40-15:40";

                        }
                        break;

                }
            }
        }

        private void Группа1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа1.SelectedItem != null)
            {
                switch (Группа1.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "1";
                        }
                        break;
                }
            }
        }
        private void Группа2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа2.SelectedItem != null)
            {
                switch (Группа2.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "2";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "3";
                        }
                        break;
                }
            }
        }
        private void Группа3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа3.SelectedItem != null)
            {
                switch (Группа3.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "4";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "5";
                        }
                        break;
                }
            }
        }
        private void Группа4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа4.SelectedItem != null)
            {
                switch (Группа4.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "6";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "7";
                        }
                        break;
                }
            }
        }
        private void Группа5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа5.SelectedItem != null)
            {
                switch (Группа5.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "8";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "9";
                        }
                        break;
                }
            }
        }
        private void Группа6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа6.SelectedItem != null)
            {
                switch (Группа6.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "10";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "13";
                        }
                        break;
                }
            }
        }
        private void Группа7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа7.SelectedItem != null)
            {
                switch (Группа7.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "14";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "15";
                        }
                        break;
                }
            }
        }
        private void Группа8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа8.SelectedItem != null)
            {
                switch (Группа8.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "16";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "17";
                        }
                        break;
                }
            }
        }
        private void Группа9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа9.SelectedItem != null)
            {
                switch (Группа9.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "18";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "19";
                        }
                        break;
                }
            }
        }
        private void Группа10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа10.SelectedItem != null)
            {
                switch (Группа10.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "20";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "21";
                        }
                        break;
                }
            }
        }
        private void Группа11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа11.SelectedItem != null)
            {
                switch (Группа11.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "22";
                        }
                        break;
                    case 1:
                        {
                            textp.Text = "23";
                        }
                        break;
                }
            }
        }
        private void Группа12_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа12.SelectedItem != null)
            {
                switch (Группа12.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "24";
                        }
                        break;
                }
            }
        }
        private void Группа13_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа13.SelectedItem != null)
            {
                switch (Группа13.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "25";
                        }
                        break;
                }
            }
        }
        private void Группа14_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа14.SelectedItem != null)
            {
                switch (Группа14.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "26";
                        }
                        break;
                }
            }
        }
        private void Группа15_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа15.SelectedItem != null)
            {
                switch (Группа15.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "27";
                        }
                        break;
                }
            }
        }
        private void Группа16_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа16.SelectedItem != null)
            {
                switch (Группа16.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "28";
                        }
                        break;
                }
            }
        }
        private void Группа17_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа17.SelectedItem != null)
            {
                switch (Группа17.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "29";
                        }
                        break;
                }
            }
        }
        private void Группа18_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа18.SelectedItem != null)
            {
                switch (Группа18.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "30";
                        }
                        break;
                }
            }
        }
        private void Группа19_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа19.SelectedItem != null)
            {
                switch (Группа19.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "31";
                        }
                        break;
                }
            }
        }
        private void Группа20_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Группа20.SelectedItem != null)
            {
                switch (Группа20.SelectedIndex)
                {
                    case 0:
                        {
                            textp.Text = "32";
                        }
                        break;
                }
            }

        }



        private void ComboBox1_Copy3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textq.Focus();
            textp.Focus();
            text.Focus();
        }
    }
}