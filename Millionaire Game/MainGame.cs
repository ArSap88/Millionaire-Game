using System;

namespace Millionaire_Game
{
    class MainGame
    {
        internal static string SaveLocation = @"C:\Games\Millionaire";
        internal static int QuestionNumber { get; private set; }
        internal void GameInit(string userName)
        {
            Console.WriteLine(" ");            
            Console.WriteLine("Хотите прочитать правила игры?{0} <Да> | <Нет>", Environment.NewLine);
            UserInput showRules = new UserInput();
            showRules.ReceiveInput(InsideMap.FromGameInit);            
            int initialQuestion = 0;
            GameEngine(userName, initialQuestion);
        }
        internal void GameEngine(string userName, int qNumber)
        {
            Player.Name = userName;
            Player.Score = 50;
            if (qNumber > 0)
            {
                int smth = 1;
                while (smth < qNumber)
                {
                    Player.ScoreMult();
                    smth++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ну что, {0}, готовы начать?{1} Итак:", Player.Name, Environment.NewLine);
            Database qBlock = new Database();
            qBlock.QandA();
            Question[] arr = new Question[5] { qBlock.Question1, qBlock.Question2, qBlock.Question3, qBlock.Question4, qBlock.Question5 };
            UserInput input = new UserInput();
            TryAgain again = new TryAgain();
            Answer userChoice;
            bool stopCycle;
            for (int i = qNumber; i < arr.Length; i++)
            {
                QuestionNumber = i;
                Console.WriteLine(" ");
                Console.WriteLine(arr[i].QText);
                Console.WriteLine(" ");
                Console.WriteLine("1. " + arr[i].Answers[0].AText);
                Console.WriteLine("2. " + arr[i].Answers[1].AText);
                Console.WriteLine("3. " + arr[i].Answers[2].AText);
                Console.WriteLine("4. " + arr[i].Answers[3].AText);
                Console.WriteLine(" ");
                string userAnswer = input.ReceiveInput(InsideMap.FromGameEngine);
                if (userAnswer == InsideMap.AnswerOne)
                {
                    userChoice = arr[i].Answers[0];
                    stopCycle = ChkUserAnswer(userChoice, i, arr.Length);
                    if  (stopCycle)
                    {
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerTwo)
                {
                    userChoice = arr[i].Answers[1];
                    stopCycle = ChkUserAnswer(userChoice, i, arr.Length);
                    if (stopCycle)
                    {
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerThree)
                {
                    userChoice = arr[i].Answers[2];
                    stopCycle = ChkUserAnswer(userChoice, i, arr.Length);
                    if (stopCycle)
                    {
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerFour)
                {
                    userChoice = arr[i].Answers[3];
                    stopCycle = ChkUserAnswer(userChoice, i, arr.Length);
                    if (stopCycle)
                    {
                        break;
                    }                    
                }
                else if (string.Equals(userAnswer, InsideMap.Money, StringComparison.OrdinalIgnoreCase))
                {
                    if (i == 0)
                    {
                        Player.ScoreZero(InsideMap.Money);
                    }
                    Player.PlayerWin();                    
                    break;
                }
                else if (string.Equals(userAnswer, InsideMap.SaveGame, StringComparison.OrdinalIgnoreCase))
                {                    
                    Save.SaveFile(Player.Name);
                    i--;
                    Console.WriteLine("Игра сохранена.{0} Возвращаемся к последнему вопросу:", Environment.NewLine);
                }
            }
        }
        private bool ChkUserAnswer(Answer userChoice, int i, int arrLength)
        {
            userChoice.Choice();
            if (userChoice is AnswerCorrect)
            {
                Player.ScoreMult();
                if (i == arrLength - 1)
                {
                    Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                    Player.PlayerWin();
                    return true;
                }
                Console.WriteLine("Ваш выигрыш: {0}", Player.Score);
                return false;
            }
            else
            {
                Player.ScoreZero(InsideMap.UserLost);
                TryAgain.Again();
                return true;
            }
        }
    }
}
