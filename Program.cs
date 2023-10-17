namespace Figures
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle;
            Square square;
            Circle circle;
            Triangle triangle;
            Pyramid pyramid;

            string enter_info;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("R - create rectangle\nS - create square\nC - create circle\nT - create triangle\nP - create pyramid");
                ConsoleKey input_key = Console.ReadKey().Key;
                Console.WriteLine("\n");
                switch (input_key)
                {
                    case ConsoleKey.R:
                        Console.WriteLine("Enter string with points coords (x y) from bottom left to top left to top " +
                                          "right to bottom right point, enter only digits and spaces: ");
                        try
                        {
                            rectangle = new Rectangle(Console.ReadLine().Split(' ').Select(x => float.Parse(x))
                                .ToArray());
                            Console.WriteLine(rectangle.ShowInfo());
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }

                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("Enter string with only two points coords (x y) first is bottom left, " +
                                          "second is top right, enter only digits and spaces: ");
                        try
                        {
                            square = new Square(Console.ReadLine().Split(' ').Select(x => float.Parse(x))
                                .ToArray());
                            Console.WriteLine(square.ShowInfo());
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }

                        break;

                    case ConsoleKey.C:
                        Console.WriteLine(
                            "Enter coords (x y) of circle center, then enter radius, for example 3.1 1.4 7.2: ");
                        try
                        {
                            circle = new Circle(Console.ReadLine().Split(' ').Select(x => float.Parse(x))
                                .ToArray());
                            Console.WriteLine(circle.ShowInfo());
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }

                        break;

                    case ConsoleKey.T:
                        Console.WriteLine(
                            "Enter string with points coords (x y) from left to right by x vector, enter only digits and spaces: ");
                        try
                        {
                            triangle = new Triangle(Console.ReadLine().Split(' ').Select(x => float.Parse(x))
                                .ToArray());
                            Console.WriteLine(triangle.ShowInfo());
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }

                        break;
                    
                    case ConsoleKey.P:
                        Console.WriteLine(
                            "Enter string with points coords (x y) from left to right by x vector if have triangle bottom " +
                            "and from bottom left to top left to top right to bottom right point if have square bottom, " +
                            "then enter height of pyramid, enter only digits and spaces: ");
                        try
                        {
                            float[] info = Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray();
                            pyramid = new Pyramid(info.Skip(0).Take(info.Length-1).ToArray(), info[info.Length-1]);
                            Console.WriteLine(pyramid.ShowInfo());
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }

                        break;
                }
            }
        }
    }
};