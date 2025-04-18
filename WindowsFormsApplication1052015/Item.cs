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
   
    public partial class Item : Form
    {
        public string[] itemName = new string[10];
        public int[] itemAtk = new int[10];
        public string choose;
        public int chooseAtk;
        public int[] sell=new int[10];
        public bool sellWea;
        public string nowWea;
        
        public Item()
        {
            InitializeComponent();
            for (int x = 0; x < 10; x++)
                sell[x] = 0;
        }
        private void Item_Load(object sender, EventArgs e)
        {
            btnWear.Enabled = false;
            btnSell.Enabled = false;
            if (nowWea == "無")
                btnOut.Enabled = false;
            sellWea = false;
            for (int i = 0; i < 10; i++)
            {
                if (itemName[i] != null)
                    clbxItem.Items.Add(itemName[i]);              
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int i in clbxItem.CheckedIndices)
                    clbxItem.SetItemCheckState(i, CheckState.Unchecked);              
            }
            int j = 0;
            for (int i = 0; i < clbxItem.Items.Count; i++)
            {
                if (!clbxItem.GetItemChecked(i))
                    j++;              
            }
            if (j == clbxItem.Items.Count - 1)
            {
                btnWear.Enabled = false;
                btnSell.Enabled = false;
            }
            else
            {
                btnWear.Enabled = true;
                btnSell.Enabled = true;
            }
        }

        private void clbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbxItem.Items.Count; i++)
            {
                if (clbxItem.GetItemChecked(i))
                {
                    choose = itemName[i];
                    chooseAtk = itemAtk[i];
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            choose = "無";
            chooseAtk = 0;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbxItem.Items.Count; i++)
            {
                if (clbxItem.GetItemChecked(i))
                {              
                    clbxItem.Items.Remove(itemName[i]);
                    if (clbxItem.Items.Count == 0)
                        btnWear.Enabled = false;
                    sell[i] = 1;
                    sellWea = true;
                    for (int j = 0; j < clbxItem.Items.Count; j++)
                    {
                        itemName[j] = itemName[j + 1];
                        itemAtk[j] = itemAtk[j + 1];
                    }
                }                
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
