using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace visualTodoList
{
    class ToDoCheckBox : ToDoList<CheckBox>
    {
        public override List<CheckBox> All()
        {
            return todo;
        }

        public override List<CheckBox> Active()
        {
            return todo.FindAll(i => !Complete(i));
        }

        public override List<CheckBox> Completed()
        {
            return todo.FindAll(i => Complete(i));
        }

        public override bool Complete(CheckBox t)
        {
            return (bool)t.IsChecked;
        }

        public override void ClearCompleted()
        {
            todo.RemoveAll(i=>Complete(i));

        }

        public void Add(KeyEventArgs e, TextBox box, string temp)
        {
            if (e.Key == Key.Enter)
            {
                if (temp == string.Empty) return;

                CheckBox c = new CheckBox
                {
                    Content = temp,

                    FontSize = 16,

                };
                
                todo.Add(c);

                box.Clear();

            }
        }

    }
}
