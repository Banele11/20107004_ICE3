using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    class ToDo
    {
        //public string description;
        public ToDo(string description, DateTime date)
        {
            Description = description;
            Date = date;
//            Priority = priority;
        }

        public string Description { get; set; }
        public DateTime Date { get; set; }
 //       public string Priority { get; set; }

    }
}
