﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public Player p1;
        public Player p2;

        public void initPlayers()
        {
            p1 = new Player();
            p2 = new Player();
            makeID();
            initScore();
        }

        public void setNames(string name1, string name2)
        {
            p1.userName = name1;
            p2.userName = name2;
        }

        public void setMove(string move1, string move2)
        {
            p1.move = move1;
            p2.move = move2;
        }

        void checkRPS()
        {
            if ((p1.move.Equals("ROCK") && p2.move.Equals("SCISSORS")) || (p1.move.Equals("PAPER") && p2.move.Equals("ROCK")) || (p1.move.Equals("SCISSORS") && p2.move.Equals("PAPER")))
            {
                p1.numWins++;
            }
            else if ((p2.move.Equals("ROCK") && p1.move.Equals("SCISSORS")) || (p2.move.Equals("PAPER") && p1.move.Equals("ROCK")) || (p2.move.Equals("SCISSORS") && p1.move.Equals("PAPER")))
            {
                p2.numWins++;
            }
        }


        void initScore()
        {
            p1.numWins = 0;
            p2.numWins = 0;
        }
        void makeID()
        {
            p1.userID = genRandom();
            p2.userID = genRandom();

            while (p1.userID == p2.userID)
            {
                p2.userID = genRandom();
            }
        }

        int genRandom()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 100000);
        }
    }
}
