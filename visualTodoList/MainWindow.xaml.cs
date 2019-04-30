using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace visualTodoList
{

    public partial class MainWindow : Window
    {
        ToDoList _List;

        List<CheckBox> checkBoxes;

        public MainWindow()
        {
            InitializeComponent();

            _List = new ToDoList();

            checkBoxes = new List<CheckBox>();
        }

        private void inputtext_KeyDown(object sender, KeyEventArgs e)
        {
            string temp = inputtext.Text;

            if (e.Key == Key.Enter)
            {
                if (temp == string.Empty) return;

                CheckBox c = new CheckBox
                {
                    Content = temp,
                    FontSize = 16,

                };

                checkBoxes.Add(c);

                items.Content = checkBoxes.Count.ToString();

                inputtext.Clear();

            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes;
            _ComboBox.IsDropDownOpen = true;
            _ComboBox.Items.Refresh();

        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes.FindAll(CheckBoxs => CheckBoxs.IsChecked == false);
            _ComboBox.IsDropDownOpen = true;
            _ComboBox.Items.Refresh();

        }

        private void Completed_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes.FindAll(CheckBoxs => CheckBoxs.IsChecked == true);
            _ComboBox.IsDropDownOpen = true;
            _ComboBox.Items.Refresh();

        }

        private void Clear_Completed_Click(object sender, RoutedEventArgs e)
        {
            checkBoxes = checkBoxes.FindAll(item => item.IsChecked == false);
            items.Content = checkBoxes.Count.ToString();
        }
    }

}