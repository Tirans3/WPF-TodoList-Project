using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;

namespace visualTodoList
{
    class ToDoList:IEnumerable<Task>
    {
          List<Task> todo;

        public int Count { get => todo.Count; }

        public ToDoList()
        {
            todo = new List<Task>();
        }
      

        public void Add(Task task)
        {
            todo.Add(task);
        }

        public void Add(string str)
        {
            Add(new Task(str));
        }

        public ToDoList Active()
        {
            ToDoList temp = new ToDoList
            {
                todo = todo.FindAll(c => c.Completed == false)
            };

            return temp;
        }

        public ToDoList Completed()
        {
            ToDoList temp = new ToDoList
            {
                todo = todo.FindAll(c => c.Completed == true)
            };

            return temp;
        }

        public List<CheckBox> ToChecBox()
        {
            List<CheckBox> temp = new List<CheckBox>();

            foreach(var i in todo)
            {
                temp.Add(new CheckBox { IsChecked = i.Completed, Content = i.task });
            }

            return temp;
        }


        public void Remove(Task task)
        {
            todo.Remove(task);
        }

        public void Remove(int i)
        {
            todo.RemoveAt(i);
        }

        public int RemoveAll(Predicate<Task> match)
        {
            return todo.RemoveAll(match);
        }

        public void Complete(int i)
        {
            todo[i].Completed = true;
        }

        public void CompleteAll(Predicate<Task> match)
        {
            for (int i = 0; i < todo.Count; i++)
            {

                if (match(todo[i]) == true)
                {
                    todo[i].Completed = true;
                }

            }
        }

        public IEnumerator GetEnumerator()
        {
            return todo.GetEnumerator();
        }

        IEnumerator<Task> IEnumerable<Task>.GetEnumerator()
        {
            return todo.GetEnumerator();
        }
    }
}
