using System;
using System.Security;

namespace Millionaire_Game
{
    internal class UserInput
    {
        internal string ReceiveInput(string fromwhere)
        {            
            UserInputCheck userInputCheck = new UserInputCheck();
            string userInput = Console.ReadLine();
            userInputCheck.WordCheck(userInput, fromwhere);
            return userInput;
        }
    }
}