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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSys = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbgStateMent = new System.Windows.Forms.TabPage();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblFrontInfor = new System.Windows.Forms.Label();
            this.tbgWavePredict = new System.Windows.Forms.TabPage();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgMoodIndex = new System.Windows.Forms.TabPage();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTradeReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.tbgStateMent.SuspendLayout();
            this.tbgWavePredict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
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
            this.tsmiSys,
            this.tsmiSet,
            this.tsmiHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(640, 25);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiSys
            // 
            this.tsmiSys.Name = "tsmiSys";
            this.tsmiSys.Size = new System.Drawing.Size(44, 21);
            this.tsmiSys.Text = "系统";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本信息ToolStripMenuItem});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本信息ToolStripMenuItem.Text = "版本信息";
            // 
            // tbgStateMent
            // 
            this.tbgStateMent.Controls.Add(this.lblAuthor);
            this.tbgStateMent.Controls.Add(this.lblFrontInfor);
            this.tbgStateMent.Location = new System.Drawing.Point(4, 22);
            this.tbgStateMent.Name = "tbgStateMent";
            this.tbgStateMent.Padding = new System.Windows.Forms.Padding(3);
            this.tbgStateMent.Size = new System.Drawing.Size(632, 431);
            this.tbgStateMent.TabIndex = 1;
            this.tbgStateMent.Text = "特别声明";
            this.tbgStateMent.UseVisualStyleBackColor = true;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(179, 383);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(218, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "作者：13581625021 一行工作室";
            // 
            // lblFrontInfor
            // 
            this.lblFrontInfor.AutoSize = true;
            this.lblFrontInfor.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontInfor.ForeColor = System.Drawing.Color.Red;
            this.lblFrontInfor.Location = new System.Drawing.Point(24, 135);
            this.lblFrontInfor.Name = "lblFrontInfor";
            this.lblFrontInfor.Size = new System.Drawing.Size(584, 26);
            this.lblFrontInfor.TabIndex = 0;
            this.lblFrontInfor.Text = "本软件不保证预测的正确性，不对用户操作有指导性建议。";
            // 
            // tbgWavePredict
            // 
            this.tbgWavePredict.Controls.Add(this.chartStock);
            this.tbgWavePredict.Location = new System.Drawing.Point(4, 22);
            this.tbgWavePredict.Name = "tbgWavePredict";
            this.tbgWavePredict.Padding = new System.Windows.Forms.Padding(3);
            this.tbgWavePredict.Size = new System.Drawing.Size(632, 431);
            this.tbgWavePredict.TabIndex = 0;
            this.tbgWavePredict.Text = "实时波动预测";
            this.tbgWavePredict.UseVisualStyleBackColor = true;
            // 
            // chartStock
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea2);
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartStock.Legends.Add(legend2);
            this.chartStock.Location = new System.Drawing.Point(3, 3);
            this.chartStock.Name = "chartStock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(626, 425);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgStateMent);
            this.tabControl1.Controls.Add(this.tbgWavePredict);
            this.tabControl1.Controls.Add(this.tbgMoodIndex);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // tbgMoodIndex
            // 
            this.tbgMoodIndex.Location = new System.Drawing.Point(4, 22);
            this.tbgMoodIndex.Name = "tbgMoodIndex";
            this.tbgMoodIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tbgMoodIndex.Size = new System.Drawing.Size(632, 431);
            this.tbgMoodIndex.TabIndex = 2;
            this.tbgMoodIndex.Text = "情绪指数提醒";
            this.tbgMoodIndex.UseVisualStyleBackColor = true;
            // 
            // tsmiSet
            // 
            this.tsmiSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTradeReminder});
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(44, 21);
            this.tsmiSet.Text = "设置";
            // 
            // tsmiTradeReminder
            // 
            this.tsmiTradeReminder.Name = "tsmiTradeReminder";
            this.tsmiTradeReminder.Size = new System.Drawing.Size(152, 22);
            this.tsmiTradeReminder.Text = "交易提醒";
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
            this.tbgStateMent.ResumeLayout(false);
            this.tbgStateMent.PerformLayout();
            this.tbgWavePredict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSys;
        private System.Windows.Forms.TabPage tbgStateMent;
        private System.Windows.Forms.TabPage tbgWavePredict;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblFrontInfor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.TabPage tbgMoodIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiTradeReminder;
    }
}

