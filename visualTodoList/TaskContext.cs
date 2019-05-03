using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Controls;
namespace visualTodoList
{
    class TaskContext : DbContext
    {
        public DbSet<Task> Task { get; set; }

        public TaskContext() : base("DbConnection")
        {

        }
    }
}
