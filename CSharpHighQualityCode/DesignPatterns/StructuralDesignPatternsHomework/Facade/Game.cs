namespace Facade
{
    using System;

    public class Game
    {
        private Game()
        {         
        }

        public static Game CreateInstance()
        {
            return new Game();
        }

        public void UpdateGame()
        {
            Console.WriteLine("Connecting to server...");
            Console.WriteLine("Downloading update...");
            Console.WriteLine("Extracting update...");
            Console.WriteLine("Installing update...");
            Console.WriteLine("Restarting game");
        }

        public void ConnectToServer()
        {
            Console.WriteLine("Checking internet connection...");
            Console.WriteLine("Searching for server...");
            Console.WriteLine("Attempt to establish connection with server...");
            Console.WriteLine("Server joined");
        }

        public void InitializeGame()
        {
            Console.WriteLine("Initialize level...");
            Console.WriteLine("Initialize enemy models...");
            Console.WriteLine("Initialize pickups...");
            Console.WriteLine("Initialize player models...");
            Console.WriteLine("Establishing spawn points...");
            Console.WriteLine("Spawning enemies...");
            Console.WriteLine("Spawning pickups...");
            Console.WriteLine("Spawning player...");
            Console.WriteLine("Game started");
        }
    }
}