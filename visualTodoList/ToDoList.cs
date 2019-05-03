using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
namespace visualTodoList
{
  abstract  class ToDoList<T>:IEnumerable<T>
    {
          List<T> todo;

        public int Count { get => todo.Count; }

        public ToDoList()
        {
            todo = new List<T>();
        }

        public void Add(T t)
        {
            todo.Add(t);
        }


        public void Remove(T t)
        {
            todo.Remove(t);
        }

        public void Remove(int i)
        {
            todo.RemoveAt(i);
        }

        public int RemoveAll(Predicate<T> match)
        {
            return todo.RemoveAll(match);
        }

        public abstract ToDoList<T> Active();

        public abstract ToDoList<T> Completed();

        public abstract void Complete(int i);

        public abstract void CompleteAll(Predicate<T> match);

        public IEnumerator GetEnumerator()
        {
            return todo.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return todo.GetEnumerator();
        }
    }
}
