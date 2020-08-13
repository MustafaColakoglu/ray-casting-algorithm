using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ray_casting_algorithm
{
    public class RayCastingHelper
    {
        public static int PointIsInIt(List<Coordinate> poly, Coordinate point)
        {
            var count = 0;
            for (var b = 0; b < poly.Count; b++)
            {
                var vertex1 = poly[b];
                var vertex2 = poly[(b + 1) % poly.Count];
                if (GetWest(vertex1, vertex2, point.Y, point.X))
                    ++count;
            }
            return count % 2;



        }

        public static bool GetWest(Coordinate A, Coordinate B, double y, double x)
        {
            //if (A.Y <= B.Y)
            //{
            //    if (y <= A.Y || y > B.Y ||
            //        x >= A.X && x >= B.X)
            //    {
            //        return false;
            //    }
            //    else if (x < A.X && x < B.X)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return (y - A.Y) / (x - A.X) > (B.Y - A.Y) / (B.X - A.X);
            //    }
            //}
            //else
            //{
            //    return GetWest(B, A, x, y);
            //}

            if (((A.Y > y) != (B.Y > y)) && (x < (B.X - A.X) * (y - A.Y) / (B.Y - A.Y) + A.X))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
