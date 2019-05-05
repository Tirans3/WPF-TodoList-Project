using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Data.Entity;
namespace visualTodoList
{

    public partial class MainWindow : Window
    {
        ToDoCheckBox checkBoxes;
        
        public MainWindow()
        {
            InitializeComponent();

           checkBoxes =TaskdbControl.DownloadData();

            itemsleft.Content = checkBoxes.Count;
            //Clear_Completed.IsEnabled = false;
        }

        private void Inputtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
              checkBoxes.Add(inputtext,itemsleft, inputtext.Text);

              TaskdbControl.Add( inputtext.Text);
                
            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes.All();

            _ComboBox.IsDropDownOpen = true;

            _ComboBox.Items.Refresh();
        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes.Active();

            _ComboBox.IsDropDownOpen = true;

        }

        private void Completed_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.ItemsSource = checkBoxes.Completed();

            _ComboBox.IsDropDownOpen = true;

        }

        private void Clear_Completed_Click(object sender, RoutedEventArgs e)
        {
            TaskdbControl.RemoveCompleted(ToDoCheckBox.CheckBoxToTask( checkBoxes.Completed()));

            checkBoxes.ClearCompleted();

            itemsleft.Content = checkBoxes.Count.ToString();
        }

    }

}