using Infrastucture.Database;
using Infrastucture.ViewModels;
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
    /// Логика взаимодействия для ProcedureWindow.xaml
    /// </summary>
    public partial class ProcedureWindow : Window
    {
        private ProcedureRepository _repository;
        public ProcedureWindow()
        {
            InitializeComponent();
            _repository = new ProcedureRepository();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            TableProcedure.ItemsSource = _repository.GetList();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.ShowDialog();
        }
    }
}
