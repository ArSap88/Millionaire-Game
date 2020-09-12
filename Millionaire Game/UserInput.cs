using System;

namespace Millionaire_Game
{
    internal class UserInput
    {
        internal string ReceiveInput(string from)
        {            
            UserInputCheck userInputCheck = new UserInputCheck();
            string userInput = Console.ReadLine();
            userInputCheck.WordCheck(userInput, from);
            return userInput;
        }
    }
}