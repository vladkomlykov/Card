using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Year.SelectedItem = "2000";
            Mounth.SelectedItem = "Январь";
        }
        
        private bool ContainsLetters(string input)
        {
            Regex regex = new Regex("[a-zA-Z]");
            return regex.IsMatch(input);
        }
        private bool ContainsNumbers(string input)
        {
            Regex regex = new Regex("[0-9]");
            return regex.IsMatch(input);
        }
        private bool NumCorrect() {
            
            if (!ContainsLetters(num.Text) && num.Text != null)
            {
                return true;
            }
            else { return false; }
        }
        private bool NameCorrect()
        {
            if(!ContainsNumbers(name.Text) && name.Text != null)
            {
               return true;
            } else { return false; }
        }
        private bool CvvCorrect()
        {
            if (!ContainsLetters(cvv.Text) && cvv.Text != null)
            {
                return true;
            }
            else { return false; }
        }
        private void pay_Click(object sender, RoutedEventArgs e)
        {

            if (NumCorrect() && NameCorrect() && CvvCorrect())
            {
                MessageBox.Show("Оплата прошла успешно");
            }
            else { MessageBox.Show("Что-то пошло не так. Проверьте имя(не должно содержать цифр), номер(не должен содержать букв) и CVV(не должно содержать букв)"); }
            
        }
    }
}
