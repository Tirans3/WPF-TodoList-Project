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

        //private void Inputtext_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        if (inputtext.Text == null) return;

        //        _List.Add(inputtext.Text);

        //        inputtext.Clear();
        //    }
        //}


    }
}
