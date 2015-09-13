namespace CreationalPatterns.Singleton
{
    using System;

    public sealed class GameManager
    {
        public static volatile GameManager gameManager;

        private static readonly object syncLock = new object();

        private GameManager()
        {
        }

        public static GameManager Instance
        {
            get
            {
                if (gameManager == null)
                {
                    lock (syncLock)
                    {
                        if (gameManager == null)
                        {
                            gameManager = new GameManager();
                        }
                    }
                }

                return gameManager;
            }

        }

        public void PopulateBattleField()
        {
            throw new NotImplementedException();
        }

        public void GetCurrentActivePlayer()
        {
            throw new NotImplementedException();
        }

        public void ClearBattleField()
        {
            throw new NotImplementedException();
        }
    }
}
