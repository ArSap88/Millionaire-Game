using System;

namespace Millionaire_Game
{
    class Program
    {
        internal static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Добро пожаловать в игру: <Кто хочет стать миллионером?>");
            Console.WriteLine(" ");
            Console.WriteLine("Наберите текст в <...>:");
            Console.WriteLine("<правила> - прочитать правила игры");
            Console.WriteLine("<начать> - начать игру");
            InsideMap map = new InsideMap();
            string from = map.FromMain;
            UserInput input = new UserInput();
            input.ReceiveInput(from);
        }
    }
}
