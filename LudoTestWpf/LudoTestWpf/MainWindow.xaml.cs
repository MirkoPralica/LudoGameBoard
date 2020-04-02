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

namespace LudoTestWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            Grid grid = (Grid)Content;

            for (int i = 0; i < 11; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.RowDefinitions.Add(new RowDefinition());

            }

            for (int row = 0; row < 11; row++)
            {
                for (int column = 0; column < 11; column++)
                {
                    Button button = new Button
                    {
                        Content =  row + "." + column,
                    };
                    if(row == 1 && column == 1 || (row == 2 && column == 2)|| (row == 1 && column == 2)||(row == 2 && column == 1)|| (row == 4 && column == 0) ||(row == 5 && column >= 0 && column < 5))
                    {
                        button.Background = Brushes.Blue;
                    }
                    else if(row == 1 && column == 8||(row == 1 && column == 9)||(row == 2 && column == 8)||(row == 2 && column == 9)|| (row == 0 && column == 6) || (row < 5 && column == 5))
                    {
                        button.Background = Brushes.Red;
                    }
                    else if (row == 8 && column == 1 || (row == 8 && column == 2) || (row == 9 && column == 1) || (row == 9 && column == 2)|| (row == 10 && column == 4) || (row < 11 && row > 5 && column == 5))
                    {
                        button.Background = Brushes.Green;
                    }
                    else if (row == 8 && column == 8 || (row == 8 && column == 9) || (row == 9 && column == 8) || (row == 9 && column == 9)|| (row == 6 && column == 10) || (row == 5 && column > 5))
                    {
                        button.Background = Brushes.Yellow;
                    }
                    grid.Children.Add(button);
                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, column);

                    button.Click += HandleButtonClick;

                }
            }
        }

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("You clicked " + button.Content);
        }
    }
}

