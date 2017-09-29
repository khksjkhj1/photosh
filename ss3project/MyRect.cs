using System;
using System.Collections;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public class MyRect
    {
        private Rectangle rectC;
        private int thick;
        private bool isSolid;

        public MyRect()
        {
            rectC = new Rectangle();
            thick = 1;
            isSolid = true;
        }

        public void setRect(Point start, Point finish, int thick, bool isSolid)
        {
            rectC.X = Math.Min(start.X, finish.X);
            rectC.Y = Math.Min(start.Y, finish.Y);
            rectC.Width = Math.Abs(start.X - finish.X);
            rectC.Height = Math.Abs(start.Y - finish.Y);
            this.thick = thick;
            this.isSolid = isSolid;
        }

        public Rectangle getRect()
        {
            return rectC;
        }
        public int getThick()
        {
            return thick;
        }
        public bool getSolid()
        {
            return isSolid;
        }
    }
}
