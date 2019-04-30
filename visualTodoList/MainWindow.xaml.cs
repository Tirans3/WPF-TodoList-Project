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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        }
    }

}