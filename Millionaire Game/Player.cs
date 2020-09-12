using System;

namespace Millionaire_Game
{
    class Player
    {
        internal string Name { get; set; }        
        internal int Score { get; set; }
        internal static string[] UserData = new string[3];
        internal void ScoreMult()
        {
            Score *= 2;
        }
        internal void ScoreZero(string reason)
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
        private void PlayerLost()
        {
            Console.WriteLine("Вы проиграли. Ваш выигрыш: {0} ", Score);
        }
        internal void PlayerWin()
        {
            Console.WriteLine("Вы выиграли: {0} руб\n До новых встреч!", Score);
        }
        internal void FillUserDataArray(string userName, int uScore, int qNum)
        {
            string userScore = Convert.ToString(uScore);
            string qNumber = Convert.ToString(qNum);
            UserData[0] = userName;
            UserData[1] = userScore;
            UserData[2] = qNumber;
        }

    }
}
