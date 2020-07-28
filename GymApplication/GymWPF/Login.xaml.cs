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
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
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
                    errormessage.Text = "Welcome to Alex's Fitness App";
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

        //    else
        //    {
        //        string email = TextBoxUsername.Text;
        //        string password = passwordBox.Password;
        //        SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("Select * from Registration where Email='" + email + "'  and password='" + password + "'", con);
        //        cmd.CommandType = CommandType.Text;
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        adapter.SelectCommand = cmd;
        //        DataSet dataSet = new DataSet();
        //        adapter.Fill(dataSet);
        //        if (dataSet.Tables[0].Rows.Count > 0)
        //        {
        //            string username = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();
        //            welcome.TextBlockName.Text = username;//Sending value from one form to another form.  
        //            welcome.Show();
        //            Close();
        //        }
        //        else
        //        {
        //            errormessage.Text = "Sorry! Please enter existing emailid/password.";
        //        }
        //        con.Close();
