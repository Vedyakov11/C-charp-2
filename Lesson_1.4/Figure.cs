using System;

namespace Lesson_1._4
{
    class Figure
    {
        Point[] points;

        string type;

        public string  Type
        {
            get { return type; }
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - A.X, 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }

            sum += LengthSide(points[points.Length - 1], points[0]);

            Console.Write(sum);
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            type = "Triangle";
        }
    }
}
