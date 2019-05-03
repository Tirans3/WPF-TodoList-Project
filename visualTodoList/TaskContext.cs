using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace visualTodoList
{
    class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskContext() : base("DbConnection")
        {

        }
    }
}
