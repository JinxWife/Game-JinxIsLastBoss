using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Shop : Form
    {
        public int m;
        public int wea;
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            Shopmoney.Text = m.ToString();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buyArms1_Click(object sender, EventArgs e)
        {
            

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {        
            if (rbtBuy1.Checked)
                wea = 0;
            if (rbtBuy2.Checked)
                wea = 1;
            if (rbtBuy3.Checked)
                wea = 2;
            if (rbtBuy4.Checked)
                wea = 3;
            if (rbtBuy5.Checked)
                wea = 4;
            if (rbtBuy6.Checked)
                wea = 5;
            if (rbtBuy7.Checked)
                wea = 6;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void rbtBuy1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
