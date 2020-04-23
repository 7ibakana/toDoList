using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            //Remove any spaces start and end of string
            string todoText = txtNewToDo.Text;
            bool urgent = chkUrgent.Checked;
            if (!String.IsNullOrWhiteSpace(todoText))
            {
                //Create new toDo object using a constructor
                ToDo toDoItem = new ToDo(todoText, urbgent);
                if (!ToDoItemInList(toDoItem))
                {
                    clsToDo.Items.Add(toDoItem);
                txtNewToDo.Text = ""; //Clear text
                }

            else
            {
                MessageBox.Show("You already added that", "Duplicate");
            }
        }
    }
    private bool ToDoItemInList(ToDo toDoItem)
    {
        foreach (ToDo listItem in clsToDo.Items)
        {
            if (toDoItem.Text.ToUpper() == listItem.Text.ToUpper())
        }
    }
    //If the end of the loop is reached without returning,
    //an item with the same text is not in the list. Return false
    return false;
    private void btnDelete_Click(object sender, EventArgs e)
        {
            //Make new list
            List<ToDo> doneItems = new List<ToDo>();
            //Copy all checked items to new List
            foreach (ToDo item in clsToDo.CheckedItems)
            {
                doneItems.Add(item);
            }
            //For each string in doneItems list, remove from clsToDo.Items
            //Add to lstDone.items
            foreach (ToDo item in doneItems)
            {
                clsToDo.Items.Remove(item); //Remove by value
                lstDone.Items.Add(item);
            }
        }
        private bool itemIsInList(CheckedListBox.ObjectCollection items, string newItem) //ItemIsInList validation
        {
            foreach (string item in items)
            {
                if (item.ToUpper() == newItem.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
