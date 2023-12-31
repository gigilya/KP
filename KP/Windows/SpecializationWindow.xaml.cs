﻿using Infrastucture.Database;
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
    /// Логика взаимодействия для SpecializationWindow.xaml
    /// </summary>
    public partial class SpecializationWindow : Window
    {
        private SpecializationRepository _repository; 
        public SpecializationWindow()
        {
            InitializeComponent();
            _repository = new SpecializationRepository();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            TableSpecialization.ItemsSource = _repository.GetList();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.ShowDialog();
        }
    }
}
