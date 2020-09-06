using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class AnswerWrong : Answer
    {
        internal AnswerWrong(string text) : base(text)
        {

        }
        internal override void Choice()
        {
            Console.WriteLine("Ответ неправильный.");
        }
    }
}
