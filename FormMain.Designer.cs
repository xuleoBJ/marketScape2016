namespace marketScape
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbgStateMent = new System.Windows.Forms.TabPage();
            this.tbgWavePredict = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStripMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 482);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(640, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "提示";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(640, 25);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            this.信息ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.信息ToolStripMenuItem.Text = "信息";
            // 
            // tbgStateMent
            // 
            this.tbgStateMent.Location = new System.Drawing.Point(4, 22);
            this.tbgStateMent.Name = "tbgStateMent";
            this.tbgStateMent.Padding = new System.Windows.Forms.Padding(3);
            this.tbgStateMent.Size = new System.Drawing.Size(632, 431);
            this.tbgStateMent.TabIndex = 1;
            this.tbgStateMent.Text = "特别声明";
            this.tbgStateMent.UseVisualStyleBackColor = true;
            // 
            // tbgWavePredict
            // 
            this.tbgWavePredict.Location = new System.Drawing.Point(4, 22);
            this.tbgWavePredict.Name = "tbgWavePredict";
            this.tbgWavePredict.Padding = new System.Windows.Forms.Padding(3);
            this.tbgWavePredict.Size = new System.Drawing.Size(632, 431);
            this.tbgWavePredict.TabIndex = 0;
            this.tbgWavePredict.Text = "实时波动预测";
            this.tbgWavePredict.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgStateMent);
            this.tabControl1.Controls.Add(this.tbgWavePredict);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "人工智能市场预测交易系统";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.TabPage tbgStateMent;
        private System.Windows.Forms.TabPage tbgWavePredict;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

