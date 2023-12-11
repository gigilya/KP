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
using System.Windows.Shapes;

namespace StomatologyProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void DoctorButton_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow doctorWindow = new DoctorWindow();
            this.Close();
            doctorWindow.ShowDialog();
        }

        private void AssistanButton_Click(object sender, RoutedEventArgs e)
        {
            AssistanWindow assistanWindow = new AssistanWindow();
            this.Close();
            assistanWindow.ShowDialog();
        }

        private void PatientButton_Click(object sender, RoutedEventArgs e)
        {
            PatientWindow patientWindow = new PatientWindow();
            this.Close();
            patientWindow.ShowDialog();
        }

        private void ProcedureButton_Click(object sender, RoutedEventArgs e)
        {
            ProcedureWindow procedureWindow = new ProcedureWindow();
            this.Close();
            procedureWindow.ShowDialog();
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            EntryWindow entryWindow = new EntryWindow();
            this.Close();
            entryWindow.ShowDialog();
        }
    }
}
