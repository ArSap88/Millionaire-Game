using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class Question
    {
        internal string QText { get; set; }
        internal Answer[] Answers { get; set; }
        internal Question(string qtext)
        {
            this.QText = qtext;
        }
    }
}
