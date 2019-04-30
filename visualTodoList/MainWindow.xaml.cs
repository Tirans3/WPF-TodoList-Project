﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace visualTodoList
{

    public partial class MainWindow : Window
    {
        ToDoList _List;

        public MainWindow()
        {
            InitializeComponent();
            _List = new ToDoList();
        }

        private void inputtext_KeyDown(object sender, KeyEventArgs e)
        {
            string temp = inputtext.Text;

            if (e.Key == Key.Enter)
            {
                if (temp == string.Empty) return;

                _List.Add(inputtext.Text);

                items.Content = _List.Count.ToString();

                CheckBox c = new CheckBox
                {
                    Content = temp,
                    FontSize = 16,

                };

                _ComboBox.Items.Add(c);

                inputtext.Clear();

            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {

            foreach (CheckBox temp in _ComboBox.Items)
            {

                temp.Visibility = Visibility.Visible;

            }
            _ComboBox.IsDropDownOpen = true;
        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox temp in _ComboBox.Items)
            {

                temp.Visibility = Visibility.Visible;

            }


            foreach (CheckBox temp in _ComboBox.Items)
            {
                if (temp.IsChecked == true)
                {
                    temp.Visibility = Visibility.Collapsed;

                }
            }

            _ComboBox.IsDropDownOpen = true;


        }

        private void Completed_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox temp in _ComboBox.Items)
            {

                temp.Visibility = Visibility.Visible;

            }

            foreach (CheckBox temp in _ComboBox.Items)
            {
                if (temp.IsChecked == false)
                {
                    temp.Visibility = Visibility.Collapsed;

                }
            }

            _ComboBox.IsDropDownOpen = true;
        }

        private void Clear_Completed_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < _List.Count - 1; i++)
            {
                if (((CheckBox)_ComboBox.Items[i]).IsChecked == true)
                {
                    _List.Remove(i);
                    _ComboBox.Items.RemoveAt(i);
                }
            }

        }
    }

}