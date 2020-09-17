using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class Rules
    {
        internal void ShowRules()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Следуйте инструкциям на экране.{0}" +
                "Для выбора ответа - введите номер выбранного варианта.{0}" +                
                "Если вы не знаете ответ на вопрос - наберите <деньги> и заберите свой выигрыш.{0}" +
                "После правильного ответа на первый вопрос, Вы сможете в любой момент сохранить свою игру, набрав <Сохранить>", Environment.NewLine);
            Console.WriteLine(" ");
        }
    }
}
