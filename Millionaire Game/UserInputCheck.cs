using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class UserInputCheck
    {        
        internal void WordCheck(string word, string fromwhere)
        {
            InsideMap map = new InsideMap();            
            UserInput newinput = new UserInput();
            Database newGame = new Database();
            string error;
            if (fromwhere == map.FromMain)
            {
                Rules rules = new Rules();
                if (string.Equals(word, map.ShowRules, StringComparison.OrdinalIgnoreCase))
                {
                    rules.ShowRules();
                    newGame.QandA();
                }
                else if (string.Equals(word, map.BeginGame, StringComparison.OrdinalIgnoreCase))
                {
                    newGame.QandA();
                }
                else
                {
                    error = map.FromMain;
                    Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                    newinput.ReceiveInput(error);
                }
            }
            else if (fromwhere == map.FromGameEngine)
            {                
                if (string.Equals(word, map.AnswerOne, StringComparison.Ordinal) 
                    || string.Equals(word, map.AnswerTwo, StringComparison.Ordinal)
                    || string.Equals(word, map.AnswerThree, StringComparison.Ordinal)
                    || string.Equals(word, map.AnswerFour, StringComparison.Ordinal)
                    || string.Equals(word, map.Money, StringComparison.OrdinalIgnoreCase))
                {
                    //Code here is not needed. Program just returns back. This part could be optimized with "!=", but I don't know how to use "!=" with "string.Equals..."
                }
                else
                {
                    error = map.FromGameEngine;
                    Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                    newinput.ReceiveInput(error);
                }
            }            
            else if (fromwhere == map.TryAgain)
            {
                if (word == map.TryAgainYes)
                {
                    Program.Main();
                }
                else if (word == map.TryAgainNo)
                {
                    Goodbye bye = new Goodbye();
                    bye.Bye();
                }
                else
                {
                    error = map.TryAgain;
                    Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                    newinput.ReceiveInput(error);
                }
            }
        }
    }
}
