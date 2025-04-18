namespace WindowsFormsApplication1
{
    partial class Role
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoleLV = new System.Windows.Forms.Label();
            this.RoleEXP = new System.Windows.Forms.Label();
            this.RoleATK = new System.Windows.Forms.Label();
            this.RoleArms = new System.Windows.Forms.Label();
            this.RoleMoney = new System.Windows.Forms.Label();
            this.EXPbar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "攻擊力";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "武器";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "錢";
            // 
            // RoleLV
            // 
            this.RoleLV.AutoSize = true;
            this.RoleLV.Location = new System.Drawing.Point(127, 27);
            this.RoleLV.Name = "RoleLV";
            this.RoleLV.Size = new System.Drawing.Size(0, 15);
            this.RoleLV.TabIndex = 5;
            this.RoleLV.Click += new System.EventHandler(this.label6_Click);
            // 
            // RoleEXP
            // 
            this.RoleEXP.AutoSize = true;
            this.RoleEXP.Location = new System.Drawing.Point(126, 183);
            this.RoleEXP.Name = "RoleEXP";
            this.RoleEXP.Size = new System.Drawing.Size(0, 15);
            this.RoleEXP.TabIndex = 6;
            // 
            // RoleATK
            // 
            this.RoleATK.AutoSize = true;
            this.RoleATK.Location = new System.Drawing.Point(127, 65);
            this.RoleATK.Name = "RoleATK";
            this.RoleATK.Size = new System.Drawing.Size(0, 15);
            this.RoleATK.TabIndex = 7;
            // 
            // RoleArms
            // 
            this.RoleArms.AutoSize = true;
            this.RoleArms.Location = new System.Drawing.Point(113, 103);
            this.RoleArms.Name = "RoleArms";
            this.RoleArms.Size = new System.Drawing.Size(0, 15);
            this.RoleArms.TabIndex = 8;
            // 
            // RoleMoney
            // 
            this.RoleMoney.AutoSize = true;
            this.RoleMoney.Location = new System.Drawing.Point(127, 143);
            this.RoleMoney.Name = "RoleMoney";
            this.RoleMoney.Size = new System.Drawing.Size(0, 15);
            this.RoleMoney.TabIndex = 9;
            // 
            // EXPbar
            // 
            this.EXPbar.Location = new System.Drawing.Point(29, 212);
            this.EXPbar.Name = "EXPbar";
            this.EXPbar.Size = new System.Drawing.Size(323, 19);
            this.EXPbar.TabIndex = 10;
            this.EXPbar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(219, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "物品欄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(219, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 253);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EXPbar);
            this.Controls.Add(this.RoleMoney);
            this.Controls.Add(this.RoleArms);
            this.Controls.Add(this.RoleATK);
            this.Controls.Add(this.RoleEXP);
            this.Controls.Add(this.RoleLV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Role";
            this.Text = "角色資訊";
            this.Load += new System.EventHandler(this.Role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RoleLV;
        private System.Windows.Forms.Label RoleEXP;
        private System.Windows.Forms.Label RoleATK;
        private System.Windows.Forms.Label RoleArms;
        private System.Windows.Forms.Label RoleMoney;
        private System.Windows.Forms.ProgressBar EXPbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}