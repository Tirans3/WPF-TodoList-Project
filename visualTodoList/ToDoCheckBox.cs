using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
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

    }
}
