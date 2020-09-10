using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Millionaire_Game
{    
    class Load
    {
        private const string LoadLocation = @"C:\Games\Millionaire";
        internal static string UserFileName { get; private set; }
        private int Count = 4;
        internal void AskFileName()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Пожалуйста, введите имя файла:");
            string fileName = Console.ReadLine();
            LoadGame(fileName);
        }
        internal void LoadGame(string fileName)
        {
            string filePath = Path.Combine(LoadLocation, fileName, ".mil");//LoadLocation + @"\" + fileName + ".mil";
            FileInfo dataFile = new FileInfo(filePath);            
            if (!dataFile.Exists)
            {                
                while (Count > 0)
                {
                    if (Count == 1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Проверьте свои сохраненные игры в {0}. Игра закрывается.", LoadLocation);
                        break;
                    }
                    Console.WriteLine(" ");
                    Count -= 1;
                    Console.WriteLine("У Вас нет сохраненной игры с таким именем... Введите имя файла еще раз.\n Осталось попыток : {0}", Count);                    
                    AskFileName();
                }                
            }
            //FileStream loadDataStream = dataFile.OpenRead();
            //StreamReader myStream = new StreamReader(loadDataStream, Encoding.Default);
            //string userName = myStream.ReadLine();
            //string userScore = myStream.ReadLine();
            //string lastQuestion = myStream.ReadLine();
            //int score = Convert.ToInt32(userScore);
            //int qNum = Convert.ToInt32(lastQuestion);
            string[] userData = new string[3];
            userData = File.ReadAllLines(filePath, Encoding.Default);
            string userName = userData[0];
            int score = Convert.ToInt32(userData[1]);
            int qNum = Convert.ToInt32(userData[2]);
            MainGame continueGame = new MainGame();
            continueGame.GameEngine(userName, score, qNum);
        }
        internal void AskToLoad(string userName)
        {
            string filePath = LoadLocation + @"\" + userName + ".mil";
            FileInfo dataFile = new FileInfo(filePath);
            if (dataFile.Exists)
            {
                UserFileName = userName;
                UserInput uInput = new UserInput();
                Console.WriteLine("У Вас есть сохраненная игра. Загрузить?\n <Да> | <Нет>");
                uInput.ReceiveInput(InsideMap.AskToLoad);
            }
        }
    }
}
