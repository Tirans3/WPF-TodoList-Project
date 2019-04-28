using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    class TodoList
    {
        readonly  List<Task> todo;

        public TodoList()
        {
            todo = new List<Task>();
        }

        public void Add(Task task)
        {
            todo.Add(task);
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
    }
}
