using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class UserInputCheck
    {
        private string Error;
        internal static bool Quit { get; private set; } = false;
        internal void WordCheck(string word, string from)
        {
            if (from == InsideMap.FromMain)
            {                
                Load askUser = new Load();
                askUser.AskToLoad(word);                
            }
            else if (from == InsideMap.FromGameInit)
            {
                FromGameInit(word);
            }
            else if (from == InsideMap.FromGameEngine)
            {
                FromGameEngine(word);
            }
            else if (from == InsideMap.TryAgain)
            {
                FromTryAgain(word);
            }
            else if (from == InsideMap.AskToLoad)
            {
                FromLoad(word, Load.UserFileName);
            }            
        }
        private void FromGameInit(string userInput)
        {
            if (string.Equals(userInput, InsideMap.Yes, StringComparison.OrdinalIgnoreCase))
            {
                Rules rules = new Rules();
                rules.ShowRules();
            }
            else if (string.Equals(userInput, InsideMap.No, StringComparison.OrdinalIgnoreCase))
            {
                //return and continue game
            }            
            else
            {
                UserInput newinput = new UserInput();
                Error = InsideMap.FromGameInit;
                Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                newinput.ReceiveInput(Error);
            }
        }
        private void FromGameEngine(string userInput)
        {
            if (string.Equals(userInput, InsideMap.AnswerOne, StringComparison.Ordinal)
                    || string.Equals(userInput, InsideMap.AnswerTwo, StringComparison.Ordinal)
                    || string.Equals(userInput, InsideMap.AnswerThree, StringComparison.Ordinal)
                    || string.Equals(userInput, InsideMap.AnswerFour, StringComparison.Ordinal)
                    || string.Equals(userInput, InsideMap.Money, StringComparison.OrdinalIgnoreCase)
                    || string.Equals(userInput, InsideMap.SaveGame, StringComparison.OrdinalIgnoreCase))
            {
                
            }
            else
            {
                UserInput newinput = new UserInput();
                Error = InsideMap.FromGameEngine;
                Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                newinput.ReceiveInput(Error);
            }
        }
        private void FromTryAgain(string userInput)
        {
            if (string.Equals(userInput, InsideMap.TryAgainNewGame, StringComparison.OrdinalIgnoreCase))
            {
                Program.Main();
            }
            else if (string.Equals(userInput, InsideMap.LoadGame, StringComparison.OrdinalIgnoreCase))
            {
                Load loadFile = new Load();
                loadFile.AskFileName();
            }
            else if (string.Equals(userInput, InsideMap.Quit, StringComparison.OrdinalIgnoreCase))
            {
                Quit = true;
            }
            else
            {
                UserInput newinput = new UserInput();
                Error = InsideMap.TryAgain;
                Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
                newinput.ReceiveInput(Error);
            }
        }
        private void FromLoad(string userInput, string userName)
        {
            if (string.Equals(userInput, InsideMap.Yes, StringComparison.OrdinalIgnoreCase))
            {
                Load load = new Load();
                load.LoadGame(userName);
            }
            if (string.Equals(userInput, InsideMap.No, StringComparison.OrdinalIgnoreCase))
            {
                MainGame start = new MainGame();
                start.GameInit(userName);
            }
        }
    }    
}
