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
            string newItem = txtNewToDo.Text.Trim();
            if (!String.IsNullOrWhiteSpace(newItem))
            {
                //use contains to check if item is already in Items collection
                if (itemIsInList(clsToDo.Items, newItem))
                {
                    MessageBox.Show("You already added that item", "Error");
                }
                else
                {
                    //Use Add to new item to end of the Items collection
                    clsToDo.Items.Add(newItem);
                    txtNewToDo.Text = "";
                }
            }
            //no else, just ignore empty input
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Make new list
            List<string> doneItems = new List<string>();
            //Copy all checked items to new List
            foreach (string item in clsToDo.CheckedItems)
            {
                doneItems.Add(item);
            }
            //For each string in doneItems list, remove from clsToDo.Items
            //Add to lstDone.items
            foreach (string item in doneItems)
            {
                clsToDo.Items.Remove(item); //Remove by value
                lstDone.Items.Add(item);
            }
        }
        private bool itemIsInList(CheckedListBox.ObjectCollection items, string newItem)
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
