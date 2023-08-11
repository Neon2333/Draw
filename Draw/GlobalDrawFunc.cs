using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class GlobalDrawFunc
    {
        //画点函数
        public static void drawCircleAndFill(int x, int y, int r, Graphics gp)
        {
            gp.DrawEllipse(new Pen(Color.Red, 1), x - r, y - r, (int)(1.414 * r), (int)(1.414 * r));  //r为圆点半径
            gp.FillEllipse(new SolidBrush(Color.Red), x - r, y - r, (int)(1.414 * r), (int)(1.414 * r));
        }

    }
}
