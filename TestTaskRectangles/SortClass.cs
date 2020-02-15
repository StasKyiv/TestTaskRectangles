using System;
using System.Collections.Generic;
using System.Text;

namespace TestRectangle
{
    public class SortClass
    {
        public List<Rectangle> SortArray(Point[] array)
        {
            Rectangle rectangle;

            List<Rectangle> result = new List<Rectangle>();

            for (int a = 0; a < array.Length - 3; a++)
            {
                for (int b = a + 1; b < array.Length - 2; b++)
                {
                    for (int c = b + 1; c < array.Length - 1; c++)
                    {
                        for (int d = c + 1; d < array.Length; d++)
                        {
                            rectangle = new Rectangle()
                            {
                                One = array[a],
                                Two = array[b],
                                Three = array[c],
                                Four = array[d]
                            };
                            result.Add(rectangle);
                        }
                    }
                }
            }

            return result;
        }
    }
}
