using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;

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

        public bool Remove(T t)
        {
          return  todo.Remove(t);
        }

        public void RemoveAt(int i)
        {
            todo.RemoveAt(i);
        }

        public virtual int RemoveAll(Predicate<T> match) { return default(int); }

        public virtual void CompleteAll(Predicate<T> match) { }

        public abstract List<T> All();

        public abstract List<T> Active();

        public abstract List<T> Completed();

        public abstract void ClearCompleted();

        public abstract bool Complete(T t) ;

       

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
