namespace Facade
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Game game = Game.CreateInstance();

            Console.WriteLine(new string('*', 10) + "Updating Game" + new string('*', 10));
            game.UpdateGame();

            Console.WriteLine();
            Console.WriteLine(new string('*', 10) + "Connecting To Server" + new string('*', 10));
            game.ConnectToServer();

            Console.WriteLine();
            Console.WriteLine(new string('*', 10) + "Initialize Game" + new string('*', 10));
            game.InitializeGame();
        }
    }
}
