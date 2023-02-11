namespace New_4_1_17_swift_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your color: ");
            string color = new (Console.ReadLine());

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;


                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "darkblue":
                    Console.BackgroundColor = ConsoleColor.DarkBlue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "violet":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "white":
                    Console.BackgroundColor = ConsoleColor.White; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                default:
                    Console.WriteLine("Sorry color {0} not found in database", color);
                    break;
            }
            Console.ReadKey();
        }
    }
}