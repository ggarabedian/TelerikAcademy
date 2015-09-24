namespace State
{
    using System;

    public class MenuState : DVDPlayerState
    {
        public MenuState()
        {
            Console.WriteLine("MENU");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            Console.WriteLine("  Next Menu Item Selected");
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new StandbyState();
        }
    }
}
