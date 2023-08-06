
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
            this.panel_freeDraw = new System.Windows.Forms.Panel();
            this.Button_freeDraw = new System.Windows.Forms.Button();
            this.Button_quitFreeDraw = new System.Windows.Forms.Button();
            this.Button_flush = new System.Windows.Forms.Button();
            this.label_Y = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel_freeDraw
            // 
            this.panel_freeDraw.BackColor = System.Drawing.Color.White;
            this.panel_freeDraw.Location = new System.Drawing.Point(12, 12);
            this.panel_freeDraw.Name = "panel_freeDraw";
            this.panel_freeDraw.Size = new System.Drawing.Size(1744, 1009);
            this.panel_freeDraw.TabIndex = 0;
            this.panel_freeDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseDown);
            this.panel_freeDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseMove);
            this.panel_freeDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_freeDraw_MouseUp);
            // 
            // Button_freeDraw
            // 
            this.Button_freeDraw.BackColor = System.Drawing.Color.White;
            this.Button_freeDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_freeDraw.Location = new System.Drawing.Point(1774, 13);
            this.Button_freeDraw.Name = "Button_freeDraw";
            this.Button_freeDraw.Size = new System.Drawing.Size(116, 44);
            this.Button_freeDraw.TabIndex = 1;
            this.Button_freeDraw.Text = "自由画线";
            this.Button_freeDraw.UseVisualStyleBackColor = false;
            this.Button_freeDraw.Click += new System.EventHandler(this.Button_freeDraw_Click);
            // 
            // Button_quitFreeDraw
            // 
            this.Button_quitFreeDraw.BackColor = System.Drawing.Color.White;
            this.Button_quitFreeDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_quitFreeDraw.Location = new System.Drawing.Point(1774, 77);
            this.Button_quitFreeDraw.Name = "Button_quitFreeDraw";
            this.Button_quitFreeDraw.Size = new System.Drawing.Size(116, 49);
            this.Button_quitFreeDraw.TabIndex = 2;
            this.Button_quitFreeDraw.Text = "退出自由画线";
            this.Button_quitFreeDraw.UseVisualStyleBackColor = false;
            this.Button_quitFreeDraw.Click += new System.EventHandler(this.Button_quitFreeDraw_Click);
            // 
            // Button_flush
            // 
            this.Button_flush.BackColor = System.Drawing.Color.White;
            this.Button_flush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_flush.Location = new System.Drawing.Point(1774, 145);
            this.Button_flush.Name = "Button_flush";
            this.Button_flush.Size = new System.Drawing.Size(116, 54);
            this.Button_flush.TabIndex = 3;
            this.Button_flush.Text = "清空画布";
            this.Button_flush.UseVisualStyleBackColor = false;
            this.Button_flush.Click += new System.EventHandler(this.Button_flush_Click);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(1773, 266);
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
            this.textBox_Y.Location = new System.Drawing.Point(1802, 266);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.ReadOnly = true;
            this.textBox_Y.Size = new System.Drawing.Size(77, 18);
            this.textBox_Y.TabIndex = 10;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(1773, 225);
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
            this.textBox_X.Location = new System.Drawing.Point(1802, 225);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.ReadOnly = true;
            this.textBox_X.Size = new System.Drawing.Size(77, 18);
            this.textBox_X.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.Button_flush);
            this.Controls.Add(this.Button_quitFreeDraw);
            this.Controls.Add(this.Button_freeDraw);
            this.Controls.Add(this.panel_freeDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_freeDraw;
        private System.Windows.Forms.Button Button_freeDraw;
        private System.Windows.Forms.Button Button_quitFreeDraw;
        private System.Windows.Forms.Button Button_flush;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_X;
    }
}

