using System;
using System.Collections.Generic;
using System.Text;

namespace Millionaire_Game
{
    class Player
    {        
        internal string Name { get; private set; }
        internal int Score { get; private set; } = 50;
        internal void PlayerName()
        {
            Console.WriteLine("Введите свое имя:");
            string username = Console.ReadLine();
            Name = username;            
        }
        /*internal void InitScore()
        {
            Score = 50;
        }*/
        internal void ScoreMult()
        {
            Score *= 2;
        }
        internal void ScoreZero()
        {
            Score = 0;
        }
    }
}
