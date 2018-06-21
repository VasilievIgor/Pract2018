using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetnPract2018
{
    public struct Point
    {
        public int x;
        public int y;
    }
    class PolygonClass
    {

        static public float CalcLength(Point pt1, Point pt2)
        {
            return (float)Math.Sqrt((pt1.x - pt2.x) * (pt1.x - pt2.x) + (pt1.y - pt2.y) * (pt1.y - pt2.y));
        }

        static public float CalcPerimetr(Point[] points)
        {
            if(points.Length < 3)
            {
                return 0;
            }
            float res = 0;
            for (int i = 1; i < points.Length; i++)
            {
                res += CalcLength(points[i], points[i - 1]);
            }
            res += CalcLength(points[0], points[points.Length - 1]);
            return res;
        }
    }
}
