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
            todo.RemoveAll(i => Complete(i));

        }

        public static List<CheckBox> TaskToCheckBox(IEnumerable<Task> t)
        {
            List<CheckBox> temp = new List<CheckBox>();

            foreach (var i in t)
            {
                temp.Add(new CheckBox
                {
                    Content = i.task,

                    FontSize = 16,
                });
            }

            return temp;
        }

        static Task ToCheckBox(CheckBox t)
        {
            return new Task { Completed = (bool)t.IsChecked, task = t.Content.ToString() };
        }

        public static IEnumerable<Task> CheckBoxToTask(List<CheckBox> t)
        {
            List<Task> temp = new List<Task>();

            foreach (var i in t)
            {
                temp.Add(ToCheckBox(i));
            }

            return temp;
        }

        public static implicit operator ToDoCheckBox (List<Task> t)
        {
            return new ToDoCheckBox { todo =TaskToCheckBox(t) };
        }

        public void Add( TextBox box, Button but, string temp)
        {
                if (temp == string.Empty) return;

                CheckBox c = new CheckBox
                {
                    Content = temp,

                    FontSize = 16,
                };
                
                todo.Add(c);

                box.Clear();

               but.Content = todo.Count;

        }

    }
}
