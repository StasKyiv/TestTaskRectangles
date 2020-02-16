using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestRectangle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SortClass sort = new SortClass();

            Point[] arrayPoint = new Point[]
            {new Point{ X = 60, Y = 40},
                new Point{ X = 10, Y = 30},
                new Point{ X = 40, Y = 30},
                new Point{ X = 50, Y = 5},
                new Point{ X = 50, Y = 60},
                new Point{ X = 40, Y = 60},
                new Point{ X = 20, Y = 50},
                new Point{ X = 50, Y = 45},
                new Point{ X = 40, Y = 45},
                new Point{ X = 10, Y = 40},
                new Point{ X = 55, Y = 35},
                new Point{ X = 35, Y = 35},
                new Point{ X = 65, Y = 25},
                new Point{ X = 25, Y = 25},
                new Point{ X = 40, Y = 20},
                new Point{ X = 30, Y = 20},
                new Point{ X = 10, Y = 20},
                new Point{ X = 50, Y = 10},
                new Point{ X = 30, Y = 10},
                new Point{ X = 10, Y = 10}
            };

            var arraySort = await Task.Run(() => sort.SortArray(arrayPoint));

            //await Task.Run(() => FindRectangle(arraySort));

            FindRectangle(arraySort);

            Console.ReadLine();
        }

        public static void FindRectangle(List<Rectangle> arraySort)
        {
            CalculateClass calculate = new CalculateClass();
            int count = 0;
            foreach (var item in arraySort)
            {
                if (calculate.IsRectangle(item))
                {
                    count++;
                    Console.WriteLine(new string('-', 80));
                    Console.WriteLine($"Rectangle`s number {count}");
                    Console.WriteLine($"Points: ({item.One.X};{item.One.Y}), ({item.Two.X};{item.Two.Y}), ({item.Three.X};{item.Three.Y}), " +
                        $"({item.Four.X};{item.Four.Y}),");
                }
            }
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Count of rectangles is: {count}");
        }
    }
}
