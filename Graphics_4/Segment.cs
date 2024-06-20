using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_4
{
    // Класс Segment для задания отрезка (начало и конец отрезка) 
    class Segment
    {
        public PointF startP, endP;

        public Segment() { startP = new PointF(); endP = new PointF(); }

        public Segment(PointF l, PointF r) { startP = l; endP = r; }
    }
}
