using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Project__Menu_Strip_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
       
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure To Clearr !!","Alert !!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                textBox1.Clear();

            }


            
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a small app for write any thing you want \nthx for using our app :)");
           
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.SelectedText))
            {

                MessageBox.Show("Can't Copy Empty Field !!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                textBox1.Copy();


            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox1.Paste();
        }
    }
}
