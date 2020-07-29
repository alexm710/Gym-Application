using GymController;
using GymModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GymWPF
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        private CRUDManager _trainingProgram = new CRUDManager();
        public HomePage()
        {
            InitializeComponent();

        }

        private void ButtonAddExercise_Click(object sender, RoutedEventArgs e)
        {
            string userInput = txtBoxName.Text;
            _trainingProgram.CreateTraining(userInput);
            MyTextBox.Clear();
            ListBoxBlogs.ItemsSource = _bm.ReadBlog();();
        }

        private void ButtonDeleteExercise_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
