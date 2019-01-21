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
            int totalCivCount = this.listOfExpansionCivs.Length;
            int randomIndex = this.m_random.Next(0, totalCivCount);

            this.textBox1.Text = this.listOfExpansionCivs[randomIndex];
        }
    }
}
