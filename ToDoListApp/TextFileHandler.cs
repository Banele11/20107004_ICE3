using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToDoListApp
{
    class TextFileHandler
    {
        public static List<ToDo> ReadFile()
        {
            string line;
            List<ToDo> tempList = new List<ToDo>();
            try
            {
                StreamReader read = new StreamReader("ToDoList.txt");
                while ((line = read.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(", ");

                    string desc = lineParts[0];

                    string date = lineParts[1];
                    string[] dateParts = date.Split('/'); ;
                    int year = Convert.ToInt32(dateParts[0]);
                    int month = Convert.ToInt32(dateParts[1]);
                    int day = Convert.ToInt32(dateParts[2]);

                    DateTime dt = new DateTime(year, month, day);

                    ToDo t = new ToDo(desc, dt);
                    tempList.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (tempList);
        }

        //public void WriteToFile()
        //{
        //    ToDo td = new ToDo(description, date);
        //    try
        //    {
        //        StreamWriter write = new StreamWriter("ToDoList.txt", true);
        //        write.WriteLine(td.description + ", " + td.date);
        //        write.Close();
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
