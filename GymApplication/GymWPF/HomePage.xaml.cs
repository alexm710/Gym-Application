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
        private UpdateExercise _updateExercise = new UpdateExercise();
        private CRUDManager _trainingProgram = new CRUDManager();
        public HomePage()
        {
            InitializeComponent();
            PopulateName();
            PopulateExercises();

            int count = ListBoxDailyGymPlan.SelectedItems.Count;
            if (count < 3)
            {
               
            }
        }

        private void ButtonAddExercise_Click(object sender, RoutedEventArgs e)
        {
            AddExercise addExercise = new AddExercise();
            addExercise.ShowDialog();
            PopulateExercises();
            int count = ListBoxDailyGymPlan.SelectedItems.Count;
            if (count < 4)
            {
                txtBoxContent.Text = "hello";              
            }
        }


        private void PopulateName()
        {
            txtBoxName.Text = CurrentUser.FirstName;

        }

        private void ButtonDeleteExercise_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxDailyGymPlan.SelectedItem != null)
            {
                TrainingProgram trainingProgram = ListBoxDailyGymPlan.SelectedItem as TrainingProgram;
                _trainingProgram.Delete(trainingProgram.TrainingId);
                MessageBox.Show("Your exercise has been deleted succesfully.");
                PopulateExercises();
            }
        }
        private void PopulateExercises()
        {
            ListBoxDailyGymPlan.ItemsSource = _trainingProgram.GetExercise();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            string userInput = txtBoxName.Text;
            txtBoxName.Text = CurrentUser.FirstName;
            PopulateName();
        }

        private void ButtonUpdateExercise_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxDailyGymPlan.SelectedItem != null)
            {

                TrainingProgram trainingProgram = ListBoxDailyGymPlan.SelectedItem as TrainingProgram;
                _updateExercise.ShowDialog();
                //_trainingProgram.Update(trainingProgram.TrainingId, trainingProgram.TrainingType, trainingProgram.Difficulty, trainingProgram.DailyPlan);
                PopulateName();

            }
        }

        private void ListBoxWeeklyGymPlan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
