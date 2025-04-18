namespace WindowsFormsApplication1
{
    partial class Item
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
            this.label1 = new System.Windows.Forms.Label();
            this.clbxItem = new System.Windows.Forms.CheckedListBox();
            this.btnWear = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "裝備";
            // 
            // clbxItem
            // 
            this.clbxItem.CheckOnClick = true;
            this.clbxItem.FormattingEnabled = true;
            this.clbxItem.Location = new System.Drawing.Point(48, 68);
            this.clbxItem.Name = "clbxItem";
            this.clbxItem.Size = new System.Drawing.Size(270, 184);
            this.clbxItem.TabIndex = 0;
            this.clbxItem.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.clbxItem.SelectedIndexChanged += new System.EventHandler(this.clbxItem_SelectedIndexChanged);
            // 
            // btnWear
            // 
            this.btnWear.Location = new System.Drawing.Point(70, 19);
            this.btnWear.Name = "btnWear";
            this.btnWear.Size = new System.Drawing.Size(85, 29);
            this.btnWear.TabIndex = 2;
            this.btnWear.Text = "穿上";
            this.btnWear.UseVisualStyleBackColor = true;
            this.btnWear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(161, 19);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(85, 29);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "全脫";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(252, 19);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(85, 29);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "賣掉";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 276);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnWear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbxItem);
            this.Name = "Item";
            this.Text = "物品欄";
            this.Load += new System.EventHandler(this.Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbxItem;
        private System.Windows.Forms.Button btnWear;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSell;
    }
}