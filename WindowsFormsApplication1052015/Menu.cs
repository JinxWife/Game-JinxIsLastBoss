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
    public partial class Menu : Form
    {
        class UP
        {
            public int[] upEXP = new int[101];
            public int n;
        }

        class roleStart
        {
            public int lv;
            public int exp;
            public int oriatk;
            public int atk;
            public int money;
            public string arms;
        }               
        class UseWea
        {
            public int atk;
          //  public int money;        
        }
        class weapon
        {
            public int[] atk = new int[7];
            public int[] money = new int[7];
            public string[] name = new string[7];
        }
        class SpecialWeapon
        {
            public int[] atk = new int[7];
            public int[] money = new int[7];
            public string[] name = new string[7];
        }
        Role role = new Role();
        UseWea uw = new UseWea();
        roleStart r = new roleStart();
        weapon w = new weapon();
        SpecialWeapon sw = new SpecialWeapon();
        UP u = new UP();
        public Menu()
        {
            InitializeComponent();          
            w.atk[0] = 7;
            w.money[0] = 500;   
            w.name[0] = "銀劍";
                   
            w.atk[1] = 13;
            w.money[1] = 1000;
            w.name[1] = "紅雪左文字";
                  
            w.atk[2] = 21;
            w.money[2] = 2000;
            w.name[2] = "村正-妖刀";
                     
            w.atk[3] = 37;
            w.money[3] = 5000;
            w.name[3] = "龍影劍";
                            
            w.atk[4] = 64;
            w.money[4] = 10000;
            w.name[4] = "軒轅劍";
                                   
            w.atk[5] = 100;
            w.money[5] = 20000;
            w.name[5] = "殺生弒魂";
                    
            w.atk[6] = 150;
            w.money[6] = 66666;
            w.name[6] = "上帝武器";

            sw.atk[0] = 140;
            sw.money[0]= 5000;
            sw.name[0] = "女皇彎刀";

            for (int i = 0; i < 7; i++)
            {
                role.sellmoney[i] = w.money[i] / 5;
                role.sellmoneyX[i] = sw.money[i] / 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r.lv = 1;
            r.exp = 0;
            r.oriatk = 0;
            uw.atk = 0;           
            r.money = 0;
            role.itemName[0] = "新手劍";
            role.itemAtk[0] = 1;
            r.arms = "無";    
            for (int i = 2; i <= 100; i++)
            {
                u.n = i * i * i;
                u.upEXP[i] = u.n;              
            }                    
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"def.wav";
            sp.Play(); //放音樂
            r.atk = r.oriatk + uw.atk;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            Fight fight = new Fight();
            //r.oriatk = r.lv;       
            r.atk = r.oriatk + uw.atk;
            fight.atk = r.atk;

            if (fight.ShowDialog() == DialogResult.OK)
            {
                r.money += fight.rewardM;
                r.exp += fight.rewardE;
                if (fight.GetWea == 1)
                {                                     
                    for (int i = 0; i < 10; i++)
                    {
                        if (role.itemName[i] == null)
                        {                           
                            role.itemName[i] = sw.name[0];
                            role.itemAtk[i] = sw.atk[0];
                            break;
                        }
                        else if (i == 9)
                        {
                            MessageBox.Show("物品欄滿了!!因此你沒拿到這個神器!記得先去賣東西留位置再來打!");
                        }
                    }
                }
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = @"def.wav";
                sp.Play(); //放音樂
            }
            while (r.exp >= u.upEXP[r.lv+1])
            {
                r.exp -= u.upEXP[r.lv + 1];
                r.lv++;
                r.oriatk += r.lv / 10 + 1;
                r.atk = r.oriatk + uw.atk;
            }          
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();                      
            shop.m = r.money;
            if (shop.ShowDialog() == DialogResult.OK)
            {
                if (r.money < w.money[shop.wea])
                {
                    MessageBox.Show("你買不起!");
                }
                else
                {                   
                    for (int i = 0; i < 10; i++)
                    {
                        if (role.itemName[i] == null)
                        {
                            r.money-=w.money[shop.wea];                                                           
                            role.itemName[i] = w.name[shop.wea];
                            role.itemAtk[i] = w.atk[shop.wea];
                            break;
                        }
                        else if (i == 9)
                        {
                            MessageBox.Show("物品欄滿了!!");
                        }
                    }
                }              
            }                                                  
        }

        private void buttonRule_Click(object sender, EventArgs e)
        {          
            role.lv = r.lv.ToString();
            role.atk = r.atk;
            role.oa = r.oriatk;
            role.exp = r.exp;
            role.money = r.money;
            role.arms = r.arms;
            role.upexp = u.upEXP[r.lv + 1];             
            if (role.ShowDialog() == DialogResult.OK)
            {
                r.arms = role.arms;            
                uw.atk = role.chooseWeaAtk;
                r.atk = r.oriatk + uw.atk;
                r.money = role.money;
            }
        }
    }
}
