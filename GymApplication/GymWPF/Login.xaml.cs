using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GymController;

namespace GymWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private LoginController _loginController = new LoginController();
        private MainWindow _mainWindow;
        public Login(MainWindow mw)
        {
            InitializeComponent();
            _mainWindow = mw;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
            {
                errormessage.Text = "Please enter your username.";
                textBoxUsername.Focus();
            }
            else
            {
                string username = textBoxUsername.Text;
                string password = passwordBox.Password;
                if (_loginController.Login(username, password) == true)
                {
                    _loginController.Login(username, password);
                    Close();
                    HomePage homepage = new HomePage();
                    _mainWindow.Close();
                    homepage.Show();
                }
                else  
                errormessage.Text = "Please enter a valid username and password.";               
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
