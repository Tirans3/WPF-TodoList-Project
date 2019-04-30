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
                //_list.Items.Add(c);
                _ComboBox.Items.Add(c);

                inputtext.Clear();

            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            _ComboBox.IsDropDownOpen = true;
        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {
            _list.SelectionMode = SelectionMode.Multiple;
            foreach (CheckBox temp in _ComboBox.ItemsSource)
            {
                if (temp.IsChecked == false)
                {
                    CheckBox temps = temp;
                    
                    
                     
                }
            }


            //for (int i = 0; i < _List.Count;i++) 
            //{
            //    if(((CheckBox)_ComboBox.Items[i]).IsChecked==false)
            //    {
            //        CheckBox temp = new CheckBox
            //        {
            //            Content = ((CheckBox)_ComboBox.Items[i]).Content,
            //            FontSize = 20,
            //        };

            //             tempCombo.Items.Add(temp);
            //    }
            //}

            tempCombo.IsDropDownOpen = true;
        }
    }

}