using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    abstract class Answer
    {
        internal string AText { get; set; }
        internal Answer(string text)
        {
            AText = text;
        }
        internal abstract void Choice();
    }
}
