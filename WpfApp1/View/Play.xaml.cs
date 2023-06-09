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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для Play.xaml
    /// </summary>
    public partial class Play : Page
    {
        public Play()
        {
            InitializeComponent();
            DataContext = new MinesweeperViewModel();
        }
        private void MouseRightButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as MinesweeperViewModel;
            if (viewModel != null)
            {
                var button = e.Source as Button;
                if (button != null)
                {
                    var cell = button.Tag as Cell;
                    viewModel.CellRightClickCommand.Execute(cell);
                }
            }
        }
    }
}
