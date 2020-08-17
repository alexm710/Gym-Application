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
            PopulateExercises();
            PopulateName();
            PopulateUpdateExercise();
        }

        private void ButtonAddExercise_Click(object sender, RoutedEventArgs e)
        {

            AddExercise addExercise = new AddExercise();
            addExercise.Show();
            PopulateExercises();

            int count = ListBoxDailyGymPlan.Items.Count;
            if (count >= 1)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = "Good start!";
                ListBoxWeeklyGymPlan.Items.Add(itm);
            }
            if (count >= 2)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = "Keep going!";
                ListBoxWeeklyGymPlan.Items.Add(itm);
            }
            if (count >= 3)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = "You're nearly there!";
                ListBoxWeeklyGymPlan.Items.Add(itm);
            }
            if (count >= 4)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = "Congratulations on completing your weekly target!";
                ListBoxWeeklyGymPlan.Items.Add(itm);
            }
            if (count >= 5)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = "Now you're just showing off.";
                ListBoxWeeklyGymPlan.Items.Add(itm);
            }
        }

        private void PopulateName()
        {
            LabelUserName.Content = "Welcome " + CurrentUser.FirstName + "!";

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

        }

        private void ButtonUpdateExercise_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxDailyGymPlan.SelectedItem != null)
            {

                TrainingProgram trainingProgram = ListBoxDailyGymPlan.SelectedItem as TrainingProgram;
                _updateExercise.ShowDialog();
                PopulateUpdateExercise();
            }
        }

        private void PopulateUpdateExercise()
        {
            ListBoxDailyGymPlan.ItemsSource = _trainingProgram.GetExercise();
        }

        private void ListBoxWeeklyGymPlan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
