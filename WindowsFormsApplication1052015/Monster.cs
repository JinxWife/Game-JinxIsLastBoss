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
    public partial class Monster : Form
    {
        public int i;
        public string[] y;
        public int atk;      
        public int t=10;
        public string name;
        public int hp;
        public int rewardMoney;
        public int giveMoney = 0;
        public int rewardEXP;
        public int giveEXP = 0;

        public int p = 0;//王才有 神器機率
        public string BossWea;
        public bool getWea = false;
        public Monster()
        {
            InitializeComponent();         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getWea = false;
            pictureBox1.Load(y[i]);  //放怪的圖，還沒做
            hpBar.Maximum = hp;
            label2.Text = hp.ToString();           
            hpBar.Value = hp;
            timer1.Start();

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"TenSecond.wav";
            sp.Play(); //放音樂
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (t > 1)
            {
                this.Refresh();
                t--;
            }
            else
            {
                t = 0;
                label1.Text = "0";
                timer1.Stop();     
                MessageBox.Show("你失敗了!");
                this.Close();          
            }
            label1.Text = t.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void atk_Click(object sender, EventArgs e)
        {
            if (hp <= atk)
            {
                timer1.Stop();
                label2.Text = "0";
                hpBar.Value = 0;
                giveMoney = rewardMoney;
                giveEXP = rewardEXP;
                if (p == 5)
                {
                    getWea = true;
                    MessageBox.Show("你贏得勝利!\n" + "獲得" + rewardMoney + "元\n" + rewardEXP + "經驗值\n\n" +
                        "恭喜你獲得" + BossWea + "!!!");
                }
                else
                {
                    MessageBox.Show("你贏得勝利!\n" + "獲得" + rewardMoney + "元\n" + rewardEXP + "經驗值");
                }                
            }
            else
            {
                this.Refresh();
                hp = hp - atk;
                label2.Text = hp.ToString();
                hpBar.Value = hp;

            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void hpBar_Click(object sender, EventArgs e)
        {
            hpBar.Value = hp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
