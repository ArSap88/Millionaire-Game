using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Millionaire_Game
{
    class MainGame
    {
        internal void GameInit(string userName)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Привет, {0}", userName);
            Console.WriteLine("Хотите прочитать правила игры?\n <Да> | <Нет>");
            UserInput showRules = new UserInput();
            showRules.ReceiveInput(InsideMap.FromGameInit);
            int initialScore = 50;
            int initialQuestion = 0;
            GameEngine(userName, initialScore, initialQuestion);
        }
        internal void GameEngine(string userName, int userScore, int qNumber)
        {            
            Player user = new Player();
            user.Name = userName;
            user.Score = userScore;
            Console.WriteLine(" ");
            Console.WriteLine("Ну что, {0}, готовы начать?\nИтак:", user.Name);
            Database qBlock = new Database();
            qBlock.QandA();
            Question[] arr = new Question[5] { qBlock.Question1, qBlock.Question2, qBlock.Question3, qBlock.Question4, qBlock.Question5 };
            UserInput input = new UserInput();
            TryAgain again = new TryAgain();
            Answer userChoice;
            for (int i = qNumber; i < arr.Length; i++)
            {                
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
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            user.PlayerWin();                            
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);                        
                    }
                    else
                    {
                        user.ScoreZero(InsideMap.UserLost);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerTwo)
                {
                    userChoice = arr[i].Answers[1];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            user.PlayerWin();                            
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);                        
                    }
                    else
                    {
                        user.ScoreZero(InsideMap.UserLost);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerThree)
                {
                    userChoice = arr[i].Answers[2];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            user.PlayerWin();                            
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);                        
                    }
                    else
                    {
                        user.ScoreZero(InsideMap.UserLost);                        
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == InsideMap.AnswerFour)
                {
                    userChoice = arr[i].Answers[3];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            user.PlayerWin();                            
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);                        
                    }
                    else
                    {
                        user.ScoreZero(InsideMap.UserLost);                        
                        again.Again();
                        break;
                    }
                }
                else if (string.Equals(userAnswer, InsideMap.Money, StringComparison.OrdinalIgnoreCase))
                {
                    if (i == 0)
                    {
                        user.ScoreZero(InsideMap.Money);
                    }
                    user.PlayerWin();                    
                    break;
                }
                else if (string.Equals(userAnswer, InsideMap.SaveGame, StringComparison.OrdinalIgnoreCase))
                {
                    Save save = new Save();
                    save.SaveFile(user.Name, user.Score, i);
                    i--;
                }
            }
        }
    }
}
