using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
  
    public partial class Fight : Form
    {
        public int atk;
        public int rewardM=0;
        public int rewardE=0;
        public int GetWea;
        public string[] x;
        public Fight()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetWea = 0;
            string[] dirs = Directory.GetFiles(@"jpg", "*.jpg");
            x = dirs;
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void button1_Click(object sender, EventArgs e)
        {        
            Monster f3 = new Monster();                    
            f3.hp = 10;          
            f3.name = "狗狗";
            f3.Text = f3.name;
            f3.atk = atk;
            f3.rewardMoney = 50;
            f3.rewardEXP = 3; f3.y = x; f3.i = 0; 
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0;  rewardM += f3.giveMoney; rewardE += f3.giveEXP;                         
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 30;
            f3.name = "霹靂小組";
            f3.Text = f3.name;
            f3.atk = atk;
            f3.rewardMoney = 100;
            f3.rewardEXP = 6; f3.y = x; f3.i = 1;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }             
        private void button3_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 50; f3.name = "菁英"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 150; f3.rewardEXP = 10; f3.y = x; f3.i = 2;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 80; f3.name = "頭領奧瑪"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 230; f3.rewardEXP = 21; f3.y = x; f3.i = 3;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 125; f3.name = "死神"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 320; f3.rewardEXP = 36; f3.y = x; f3.i = 4;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 200; f3.name = "夢魘"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 450; f3.rewardEXP = 54; f3.y = x; f3.i = 5;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 300; f3.name = "死靈"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 600; f3.rewardEXP = 80; f3.y = x; f3.i = 6;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 450; f3.name = "小莎蒂"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 800; f3.rewardEXP = 112; f3.y = x; f3.i = 7;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 650; f3.name = "培羅娜"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 1000; f3.rewardEXP = 145; f3.y = x; f3.i = 8;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 900; f3.name = "月夜貓"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 1300; f3.rewardEXP = 170; f3.y = x; f3.i = 9;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 1200; f3.name = "幻魔之影"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 1600; f3.rewardEXP = 208; f3.y = x; f3.i = 10;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();          
            f3.hp = 1000; f3.name = "虛月姐姐 只有7秒!"; f3.Text = f3.name; f3.t = 7;
            f3.atk = atk; f3.rewardMoney = 2000; f3.rewardEXP = 258; f3.y = x; f3.i = 11;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 2000; f3.name = "普通小丑"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 1800; f3.rewardEXP = 310; f3.y = x; f3.i = 12;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 1300; f3.name = "普通皇后"; f3.Text = f3.name;
            f3.atk = atk/2; f3.rewardMoney = 1800; f3.rewardEXP = 310; f3.y = x; f3.i = 13;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 1700; f3.name = "普通班班"; f3.Text = f3.name; f3.t = 8;
            f3.atk = atk; f3.rewardMoney = 1800; f3.rewardEXP = 310; f3.y = x; f3.i = 14;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 2400; f3.name = "普通貝倫"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 1800; f3.rewardEXP = 310; f3.y = x; f3.i = 15;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 2500; f3.name = "愛莎芙羅希"; f3.Text = f3.name; f3.t = 11;
            f3.atk = atk; f3.rewardMoney = 2100; f3.rewardEXP = 360; f3.y = x; f3.i = 16;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 3000; f3.name = "希里希斯特"; f3.Text = f3.name; 
            f3.atk = atk; f3.rewardMoney = 2300; f3.rewardEXP = 450; f3.y = x; f3.i = 17;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 4000; f3.name = "希絲特莉雅"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 2600; f3.rewardEXP = 600; f3.y = x; f3.i = 18;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 5000; f3.name = "莉昂絲"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 3000; f3.rewardEXP = 780; f3.y = x; f3.i = 19;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        
    private void button21_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            Random percent = new Random();
            f3.p = percent.Next(1, 10);
            f3.hp = 7000; f3.name = "女皇"; f3.Text = f3.name; f3.BossWea = "女皇武器";
            f3.atk = atk; f3.rewardMoney = 3500; f3.rewardEXP = 1000; f3.y = x; f3.i = 20;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
                if (f3.getWea == true)
                {
                    GetWea = 1;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 10000; f3.name = "渾沌小丑"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 4000; f3.rewardEXP = 1300; f3.y = x; f3.i = 21;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 6000; f3.name = "混沌皇后"; f3.Text = f3.name;
            f3.atk = atk / 3; f3.rewardMoney = 4000; f3.rewardEXP = 1300; f3.y = x; f3.i = 22;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 8000; f3.name = "渾沌斑斑"; f3.Text = f3.name; f3.t = 6;
            f3.atk = atk; f3.rewardMoney = 4000; f3.rewardEXP = 1300; f3.y = x; f3.i = 23;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 20000; f3.name = "渾沌貝倫"; f3.Text = f3.name; f3.t = 15;
            f3.atk = atk; f3.rewardMoney = 4000; f3.rewardEXP = 1300; f3.y = x; f3.i = 24;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 25500; f3.name = "史烏"; f3.Text = f3.name; f3.t = 15;
            f3.atk = atk; f3.rewardMoney = 5500; f3.rewardEXP = 1700; f3.y = x; f3.i = 25;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 41600; f3.name = "戴米安"; f3.Text = f3.name; f3.t = 20;
            f3.atk = atk; f3.rewardMoney = 7000; f3.rewardEXP = 2200; f3.y = x; f3.i = 26;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 35000; f3.name = "劫"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 9000; f3.rewardEXP = 2750; f3.y = x; f3.i = 27;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 38000; f3.name = "易大師"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 9000; f3.rewardEXP = 2750; f3.y = x; f3.i = 29;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 29000; f3.name = "好運姊"; f3.Text = f3.name;
            f3.atk = atk/2; f3.rewardMoney = 10000; f3.rewardEXP = 2850; f3.y = x; f3.i = 30;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 100000; f3.name = "卡特蓮娜"; f3.Text = f3.name;
            f3.atk = atk; f3.rewardMoney = 12000; f3.rewardEXP = 4000;  f3.y = x; f3.i = 31;                      
            if (f3.ShowDialog() == DialogResult.OK)
            {
                rewardM += f3.giveMoney;
                rewardE += f3.giveEXP;
            }           
        }
        private void button32_Click(object sender, EventArgs e)
        {
            Monster f3 = new Monster();
            f3.hp = 70000; f3.name = "吉茵珂絲"; f3.Text = f3.name;
            f3.atk = atk / 2; f3.rewardMoney = 14000; f3.rewardEXP = 4832; f3.y = x; f3.i = 32;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                f3.t = 0; rewardM += f3.giveMoney; rewardE += f3.giveEXP;
            }
        }
    }
}
