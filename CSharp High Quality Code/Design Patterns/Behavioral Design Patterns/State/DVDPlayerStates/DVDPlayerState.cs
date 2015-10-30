namespace State
{
    public abstract class DVDPlayerState
    {
        public abstract void PlayButtonPressed(DVDPlayer player);

        public abstract void MenuButtonPressed(DVDPlayer player);
    }
}
