using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class Winner
    {
        internal void YouWin(int score)
        {            
            Console.WriteLine("Вы выиграли: {0} руб", score);
        }
    }
}
