using GymController;
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
using GymModel;

namespace GymWPF
{
    /// <summary>
    /// Interaction logic for AddExercise.xaml
    /// </summary>
    public partial class UpdateExercise : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public UpdateExercise()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

            string difficulty = DifficultyBox.Text;
            string training = TrainingBox.Text;
            string routine = RoutineBox.Text;
            _crudManager.Update (training, routine, difficulty);
            MessageBox.Show("Your exercise has been updated succesfully.");
            this.Close();
        }
    }
}