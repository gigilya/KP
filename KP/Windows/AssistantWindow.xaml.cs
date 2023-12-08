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
    /// Логика взаимодействия для AssistanWindow.xaml
    /// </summary>
    public partial class AssistantWindow : Window
    {
        private AssistantRepository _repository;
        public AssistantWindow()
        {
            InitializeComponent();
            _repository = new AssistantRepository();
            TableAssistant.ItemsSource = _repository.GetList();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.ShowDialog();
        }
    }
}