using rpgFighter.Items;
using rpgFighter.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpgFighter
{
    public partial class Form1 : Form
    {
        GameSpace.Arena World = new GameSpace.Arena();
        public Form1()
        {
            InitializeComponent();

            storageBindingSource
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                Person p = new Person(tbName.Text, cbAlliance.Checked, 100);
                rtb_console.Text += p.ToString() + Environment.NewLine;
                World.addPersonToArena(p);
            }
            else
            {
                MessageBox.Show("Please enter a name.");
            } 
            
            //Person Dan = new Person("Dan");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbCharList.Text = World.PrintPeople();
            rtb_console.AppendText(Environment.NewLine + "Printed Char List");
        }

        public void btItems_Click(object sender, EventArgs e)
        {
            string itemText = tbItemName.Text;
            int itemWeight = Int32.Parse(tbWeight.Text);
            int itemMaxCapacity = Int32.Parse(tbMaxCapacity.Text);
            int itemValue = Int32.Parse(tbValue.Text);
            string itemDescription = rtbItemDescription.Text;

            if (!string.IsNullOrEmpty(tbItemName.Text))
            {
                Equipment i = new Equipment(itemText, itemWeight, itemMaxCapacity, itemValue, itemDescription);




            }

        }
    }
}
