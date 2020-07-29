using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using GymController;
using System.Security.Cryptography.X509Certificates;

namespace GymWPF
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private RegisterController _registerController = new RegisterController();
        public Register()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxUsername.Text = "";
            passwordBox.Password = "";
            textBoxEmail.Text = "";
            passwordBoxConfirm.Password = "";
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter your first name.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email address.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string firstname = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
                string username = textBoxUsername.Text;
                string password = passwordBox.Password;
                string email = textBoxEmail.Text;

                if (passwordBox.Password.Length == 0)
                {
                    errormessage.Text = "Enter password.";
                    passwordBox.Focus();
                }

                else if (passwordBoxConfirm.Password.Length == 0)
                {
                    errormessage.Text = "Please enter your confirm password.";
                    passwordBoxConfirm.Focus();
                }
                else if (passwordBox.Password != passwordBoxConfirm.Password)
                {
                    errormessage.Text = "Your password's must match!";
                    passwordBoxConfirm.Focus();
                }
                else
                {
                    //string encryptedPassword = _registerController.Encrypt(password);
                    _registerController.RegisterUser(firstname, lastname, username, email, password);
                    errormessage.Text = "You have registered successfully!";
                    Reset();
                }
            }
        }
    }
}