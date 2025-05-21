namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(Game.maxPlayerCount);
        }
    }

    class Game
    {
        public static int maxPlayerCount = 10;
    }

}
