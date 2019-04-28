﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualTodoList
{
    class ToDoList
    {
            readonly List<Task> todo;

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