using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualTodoList
{
    class Task
    {
        public string task { get; set; }

        public bool Completed { get; set; } = false;

        public Task(string task)
        {
            this.task = task;

        }
    }
}
