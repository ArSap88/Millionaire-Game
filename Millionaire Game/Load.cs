using System;
using System.IO;
using System.Text;

namespace Millionaire_Game
{    
    class Load
    {        
        internal static string UserFileName { get; private set; }
        private int Count = 4;
        private void AskFileName()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Пожалуйста, введите имя файла без <.mil>:");
            string fileName = Console.ReadLine();
            LoadGame(fileName);
        }
        internal void LoadGame(string fileName)
        {
            string filePath = Path.Combine(MainGame.SaveLocation, fileName, ".mil"); //
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
                    Console.WriteLine("У Вас нет сохраненной игры с таким именем... Введите имя файла еще раз.\n Осталось попыток : {0}", Count);                    
                    AskFileName();
                }                
            }            
            string[] userData = File.ReadAllLines(filePath, Encoding.Default);
            string userName = userData[0];
            int score = Convert.ToInt32(userData[1]);
            int qNum = Convert.ToInt32(userData[2]);
            MainGame continueGame = new MainGame();
            continueGame.GameEngine(userName, score, qNum);
        }
        internal void AskToLoad()
        {
            DirectoryInfo gameSaveFolder = new DirectoryInfo(MainGame.SaveLocation);
            FileInfo[] saveFiles = gameSaveFolder.GetFiles();
            Console.WriteLine("Найдено {0} файлов.", saveFiles.Length);
            foreach (FileInfo info in saveFiles)
            {
                Console.WriteLine("\n Имя файла: {0}\n Дата: {1}", info.Name, info.CreationTime);
            }
            AskFileName();
        }
    }
}
