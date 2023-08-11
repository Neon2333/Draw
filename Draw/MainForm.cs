using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Draw
{
    public partial class MainForm : Form
    {
        ////帧率
        //private int g_frameRate = 60;
        //private int g_millSecWait = 0;
        //绘制模式
        private enum DrawMode { None, FreeDraw };
        //当前模式
        private DrawMode currentMode;
        //画布
        private Graphics graphics;
        //画笔
        Pen pen;
        //鼠标坐标
        int pX = 0;
        int pY = 0;
        int pXFormer = 0;
        int pYFormer = 0;
        //鼠标左键按下标志
        private bool flagLeftDown = false;
        //鼠标右下按下标志
        private bool flagRightDown = false;
       

        public MainForm()
        {
            InitializeComponent();

            initForm();
        }

        //初始化页面
        private void initForm()
        {
            //初始化自由画线参数
            initFreeDraw(); 
        }

        /// <summary>
        /// 设置画笔
        /// </summary>
        /// <param name="color"></param>
        /// <param name="thickness"></param>
        private void setPen(Color color, int thickness)
        {
            //线粗细、颜色
            pen = new Pen(color, thickness);
            //设置画笔平滑，去掉毛刺、锯齿
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
        }

        /// <summary>
        /// 清空画布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_flush_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_freeDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //刷新鼠标位置实时显示
            pX = e.X;
            pY = e.Y;
            textBox_X.Text = pX.ToString();
            textBox_Y.Text = pY.ToString();

            //绘制曲线
            if (currentMode == DrawMode.FreeDraw)
            {
                FreeDraw(pen, graphics);
            }
        }


        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_freeDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                flagLeftDown = true;
                //按下瞬间记录起点
                pXFormer = e.X;
                pYFormer = e.Y;
            }
            else if (e.Button.Equals(MouseButtons.Right))
            {
                flagRightDown = true;
                //这里添加擦除上一个曲线功能
            }
        }

        /// <summary>
        /// 鼠标弹起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_freeDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                flagLeftDown = false;

            }
            else if (e.Button.Equals(MouseButtons.Right))
            {
                flagRightDown = false;
            }
        }


        #region freeDraw
        /// <summary>
        /// 初始化自由绘制mode参数
        /// 可以编写config等工具栏设置这些参数
        /// </summary>
        private void initFreeDraw()
        {
            graphics = panel_freeDraw.CreateGraphics();
            setPen(Color.Black, 16);
            

            //int g_millSecWait = 1000 / g_frameRate;

            //cancelTokenSourceFreeDraw = new CancellationTokenSource();
            //cancelTokenFreeDraw = cancelTokenSourceFreeDraw.Token;
        }

        private void FreeDraw(Pen pen, Graphics graphics)
        {
            if (flagLeftDown && (pXFormer != pX || pYFormer != pY))
            {
                //根据坐标连线
                //graphics.DrawLine(pen, pXFormer, pYFormer, pX, pY);
                //改为画曲线
                graphics.DrawCurve(pen, new Point[] { new Point(pXFormer, pYFormer), new Point(pX, pY) });
                //更新坐标（只有画过线的坐标才更新，这样不会点和点之间不会有间断）
                pXFormer = pX;
                pYFormer = pY;
            }
        }


        ////自由画线终止线程
        //private CancellationTokenSource cancelTokenSourceFreeDraw;
        //private CancellationToken cancelTokenFreeDraw;
        ///// <summary>
        ///// 自由画线模式
        ///// </summary>
        ///// <param name="xStart"></param>
        ///// <param name="yStart"></param>
        ///// <param name="pen"></param>
        ///// <param name="graphics"></param>
        ///// <param name="frameRate"></param>
        //private void FreeDraw(Pen pen, Graphics graphics, int frameRate)
        //{
        //    try
        //    {
        //        if (currentMode == FormMode.FreeDraw)
        //        {
        //            Task.Run(() =>
        //            {
        //                //进入freeDraw模式才画
        //                while (!cancelTokenSourceFreeDraw.IsCancellationRequested)
        //                {
        //                    //按下左键才画
        //                    //鼠标坐标改变才画线
        //                    if (flagLeftDown && (pXFormer != pX || pYFormer != pY))
        //                    {
        //                        //连点成线
        //                        //BaseDrawFunc.drawCircleAndFill(pXFormer, pYFormer, 2, graphics);
        //                        //折线
        //                        graphics.DrawLine(pen, pXFormer, pYFormer, pX, pY);

        //                        //更新坐标（只有画过线的坐标才更新，这样不会点和点之间不会有间断）
        //                        pXFormer = pX;
        //                        pYFormer = pY;

        //                        //按帧数延时(只有画了线才延迟）
        //                        cancelTokenFreeDraw.WaitHandle.WaitOne(g_millSecWait);
        //                    }
        //                }
        //            }, cancelTokenFreeDraw);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        private void Button_freeDraw_Click(object sender, EventArgs e)
        {
            if (currentMode != DrawMode.FreeDraw)
            {
                //切换到自由画线模式
                currentMode = DrawMode.FreeDraw;
                //cancelTokenSourceFreeDraw = new CancellationTokenSource();
                //cancelTokenFreeDraw = cancelTokenSourceFreeDraw.Token;
                //FreeDraw(pen, graphics, g_frameRate);
            }
        }

        /// <summary>
        /// 退出自由画线模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_quitFreeDraw_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.None;
            //cancelTokenSourceFreeDraw.Cancel();
        }
        #endregion





    }

}
