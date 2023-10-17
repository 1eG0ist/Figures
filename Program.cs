namespace Figures
{
    class Program
    {
        static void Main()
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Square> squares = new List<Square>();
            List<Circle> circles = new List<Circle>();
            List<Triangle> triangles = new List<Triangle>();
            string enter_info;
            while (true)
            {
                Console.Clear();
                PrintFigures(rectangles, squares, circles, triangles);
                Console.WriteLine("R - create rectangle\nS - create square\nC - create circle\nT - create triangle\n" +
                                  "A - show perimeter\nD - show square");
                ConsoleKey input_key = Console.ReadKey().Key;
                Console.WriteLine("\n");
                switch (input_key)
                {
                    case ConsoleKey.R:
                        Console.WriteLine("Enter string with points coords (x y) from bottom left to top left to top " +
                                          "right to bottom right point, enter only digits and spaces: ");
                        try
                        {
                            rectangles.Add(new Rectangle(Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray()));
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
                            squares.Add(new Square(Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray()));
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }
                        break;
                    
                    case ConsoleKey.C:
                        Console.WriteLine("Enter coords (x y) of circle center, then enter radius, for example 3.1 1.4 7.2: ");
                        try
                        {
                            circles.Add(new Circle(Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray()));
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }
                        break;
                    
                    case ConsoleKey.T:
                        Console.WriteLine("Enter string with points coords (x y) from left to right by x vector, enter only digits and spaces: ");
                        try
                        {
                            triangles.Add(new Triangle(Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray()));
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }
                        break;
                    
                    case ConsoleKey.A:
                        
                        Console.WriteLine("Enter first symbol of figure type and number of figure like t3 or r1: ");
                        enter_info = Console.ReadLine().ToLower();
                        try
                        {
                            switch (enter_info[0])
                            {
                                case 'r':
                                    Console.WriteLine(rectangles[int.Parse(enter_info[1].ToString())-1].CalcPerimeter());
                                    break;
                            
                                case 's':
                                    Console.WriteLine(squares[int.Parse(enter_info[1].ToString())-1].CalcPerimeter());
                                    break;
                            
                                case 'c':
                                    Console.WriteLine(circles[int.Parse(enter_info[1].ToString())-1].CalcPerimeter());
                                    break;
                            
                                case 't':
                                    Console.WriteLine(triangles[int.Parse(enter_info[1].ToString())-1].CalcPerimeter());
                                    break;
                            }
                            Console.WriteLine("Enter any key to continue: ");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong! Press any key to continue: ");
                            Console.ReadKey();
                        }
                        break;
                    
                    case ConsoleKey.D:
                        Console.WriteLine("Enter first symbol of figure type and number of figure like t3 or r1: ");
                        enter_info = Console.ReadLine().ToLower();
                        try
                        {
                            switch (enter_info[0])
                            {
                                case 'r':
                                    Console.WriteLine(rectangles[int.Parse(enter_info[1].ToString())-1].CalcSquare());
                                    break;
                            
                                case 's':
                                    Console.WriteLine(squares[int.Parse(enter_info[1].ToString())-1].CalcSquare());
                                    break;
                            
                                case 'c':
                                    Console.WriteLine(circles[int.Parse(enter_info[1].ToString())-1].CalcSquare());
                                    break;
                            
                                case 't':
                                    Console.WriteLine(triangles[int.Parse(enter_info[1].ToString())-1].CalcSquare());
                                    break;
                            }
                            Console.WriteLine("Enter any key to continue: ");
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

        static void PrintFigures(List<Rectangle> rectangles, List<Square> squares, List<Circle> circles,
            List<Triangle> triangles)
        {
            Console.Write("Rectangles :");
            for (int i = 0; i < rectangles.Count; i++)
            {
                Console.Write($"Rect{i+1}");
                if (i != rectangles.Count - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            
            Console.Write("Squares :");
            for (int i = 0; i < squares.Count; i++)
            {
                Console.Write($"Square{i+1}");
                if (i != squares.Count - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            
            Console.Write("Circles :");
            for (int i = 0; i < circles.Count; i++)
            {
                Console.Write($"Circle{i+1}");
                if (i != circles.Count - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            
            Console.Write("Triangles :");
            for (int i = 0; i < triangles.Count; i++)
            {
                Console.Write($"Trian{i+1}");
                if (i != triangles.Count - 1) Console.Write(" | ");
            }
            Console.WriteLine();
        }
    }
};