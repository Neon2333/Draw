2023/8/6

完成自由画线功能。

**存在问题：**

开始画线后，while循环带来的CPU高占用。

画的线的光滑度不够好。

---

8/9
1. 意识到CPU占用高：
在mouseMove事件中只更新坐标，而在while中绘制曲线的方法不对。
应在mouseMove事件中进行绘制，这样只有在鼠标移动触发事件时才绘制曲线，没有while循环CPU占用就减小了。
修改代码逻辑。

2. 为了尝试GDI+效率问题解决方案。准备在后面添加绘制函数曲线功能。

---

8/11

1. 在setPen()函数中设置pen的属性，将曲线的毛刺、锯齿去掉提高了光滑度：

   ```c#
   //设置画笔平滑，去掉毛刺、锯齿
   pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
   pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
   pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
   ```

   

