using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region smth
            /*Console.WriteLine("Add the coordinates of central point of circle please: ");
           double x = Convert.ToDouble(Console.ReadLine());
           double y = Convert.ToDouble(Console.ReadLine());
           Point centralPoint = new Point(x, y);

           Console.WriteLine("Now add any other point of circle: ");
           double a = Convert.ToDouble(Console.ReadLine());
           double b = Convert.ToDouble(Console.ReadLine());

           Point otherPoint = new Point(a, b);

           List<Point> points = new List<Point>();

           points.Add(centralPoint);
           points.Add(otherPoint);

           Circle circle = new Circle(points);
           circle.FindArea();

           StreamWriter writer = new StreamWriter("wassup.txt", false);
           writer.Write(circle.radius);
           writer.Close();

           using (StreamReader reader = new StreamReader("wassup.txt"))
           {
               string line;
               while((line = reader.ReadLine()) != null)
               {
                   Console.WriteLine(line);
               }
           } ;*/
            #endregion

            #region rectanglesmth
            Point leftUp = new Point(2, 2);
            Point leftDown = new Point(2, -2);
            Point rightUp = new Point(5, 2);
            Point rightDown = new Point(5, -2);

             List<Point> rectanglePoints = new List<Point>();
            rectanglePoints.Add(leftUp);
            rectanglePoints.Add(leftDown);
            rectanglePoints.Add(rightUp);
            rectanglePoints.Add(rightDown);

            Rectangle rectangle = new Rectangle(rectanglePoints);
            rectangle.FindCenter();
            Console.WriteLine(rectanglePoints[0].x + " " + rectanglePoints[0].y + " " + rectanglePoints[2].x + " " + rectanglePoints[2].y);
            rectangle.FindArea();
            Console.WriteLine(rectangle.Area);
            rectangle.Scale(2);
            Console.WriteLine();
            Console.WriteLine(rectanglePoints[0].x + " " + rectanglePoints[0].y + " " + rectanglePoints[2].x + " " + rectanglePoints[2].y);
            Console.WriteLine(rectangle.Area);
            #endregion


        }
    }
}
