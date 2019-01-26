using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddToListview();
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            // Get the total count of the desired civs to randomize from
            int totalCivCount = this.listBox1.Items.Count;
            int randomIndex = this.m_random.Next(0, totalCivCount);

            this.textBox1.Text = this.listBox1.Items[randomIndex].ToString();
        }


        /** <summary>
         * Remove the item at index from listboxInput and add that item to listboxOutput.
         * </summary>
         * */
        private void RemoveAndAdd(int index, ListBox listboxInput, ListBox listboxOutput)
        {
            // Check if index is null
            if (index >= 0)
            {
                Object selectedItem = listboxInput.Items[index];
                // Remove the item from the listbox input
                listboxInput.Items.RemoveAt(index);
                // Add the item to listbox output 
                listboxOutput.Items.Add(selectedItem);
            }
        }


        private void excludeButton_Click(object sender, EventArgs e)
        {
            // Get the selected index of the selected value in listBox1
            int indexOfSelectedCiv = this.listBox1.SelectedIndex;

            // If there is a selected civ, i.e. it is not null then the index will not be negative 1
            if (indexOfSelectedCiv >= 0)
            {
                this.RemoveAndAdd(indexOfSelectedCiv, this.listBox1, this.listBox2);
            }
        }


        private void includeButton_Click(object sender, EventArgs e)
        {
            // Get the selected index of the selected value in listBox1
            int indexOfSelectedCiv = this.listBox2.SelectedIndex;

            // If there is a selected civ, i.e. it is not null then the index will not be negative 1
            if (indexOfSelectedCiv >= 0)
            {
                this.RemoveAndAdd(indexOfSelectedCiv, this.listBox2, this.listBox1);
            }
        }
    }
}
