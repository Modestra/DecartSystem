using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритмы
{
    class GraficSpace
    {
        public int X;
        public int Y;
        
        public void CreateCell(PictureBox box)
        {
            Bitmap map = new Bitmap(box.Width, box.Height);
            Graphics grath = Graphics.FromImage(map);
            int zero_x = box.Image.Width / 2;
            int zero_y = box.Image.Height / 2;
            Pen pen = new Pen(Color.Black);
            grath.DrawLine(pen, new Point(zero_x,0), new Point(0, zero_y));
        }
    }
}
