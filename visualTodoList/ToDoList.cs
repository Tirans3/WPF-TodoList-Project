using System;
using System.Collections;
using System.Collections.Generic;
namespace visualTodoList
{
    abstract class ToDoList<T> : IEnumerable<T>
    {
        protected List<T> todo;

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

        public abstract int RemoveAll(Predicate<T> match);

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
