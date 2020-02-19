using System.Linq;
using System;

namespace TestRectangle
{
    public class CalculateClass
    {
        public bool IsRectangle(Rectangle points)
        {
            Point[] recPoint = new Point[4];
            recPoint[0] = points.One;
            recPoint[1] = points.Two;
            recPoint[2] = points.Three;
            recPoint[3] = points.Four;

            bool xParal = false;
            bool yParal = false;

            bool diag = false;

            int diagX = 0;
            int diagY = 0;

            var sortPoints = recPoint.OrderBy(u => u.X).ToArray();

            Point one = sortPoints[0];
            Point two = sortPoints[1];
            Point three = sortPoints[2];
            Point four = sortPoints[3];

            var diffOneX = two.X - one.X;
            var diffTwoX = four.X - three.X;

            if (diffOneX == diffTwoX)
            {
                yParal = true;
            }

            int diffOneY = -1;
            int diffTwoY = -1;

            if (four.Y > two.Y && three.Y > one.Y)
            {
                diffOneY = four.Y - two.Y;
                diffTwoY = three.Y - one.Y;

                diagX = four.X - one.X;
                diagY = three.Y - two.Y;
            }
            else if (four.Y > three.Y && two.Y > one.Y)
            {
                diffOneY = four.Y - two.Y;
                diffTwoY = three.Y - one.Y;

                diagX = four.X - one.X;
                diagY = two.Y - three.Y;
            }
            else if (four.Y == two.Y && three.Y == one.Y)
            {
                diffOneY = four.Y - two.Y;
                diffTwoY = three.Y - one.Y;

                diagX = four.X - one.X;
                diagY = three.X - two.X;
            }

            if (diffOneY == diffTwoY && diffOneY >= 0 && diffTwoY >= 0)
            {
                xParal = true;
            }

            if (diagX == diagY && diagX != 0 && diagY != 0)
            {
                diag = true;
            }

            if (xParal == true && yParal == true && diag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool IsRectangle(Rectangle points)
        //{
        //    Point[] recPoint = new Point[4];
        //    recPoint[0] = points.One;
        //    recPoint[1] = points.Two;
        //    recPoint[2] = points.Three;
        //    recPoint[3] = points.Four;

        //    var sortPoints = recPoint.OrderBy(u => u.X).ToArray();

        //    Point a = sortPoints[0];
        //    Point b = sortPoints[1];
        //    Point c = sortPoints[2];
        //    Point d = sortPoints[3];

        //    double AB = LineLength(a, b);
        //    double AC = LineLength(a, c);
        //    double BC = LineLength(b, c);
        //    double CD = LineLength(c, d);
        //    double BD = LineLength(b, d);
        //    double AD = LineLength(a, d);

        //    bool result1 = (AB + AC == BC) ? true : false;
        //    bool result2 = (CD + BD == AD) ? true : false;

        //    return result1 & result2;
        //}

        //private static double LineLength(Point one, Point two)
        //{
        //    return Math.Pow(two.Y - one.Y, 2) + Math.Pow(two.X - one.X, 2);
        //}
    }
}
