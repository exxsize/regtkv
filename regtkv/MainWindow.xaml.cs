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

namespace regtkv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Обработка нажатия кнопки зарегистрироваться
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {

            //Создание переменных
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            //Проверка длины логина
            if(login.Length < 5) 
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно!";
                textBoxLogin.Background = Brushes.DarkRed;
            }

            //Проверка длины пароля
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Это поле введено не корректно!";
                passBox.Background = Brushes.DarkRed;
            }

            //Проверка совпадения пароля
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Это поле введено не корректно!";
                passBox_2.Background = Brushes.DarkRed;
            }

            //Проверка почты
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно!";
                textBoxEmail.Background = Brushes.DarkRed;
            }

            //Если всё хорошо то всё хорошо
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Всё хорошо!");
            }
        }
    }
}
