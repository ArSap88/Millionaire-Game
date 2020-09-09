using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class TryAgain
    {
        internal void Again()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Вы можете загрузить сохраненную игру, начать новую игру или выйти из игры.\n <Загрузить> | <Новая> | <Выйти>");
            UserInput input = new UserInput();
            input.ReceiveInput(InsideMap.TryAgain);
        }
    }
}
