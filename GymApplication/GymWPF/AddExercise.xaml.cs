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
    /// Interaction logic for AddExercise.xaml
    /// </summary>
    public partial class AddExercise : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        private HomePage _homePage = new HomePage();
        public AddExercise()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            string difficulty = DifficultyBox.Text;
            string training = TrainingBox.Text;
            string routine = RoutineBox.Text;
            _crudManager.CreateTraining(CurrentUser.Id, training, routine, difficulty);
            MessageBox.Show("Your exercise has been added succesfully.");
            //PopulateExercises();
            this.Close();
            //FrameMain.Navigate(new HomePage());
            ////_crudManager.



        }
    }
}
