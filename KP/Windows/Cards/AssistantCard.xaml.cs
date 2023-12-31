﻿using System;
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

namespace StomatologyProject.Windows.Cards
{
    /// <summary>
    /// Логика взаимодействия для AssistantCard.xaml
    /// </summary>
    public partial class AssistantCard : Window
    {
        public AssistantCard()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            AssistantWindow assistantWindow = new AssistantWindow();
            this.Close();
            assistantWindow.ShowDialog();
        }
    }
}
