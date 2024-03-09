using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    public class HeroStats
    {
        private InidividualStat movementSquares;
        private InidividualStat attackDice;
        private InidividualStat defendDice;
        private InidividualStat bodyPoints;
        private InidividualStat mindPoints;

        public HeroStats()
        {
            movementSquares = new InidividualStat() { Text = "Movement Squares" };
            attackDice = new InidividualStat() { Text = "Attack Dice" };
            defendDice = new InidividualStat() { Text = "Movement Defend Dice" };
            bodyPoints = new InidividualStat() { Text = "Body Points" };
            mindPoints = new InidividualStat() { Text = "Mind Points" };
        }

        public InidividualStat MovementSquares { get => movementSquares; set => movementSquares = value; }
        public InidividualStat AttackDice { get => attackDice; set => attackDice = value; }
        public InidividualStat DefendDice { get => defendDice; set => defendDice = value; }
        public InidividualStat BodyPoints { get => bodyPoints; set => bodyPoints = value; }
        public InidividualStat MindPoints { get => mindPoints; set => mindPoints = value; }
    }


    public class InidividualStat
    {
        private string statText = "";
        private int statValue = 0;
        private int statTextPositionX = 0;
        private int statTextPositionY = 0;
        private int statValuetPositionX = 0;
        private int statValuetPositionY = 0;
        private int maxTextLenght = 0;

        public string Text { get => statText; set => statText = value; }
        public int Value { get => statValue; set => statValue = value; }
        public int TextPositionX { get => statTextPositionX; set => statTextPositionX = value; }
        public int TextPositionY { get => statTextPositionY; set => statTextPositionY = value; }
        public int StatValuetPositionX { get => statValuetPositionX; set => statValuetPositionX = value; }
        public int StatValuetPositionY { get => statValuetPositionY; set => statValuetPositionY = value; }
        public int MaxTextLenght { get => maxTextLenght; set => maxTextLenght = value; }
    }
}
