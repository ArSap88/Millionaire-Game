using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class TryAgain
    {
        internal static void Again()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Вы можете загрузить сохраненную игру, начать новую игру или выйти из игры.{0} <Загрузить> | <Новая> | <Выйти>", Environment.NewLine);
            UserInput input = new UserInput();
            input.ReceiveInput(InsideMap.TryAgain);
        }
    }
}
