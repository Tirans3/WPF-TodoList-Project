using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace visualTodoList
{

    public partial class MainWindow : Window
    {
        ToDoCheckBox checkBoxes;

        public MainWindow()
        {
            InitializeComponent();
            checkBoxes = new ToDoCheckBox();

            //Clear_Completed.IsEnabled = false;
        }

        private void Refrash(KeyEventArgs e, string temp)
        {
            if (e.Key == Key.Enter)
            {
                if (temp == string.Empty) return;

                CheckBox c = new CheckBox
                {
                    Content = temp,
                    FontSize = 16,

                };
                TaskContext db = new TaskContext();
                db.Tasks.Add(new Task(temp));
                db.SaveChanges();
                checkBoxes.Add(c);

                itemsleft.Content = checkBoxes.Count.ToString();

                inputtext.Clear();

            }
        }

        private void inputtext_KeyDown(object sender, KeyEventArgs e)
        {
            string temp = inputtext.Text;
            Refrash(e, temp);
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
             checkBoxes.ClearCompleted();

            itemsleft.Content = checkBoxes.Count.ToString();
        }

    }

}