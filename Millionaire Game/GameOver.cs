using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class GameOver
    {
        internal void UserLost(int score)
        {            
            Console.WriteLine("Вы проиграли. Ваш выигрыш: {0}", score);
        }
    }
}
