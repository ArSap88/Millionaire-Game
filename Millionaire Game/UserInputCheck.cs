using System;

namespace Millionaire_Game
{
    class UserInputCheck
    {
        private string Error;
        internal static bool Quit { get; private set; } = false;
        internal void WordCheck(string word, string from)
        {            
            if (from == InsideMap.FromGameInit)
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
        internal void WordCheck(string word, string from, string userName)
        {
            if (from == InsideMap.FromMain)
            {
                FromMain(word, userName);
            }
        }
        private void FromMain(string userInput, string userName)
        {
            if (string.Equals(userInput, InsideMap.NewGame, StringComparison.OrdinalIgnoreCase))
            {
                MainGame startNew = new MainGame();
                startNew.GameInit(userName);
            }
            else if (string.Equals(userInput, InsideMap.LoadGame, StringComparison.OrdinalIgnoreCase))
            {
                Load.AskToLoad();
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
                InputError(InsideMap.FromGameInit);
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
                //Just returns back
            }
            else
            {
                InputError(InsideMap.FromGameEngine);
            }
        }
        private void FromTryAgain(string userInput)
        {
            if (string.Equals(userInput, InsideMap.NewGame, StringComparison.OrdinalIgnoreCase))
            {
                Program.Main();
            }
            else if (string.Equals(userInput, InsideMap.LoadGame, StringComparison.OrdinalIgnoreCase))
            {
                Load.AskToLoad();
            }
            else if (string.Equals(userInput, InsideMap.Quit, StringComparison.OrdinalIgnoreCase))
            {
                Quit = true;
            }
            else
            {
                InputError(InsideMap.TryAgain);
            }
        }
        private void FromLoad(string userInput, string userName)
        {
            if (string.Equals(userInput, InsideMap.Yes, StringComparison.OrdinalIgnoreCase))
            {
                Load.AskToLoad();
            }
            if (string.Equals(userInput, InsideMap.No, StringComparison.OrdinalIgnoreCase))
            {
                MainGame start = new MainGame();
                start.GameInit(userName);
            }
        }
        private void InputError(string from)
        {
            UserInput newinput = new UserInput();
            Console.WriteLine("Возможно Вы ошиблись. Пожалуйста, повторите ввод:");
            newinput.ReceiveInput(from);
        }
    }    
}
