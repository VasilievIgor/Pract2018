using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PerimeterPract2018.Tests
{
    /// <summary>
    /// Unit-tests
    /// </summary>
    [TestClass()]
    public class PolygonClassTests
    {
        /// <summary>
        /// Length of line test(positive coords)
        /// </summary>
        [TestMethod()]
        public void CalcLengthTest1()
        {
            Point pt1, pt2;
            pt1.x = 0; pt1.y = 0;
            pt2.x = 3; pt2.y = 4;
            float exp = 5;
            float res = PolygonClass.CalcLength(pt1, pt2);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Length of line test(negative coords)
        /// </summary>
        [TestMethod()]
        public void CalcLengthTest2()
        {
            Point pt1, pt2;
            pt1.x = 0; pt1.y = 0;
            pt2.x = -3; pt2.y = -4;
            float exp = 5;
            float res = PolygonClass.CalcLength(pt1, pt2);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Length of line test(two equal points)
        /// </summary>
        [TestMethod()]
        public void CalcLengthTest3()
        {
            Point pt1, pt2;
            pt1.x = 0; pt1.y = 0;
            pt2.x = 0; pt2.y = 0;
            float exp = 0;
            float res = PolygonClass.CalcLength(pt1, pt2);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Perimetr test (triangle)
        /// </summary>
        [TestMethod()]
        public void CalcPerimetrTest1()
        {
            Point[] pt = new Point[3];
            pt[0].x = 0; pt[0].y = 0;
            pt[1].x = 3; pt[1].y = 4;
            pt[2].x = 3; pt[2].y = 0;
            float exp = 12;
            float res = PolygonClass.CalcPerimeter(pt);
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Perimetr test (less then 3 points)
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void CalcPerimetrTest2()
        {
            Point[] pt = new Point[2];
            pt[0].x = 0; pt[0].y = 0;
            pt[1].x = 3; pt[1].y = 4;
            float res = PolygonClass.CalcPerimeter(pt);
            Assert.Fail();
        }
        /// <summary>
        /// Perimetr test (6 points)
        /// </summary>
        [TestMethod()]
        public void CalcPerimetrTest3()
        {
            Point[] pt = new Point[6];
            pt[0].x = 0; pt[0].y = 0;
            pt[1].x = 4; pt[1].y = 0;
            pt[2].x = 7; pt[2].y = 5;
            pt[3].x = 5; pt[3].y = 12;
            pt[4].x =-1; pt[4].y = 12;
            pt[5].x = -5; pt[5].y = 6;
            string exp = "38,13";
            string res = PolygonClass.CalcPerimeter(pt).ToString("N2");
            Assert.AreEqual(exp, res);
        }
    }
}