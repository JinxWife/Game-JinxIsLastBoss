namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonFight = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFight
            // 
            this.buttonFight.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFight.Location = new System.Drawing.Point(155, 177);
            this.buttonFight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(144, 55);
            this.buttonFight.TabIndex = 0;
            this.buttonFight.Text = "開始戰鬥";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonShop.Location = new System.Drawing.Point(155, 264);
            this.buttonShop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(144, 55);
            this.buttonShop.TabIndex = 1;
            this.buttonShop.Text = "商店";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonRule
            // 
            this.buttonRule.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRule.Location = new System.Drawing.Point(155, 357);
            this.buttonRule.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRule.Name = "buttonRule";
            this.buttonRule.Size = new System.Drawing.Size(144, 55);
            this.buttonRule.TabIndex = 2;
            this.buttonRule.Text = "角色資料";
            this.buttonRule.UseVisualStyleBackColor = true;
            this.buttonRule.Click += new System.EventHandler(this.buttonRule_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 480);
            this.Controls.Add(this.buttonRule);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonFight);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "好玩遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonRule;       
    }
}

