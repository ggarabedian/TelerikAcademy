namespace State
{
    using System;

    public class MoviePausedState : DVDPlayerState
    {
        public MoviePausedState()
        {
            Console.WriteLine("MOVIE PAUSED");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePlayingState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }
}
