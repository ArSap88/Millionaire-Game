using System;
using System.IO;
using System.Text;

namespace Millionaire_Game
{    
    static class Load
    {        
        internal static string UserFileName { get; private set; }
        private static int Count = 4;
        private static  void AskFileName()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Пожалуйста, введите имя файла с расширением:");
            string fileName = Console.ReadLine();
            LoadGame(fileName);
        }
        internal static void LoadGame(string fileName)
        {
            string filePath = Path.Combine(MainGame.SaveLocation, fileName); //, ".mil" Не понимаю почему перестала работать эта строка. Если вернуть .mil перестает работать.
            FileInfo dataFile = new FileInfo(filePath);            
            if (!dataFile.Exists)
            {                
                while (Count > 0)
                {
                    if (Count == 1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Проверьте свои сохраненные игры в {0}. Игра закрывается.", MainGame.SaveLocation);
                        break;
                    }
                    Console.WriteLine(" ");
                    Count -= 1;
                    Console.WriteLine("У Вас нет сохраненной игры с таким именем... Введите имя файла еще раз.{0} Осталось попыток : {1}", Environment.NewLine, Count);                    
                    AskFileName();
                }                
            }            
            string[] userData = File.ReadAllLines(filePath, Encoding.Default);
            string userName = userData[0];            
            int qNum = Convert.ToInt32(userData[1]);
            MainGame continueGame = new MainGame();
            continueGame.GameEngine(userName, qNum);
        }
        internal static void AskToLoad()
        {
            DirectoryInfo gameSaveFolder = new DirectoryInfo(MainGame.SaveLocation);
            FileInfo[] saveFiles = gameSaveFolder.GetFiles();
            Console.WriteLine("Найдено {0} файлов.", saveFiles.Length);
            foreach (FileInfo info in saveFiles)
            {
                Console.WriteLine("{0} Имя файла: {1}{0} Дата: {2}", Environment.NewLine, info.Name, info.CreationTime);
            }
            AskFileName();
        }
    }
}
