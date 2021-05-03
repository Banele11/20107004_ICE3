using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class FrmToDo : Form
    {
        public FrmToDo()
        {
            InitializeComponent();
        }

        private void FrmToDo_Load(object sender, EventArgs e)
        {
            DoList.doList = TextFileHandler.ReadFile();
            loadListBox();
        }

        public void loadListBox()
        {
            lstToDo.Items.Clear();
            foreach (ToDo td in DoList.doList)
            {
                lstToDo.Items.Add(td.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txbItem.Text;
            DateTime date = DateTime.Now;

            ToDo td = new ToDo(description, date);

            try
            {
                StreamWriter write = new StreamWriter("ToDoList.txt", true);
                write.WriteLine(td.description + ", " + td.date);
                write.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
