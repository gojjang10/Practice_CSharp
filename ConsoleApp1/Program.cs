namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Game game1 = new Game();
            Console.WriteLine();
        }
    }

    class Game
    {
        public static int x = 0;
        static int y = 0;
        static Game()
        {
            x++;
            Console.WriteLine($"x의 값은? {x}");
        }

        public Game()
        {
            y++;
            Console.WriteLine($"y의 값은? {y}");
        }
    }

}
