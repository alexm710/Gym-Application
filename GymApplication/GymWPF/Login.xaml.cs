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
        public Login()
        {
            InitializeComponent();
        }

        //private void btnSubmit_Click(object sender, RoutedEventArgs e)
        //{
        //    if (TextBoxUsername.Text.Length == 0)
        //    {
        //        errormessage.Text = "Enter an email.";
        //        TextBoxUsername.Focus();
        //    }
        //    else if (!Regex.IsMatch(TextBoxUsername.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
        //    {
        //        errormessage.Text = "Enter a TextBoxUsername email.";
        //        TextBoxUsername.Select(0, TextBoxUsername.Text.Length);
        //        TextBoxUsername.Focus();
        //    }
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
            }
        }
