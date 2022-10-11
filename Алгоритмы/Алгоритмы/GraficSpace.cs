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
            Pen pen = new Pen(Color.Black);
            grath.DrawLine(pen, new Point(box.Width/2,0), new Point(box.Width/2,box.Height));
            grath.DrawLine(pen, new Point(0, box.Height/2), new Point(box.Width, box.Height/2));
            box.Image = map;
        }
    }
}
