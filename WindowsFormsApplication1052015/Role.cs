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
    public partial class Role : Form
    {
        public int upexp;
        public string lv;
        public int exp;
        public int atk;
        public int oa;
        public string arms;
        public int money;

        public string[] itemName = new string[10];
        public int[] itemAtk = new int[10];      
        public int chooseWeaAtk;
        public int[] sellmoney = new int[7];
        public int[] sellmoneyX = new int[7];
        public Role()
        {
            InitializeComponent();                         
        }

        private void Role_Load(object sender, EventArgs e)
        {
            EXPbar.Maximum = upexp;
            EXPbar.Value = exp;
            RoleLV.Text = lv;
            RoleEXP.Text = exp.ToString() + "/" + upexp.ToString();
            RoleATK.Text = atk.ToString();
            RoleArms.Text = arms;
           // RoleArms.ForeColor = Color.Red;//武器顏色
            RoleMoney.Text = money.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.nowWea = arms;
            for (int i = 0; i < 10; i++)
            {              
                item.itemName[i] = itemName[i];
                item.itemAtk[i] = itemAtk[i];
            }
            if (item.ShowDialog() == DialogResult.OK)
            {
                chooseWeaAtk = item.chooseAtk;
                arms = item.choose;
                atk = oa + chooseWeaAtk;
                RoleATK.Text = atk.ToString();
                RoleArms.Text = arms;
            }
            else if(item.sellWea==true)
            {
               
                int count = 0;
                for (int a = 0; a < 10; a++)
                {
                    if (item.sell[a] == 1)
                    {
                        if (itemName[a] == "新手劍")
                            money += 20;
                        if (itemName[a] == "銀劍")
                            money += sellmoney[0];
                        if (itemName[a] == "紅雪左文字")
                            money += sellmoney[1];
                        if (itemName[a] == "村正-妖刀")
                            money += sellmoney[2];
                        if (itemName[a] == "龍影劍")
                            money += sellmoney[3];
                        if (itemName[a] == "軒轅劍")
                            money += sellmoney[4];
                        if (itemName[a] == "殺生弒魂")
                            money += sellmoney[5];
                        if (itemName[a] == "上帝武器")
                            money += sellmoney[6];
                        if (itemName[a] == "女皇彎刀")
                            money += sellmoneyX[0];
                        RoleMoney.Text = money.ToString();
                        itemName[a] = null;
                        itemAtk[a] = 0;
                        
                    }
                }               
                for (int i = 0; i < 9; i++)
                {
                    if (itemName[i] == null)
                    {
                        for (int j = i; j < 9; j++)
                        {
                            itemName[j] = itemName[j + 1];
                            itemAtk[j] = itemAtk[j + 1];
                        }
                    }
                }                            
                for (int j = 0; j < 10; j++)
                {
                    if (itemName[j] == null)
                    {
                        count++;
                    }                   
                }
                if (count == 10)
                {
                    arms = "無";
                    atk = oa;
                    RoleATK.Text = atk.ToString();
                    RoleArms.Text = arms;
                    chooseWeaAtk = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
