using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class AnswerCorrect : Answer
    {
        internal AnswerCorrect(string text) : base(text)
        {

        }
        internal override void Choice()
        {
            Console.WriteLine("Это правильный ответ!");            
        }
    }
}
