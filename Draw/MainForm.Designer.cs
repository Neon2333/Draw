
namespace Draw
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_freeDraw = new System.Windows.Forms.Panel();
            this.label_Y = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.tabPage_visual = new System.Windows.Forms.TabPage();
            this.simpleButton_Color = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_quitFreeDraw = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_clearGraph = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_freeDraw = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage_mainTool = new System.Windows.Forms.TabPage();
            this.label_seperator1 = new System.Windows.Forms.Label();
            this.tabPage_file = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_visual.SuspendLayout();
            this.tabPage_mainTool.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_freeDraw
            // 
            this.panel_freeDraw.BackColor = System.Drawing.Color.White;
            this.panel_freeDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_freeDraw.Location = new System.Drawing.Point(277, 37);
            this.panel_freeDraw.Name = "panel_freeDraw";
            this.panel_freeDraw.Size = new System.Drawing.Size(991, 720);
            this.panel_freeDraw.TabIndex = 0;
            this.panel_freeDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseDown);
            this.panel_freeDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseMove);
            this.panel_freeDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseUp);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(1140, 12);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(23, 15);
            this.label_Y.TabIndex = 11;
            this.label_Y.Text = "Y:";
            // 
            // textBox_Y
            // 
            this.textBox_Y.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Y.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Y.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_Y.Location = new System.Drawing.Point(1169, 12);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.ReadOnly = true;
            this.textBox_Y.Size = new System.Drawing.Size(77, 18);
            this.textBox_Y.TabIndex = 10;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(994, 12);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(23, 15);
            this.label_X.TabIndex = 9;
            this.label_X.Text = "X:";
            // 
            // textBox_X
            // 
            this.textBox_X.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_X.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_X.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_X.Location = new System.Drawing.Point(1023, 12);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.ReadOnly = true;
            this.textBox_X.Size = new System.Drawing.Size(77, 18);
            this.textBox_X.TabIndex = 8;
            // 
            // tabPage_visual
            // 
            this.tabPage_visual.BackColor = System.Drawing.Color.White;
            this.tabPage_visual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_visual.Controls.Add(this.simpleButton_Color);
            this.tabPage_visual.Controls.Add(this.simpleButton_quitFreeDraw);
            this.tabPage_visual.Controls.Add(this.simpleButton_clearGraph);
            this.tabPage_visual.Controls.Add(this.simpleButton_freeDraw);
            this.tabPage_visual.Location = new System.Drawing.Point(4, 34);
            this.tabPage_visual.Name = "tabPage_visual";
            this.tabPage_visual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_visual.Size = new System.Drawing.Size(261, 716);
            this.tabPage_visual.TabIndex = 2;
            this.tabPage_visual.Text = " 查看";
            // 
            // simpleButton_Color
            // 
            this.simpleButton_Color.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_Color.Appearance.Options.UseBackColor = true;
            this.simpleButton_Color.Location = new System.Drawing.Point(15, 79);
            this.simpleButton_Color.Name = "simpleButton_Color";
            this.simpleButton_Color.Size = new System.Drawing.Size(53, 48);
            this.simpleButton_Color.TabIndex = 6;
            this.simpleButton_Color.Text = "颜色";
            // 
            // simpleButton_quitFreeDraw
            // 
            this.simpleButton_quitFreeDraw.Location = new System.Drawing.Point(142, 11);
            this.simpleButton_quitFreeDraw.Name = "simpleButton_quitFreeDraw";
            this.simpleButton_quitFreeDraw.Size = new System.Drawing.Size(99, 49);
            this.simpleButton_quitFreeDraw.TabIndex = 5;
            this.simpleButton_quitFreeDraw.Text = "退出自由画线";
            this.simpleButton_quitFreeDraw.Click += new System.EventHandler(this.Button_quitFreeDraw_Click);
            // 
            // simpleButton_clearGraph
            // 
            this.simpleButton_clearGraph.Location = new System.Drawing.Point(69, 19);
            this.simpleButton_clearGraph.Name = "simpleButton_clearGraph";
            this.simpleButton_clearGraph.Size = new System.Drawing.Size(67, 27);
            this.simpleButton_clearGraph.TabIndex = 4;
            this.simpleButton_clearGraph.Text = "清空画布";
            this.simpleButton_clearGraph.Click += new System.EventHandler(this.Button_flush_Click);
            // 
            // simpleButton_freeDraw
            // 
            this.simpleButton_freeDraw.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton_freeDraw.Appearance.Options.UseBackColor = true;
            this.simpleButton_freeDraw.Appearance.Options.UseImage = true;
            this.simpleButton_freeDraw.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_freeDraw.ImageOptions.Image")));
            this.simpleButton_freeDraw.Location = new System.Drawing.Point(15, 11);
            this.simpleButton_freeDraw.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton_freeDraw.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_freeDraw.Name = "simpleButton_freeDraw";
            this.simpleButton_freeDraw.Size = new System.Drawing.Size(35, 35);
            this.simpleButton_freeDraw.TabIndex = 2;
            this.simpleButton_freeDraw.Click += new System.EventHandler(this.Button_freeDraw_Click);
            // 
            // tabPage_mainTool
            // 
            this.tabPage_mainTool.BackColor = System.Drawing.Color.White;
            this.tabPage_mainTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_mainTool.Controls.Add(this.label_seperator1);
            this.tabPage_mainTool.Location = new System.Drawing.Point(4, 34);
            this.tabPage_mainTool.Name = "tabPage_mainTool";
            this.tabPage_mainTool.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mainTool.Size = new System.Drawing.Size(261, 716);
            this.tabPage_mainTool.TabIndex = 1;
            this.tabPage_mainTool.Text = " 主页";
            // 
            // label_seperator1
            // 
            this.label_seperator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_seperator1.Location = new System.Drawing.Point(197, 26);
            this.label_seperator1.Name = "label_seperator1";
            this.label_seperator1.Size = new System.Drawing.Size(2, 70);
            this.label_seperator1.TabIndex = 0;
            this.label_seperator1.Text = "label1";
            // 
            // tabPage_file
            // 
            this.tabPage_file.BackColor = System.Drawing.Color.White;
            this.tabPage_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_file.Location = new System.Drawing.Point(4, 34);
            this.tabPage_file.Name = "tabPage_file";
            this.tabPage_file.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_file.Size = new System.Drawing.Size(261, 716);
            this.tabPage_file.TabIndex = 0;
            this.tabPage_file.Text = " 文件";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_file);
            this.tabControl1.Controls.Add(this.tabPage_mainTool);
            this.tabControl1.Controls.Add(this.tabPage_visual);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 30);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 754);
            this.tabControl1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 761);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_freeDraw);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label_X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabPage_visual.ResumeLayout(false);
            this.tabPage_mainTool.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_freeDraw;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TabPage tabPage_visual;
        private System.Windows.Forms.TabPage tabPage_mainTool;
        private System.Windows.Forms.TabPage tabPage_file;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label_seperator1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_freeDraw;
        private DevExpress.XtraEditors.SimpleButton simpleButton_quitFreeDraw;
        private DevExpress.XtraEditors.SimpleButton simpleButton_clearGraph;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Color;
    }
}

