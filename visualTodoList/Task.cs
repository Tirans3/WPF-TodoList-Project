﻿namespace visualTodoList
{
    class Task
    {
        public int Id { get; set; }

        public string task { get; set; }

        public bool Completed { get; set; } = false;

        public Task()
        {
        }

        public Task(string task)
        {
            this.task = task;

        }
    }

}
