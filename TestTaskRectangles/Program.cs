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
            {new Point{ X = 200, Y = 300},
             new Point{ X = 400, Y = 100},
             new Point{ X = 700, Y = 400},
             new Point{ X = 500, Y = 600},
             new Point{ X = 53, Y = 40},
             new Point{ X = 10, Y = 10},
             new Point{ X = 10, Y = 20},
             new Point{ X = 20, Y = 10},
             new Point{ X = 20, Y = 20},
             new Point{ X = 54, Y = 40}
            };

            var arraySort = await Task.Run(() => sort.SortArray(arrayPoint));

            await Task.Run(() => FindRectangle(arraySort));

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
