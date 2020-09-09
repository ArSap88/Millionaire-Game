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
            Console.WriteLine("Следуйте инструкциям на экране.\n" +
                "Для выбора ответа - введите номер выбранного варианта.\n" +                
                "Если вы не знаете ответ на вопрос - наберите <деньги> и заберите свой выигрыш.\n" +
                "После правильного ответа на первый вопрос, Вы сможете в любой момент сохранить свою игру, набрав <Сохранить>");
            Console.WriteLine(" ");
        }
    }
}
