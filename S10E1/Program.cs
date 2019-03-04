using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using S10E1.Entities;
using S10E1.Entities.Enums;

namespace S10E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c): ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Color (Black / Blue / Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape areas:");

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
