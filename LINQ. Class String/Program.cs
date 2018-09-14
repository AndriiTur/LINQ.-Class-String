using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Class_String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task8_1
            //List<int> digits = new List<int>();
            //Random rand = new Random();
            
            //for (int i = 0; i < 10; i++)
            //{
            //    digits.Add(rand.Next(-20, 21));
            //}

            //foreach (int dig in digits)
            //    Console.WriteLine("All digit(s) from list: {0}", dig);

            //Console.WriteLine("");

            //IEnumerable<int> digitLessThanZero =
            //                   digits.Where(i => i < 0);

            //foreach (int dig in digitLessThanZero)
            //    Console.WriteLine("Negativ digit(s) from list: {0}", dig);

            //Console.WriteLine("");

            //IEnumerable<int> pairedDigits =
            //                   digits.Where(i => i > 0 && i % 2 == 0);

            //foreach (int dig in pairedDigits)
            //    Console.WriteLine("Paired digit(s) from list: {0}", dig);

            //Console.WriteLine("\nMax digit(s) from list: {0}", digits.Max());
            //Console.WriteLine("\nMin digit(s) from list: {0}", digits.Min());

            //var sum = digits.Sum(x => x);
            //Console.WriteLine("\nSum digit(s) from list: {0}", sum);

            //Console.WriteLine("\nDigits AVG from list: {0}", digits.Average());
            //Console.WriteLine("\nLess than AVG digit from list: {0}", digits.First(i => i < digits.Average()));

            //Console.WriteLine("");

            //var sorted = from digit in digits
            //              orderby digit
            //              select digit;

            //foreach (int dig in sorted)
            //    Console.WriteLine("Sorted digit from list: {0}", dig);

            //Console.ReadKey();
            #endregion

            #region HomeWork8_A
            Shape shapMaxPerim = new Circle("null", 0);
            List<Shape> myShapes = new List<Shape>();

            myShapes.Add(new Circle("C001", 10));
            myShapes.Add(new Circle("C003", 3));
            myShapes.Add(new Circle("C004", 4));
            myShapes.Add(new Square("S001", 10));
            myShapes.Add(new Square("S004", 4));
            myShapes.Add(new Square("S005", 5));

            var shapesAreaRank = from shape in myShapes
                                 where shape.Area() >= 10 && shape.Area() <= 100
                                 select new { name = shape.Name, area = shape.Area() };

            foreach (var shape in shapesAreaRank)
                Console.WriteLine("Shapes Where Area in [10,100]: {0} = {1}", shape.name, shape.area);

            Console.WriteLine("");

            var shapesContainsLeterA = from shape in myShapes
                                       where shape.Name.Contains('a')
                                       select shape.Name;

            foreach (var shape in shapesContainsLeterA)
                Console.WriteLine("Shapes Where conatains 'a' in name: {0}", shape);

            myShapes.RemoveAll(x => x.Perimeter() < 5);

            foreach (var shape in myShapes)
                Console.WriteLine("Shapes without shape where with perimeter < 5: {0} = {1}", shape.Name, shape.Perimeter());

            Console.ReadKey();
            #endregion
        }
    }

    public abstract class Shape
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        double radius;
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }

    public class Square : Shape
    {
        double side;
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return this.side * this.side;
        }

        public override double Perimeter()
        {
            return this.side * 4;
        }
    }
}
