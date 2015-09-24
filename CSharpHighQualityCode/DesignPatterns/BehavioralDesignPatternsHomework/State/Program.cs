namespace State
{
    public class Program
    {
        public static void Main()
        {
            var player = new DVDPlayer();

            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }
    }
}







