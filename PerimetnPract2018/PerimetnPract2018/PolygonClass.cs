using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterPract2018
{
    /// <summary>
    /// Point structure
    /// </summary>
    public struct Point
    {
        public float x;
        public float y;
    }
    /// <summary>
    /// Class to calculate зerimeter of polygon
    /// </summary>
    public class PolygonClass
    {
        /// <summary>
        /// Calculating legth of one side of polygon
        /// </summary>
        /// <param name="pt1">First point</param>
        /// <param name="pt2">Second point</param>
        /// <returns>Length of line</returns>
        static public float CalcLength(Point pt1, Point pt2)
        {
            return (float)Math.Sqrt((pt1.x - pt2.x) * (pt1.x - pt2.x) + (pt1.y - pt2.y) * (pt1.y - pt2.y));
        }
        /// <summary>
        /// Calculating зerimeter of polygon
        /// </summary>
        /// <param name="points">Array of points</param>
        /// <returns>Perimeter</returns>
        static public float CalcPerimeter(Point[] points)
        {
            //Check, if there are less then 3 points
            if(points.Length < 3)
            {
                throw new Exception("Exception: Polygon can't have less then 3 points");
            }
            float res = 0;
            //Go through all points
            for (int i = 0; i < points.Length; i++)
            {
                //Find side length and add to result variable
                res += CalcLength(points[i], points[(i + 1) % points.Length]);
            }
            //Return result
            return res;
        }
    }
}
