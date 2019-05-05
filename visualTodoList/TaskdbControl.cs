using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace visualTodoList
{
    class TaskdbControl
    {
      static TaskContext db;
       
        public static void Add(string str)
        {
            using (db = new TaskContext())
            {
                db.Task.Add(new Task(str));
                db.SaveChanges();
            }
        }

        public static void RemoveCompleted(IEnumerable<Task> taskrang)
        {
            using (db = new TaskContext())
            {
                db.Task.RemoveRange(taskrang);
                db.SaveChanges();
               
            }
        }

        public static List<Task> DownloadData()
        {
            using (db = new TaskContext())
            {
                return db.Task.ToList();

            }
        }

    }
}
