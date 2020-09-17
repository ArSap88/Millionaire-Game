using System;

namespace Millionaire_Game
{
    static class Player
    {
        internal static string Name { get; set; }        
        internal static int Score { get; set; }        
        internal static void ScoreMult()
        {
            Score *= 2;
        }
        internal static void ScoreZero(string reason)
        {
            Score = 0;
            if (reason == InsideMap.Money)
            {
                PlayerWin();
            }
            if (reason == InsideMap.UserLost)
            {
                PlayerLost();
            }            
        }
        private static void PlayerLost()
        {
            Console.WriteLine("Вы проиграли. Ваш выигрыш: {0} ", Score);
        }
        internal static void PlayerWin()
        {
            Console.WriteLine("Вы выиграли: {0} руб{1} До новых встреч!", Score, Environment.NewLine);
        }        
    }
}
