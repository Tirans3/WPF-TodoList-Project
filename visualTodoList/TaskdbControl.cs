using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualTodoList
{
    class TaskdbControl
    {
        public static void Add(TaskContext db,string str)
        {
            using (db)
            {
                db.Task.Add(new Task(str));
                db.SaveChanges();
            }

        }

        public static void RemoveCompleted(TaskContext db,IEnumerable<Task> taskrang)
        {
            using (db)
            {
                db.Task.RemoveRange(taskrang);
                db.SaveChanges();
            }
        }


    }
}
