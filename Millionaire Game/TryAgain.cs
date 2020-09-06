using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class TryAgain
    {
        internal void Again()
        {
            InsideMap map = new InsideMap();
            string from = map.TryAgain;
            Console.WriteLine(" ");
            Console.WriteLine("Хотите попробовать еще раз? <да> | <нет>");
            UserInput input = new UserInput();
            input.ReceiveInput(from);
        }
    }
}
