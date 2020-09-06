using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Millionaire_Game
{
    class MainGame
    {
        internal void GameEngine(Question q1, Question q2, Question q3, Question q4, Question q5)
        {            
            Player user = new Player();
            user.PlayerName();            
            Console.WriteLine(" ");
            Console.WriteLine("Привет, {0}", user.Name);            
            Question[] arr = new Question[5] { q1, q2, q3, q4, q5 };
            UserInput input = new UserInput();            
            InsideMap map = new InsideMap();            
            GameOver gameOver = new GameOver();
            Goodbye bye = new Goodbye();
            Winner winner = new Winner();
            TryAgain again = new TryAgain();
            Answer userChoice;
            string from = map.FromGameEngine;
            for (int i = 0; i < arr.Length; i++)
            {                
                Console.WriteLine(" ");
                Console.WriteLine(arr[i].QText);
                Console.WriteLine(" ");
                Console.WriteLine("1. " + arr[i].Answers[0].AText);
                Console.WriteLine("2. " + arr[i].Answers[1].AText);
                Console.WriteLine("3. " + arr[i].Answers[2].AText);
                Console.WriteLine("4. " + arr[i].Answers[3].AText);
                Console.WriteLine(" ");                
                string userAnswer = input.ReceiveInput(from);
                if (userAnswer == map.AnswerOne)
                {
                    userChoice = arr[i].Answers[0];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            winner.YouWin(user.Score);
                            bye.Bye();
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        user.ScoreZero();
                        gameOver.UserLost(user.Score);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == map.AnswerTwo)
                {
                    userChoice = arr[i].Answers[1];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            winner.YouWin(user.Score);
                            bye.Bye();
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        user.ScoreZero();
                        gameOver.UserLost(user.Score);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == map.AnswerThree)
                {
                    userChoice = arr[i].Answers[2];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            winner.YouWin(user.Score);
                            bye.Bye();
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        user.ScoreZero();
                        gameOver.UserLost(user.Score);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == map.AnswerFour)
                {
                    userChoice = arr[i].Answers[3];
                    userChoice.Choice();
                    if (userChoice is AnswerCorrect)
                    {
                        user.ScoreMult();
                        if (i == arr.Length - 1)
                        {
                            Console.WriteLine("Поздравляем, Вы ответили на все вопросы!");
                            winner.YouWin(user.Score);
                            bye.Bye();
                            break;
                        }
                        Console.WriteLine("Ваш выигрыш: {0}", user.Score);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        user.ScoreZero();
                        gameOver.UserLost(user.Score);
                        again.Again();
                        break;
                    }
                }
                else if (userAnswer == map.Money)
                {
                    if (i == 0)
                    {
                        user.ScoreZero();
                    }
                    Console.WriteLine("Вы выиграли {0}", user.Score);
                    bye.Bye();
                    break;
                }
            }
        }        
    }
}
