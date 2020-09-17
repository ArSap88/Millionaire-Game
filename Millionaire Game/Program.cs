using System;
using System.IO;

namespace Millionaire_Game
{
    class Program
    {
        internal static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Directory.CreateDirectory(MainGame.SaveLocation);
            Console.WriteLine("\t\t <Кто хочет стать миллионером?> " +
                " ");
            Console.WriteLine("Пожалуйста, введите имя:");
            string userName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Добро пожаловать, {0}.{1}Хотите начать новую игру или продолжить сохраненную?{1} <Новая> | <Загрузить>", userName, Environment.NewLine);
            string whatNext = Console.ReadLine();
            UserInputCheck nextMoveChk = new UserInputCheck();
            nextMoveChk.WordCheck(whatNext, InsideMap.FromMain, userName);
            if (!UserInputCheck.Quit)
            {
                MainGame start = new MainGame();
                start.GameInit(userName);
            }
        }
    }
}
