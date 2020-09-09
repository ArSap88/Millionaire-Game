using System;

namespace Millionaire_Game
{
    class Program
    {
        internal static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\tДобро пожаловать в игру: <Кто хочет стать миллионером?>\n " +
                " ");            
            Console.WriteLine("Пожалуйста, введите имя:");
            string userName = Console.ReadLine();
            UserInputCheck nameChk = new UserInputCheck();
            nameChk.WordCheck(userName, InsideMap.FromMain);
            if (!UserInputCheck.Quit)
            {
                MainGame start = new MainGame();
                start.GameInit(userName);
            }                        
        }
    }
}
