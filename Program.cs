using System;
using System.Xml.Linq;

namespace SportsTime
{
    abstract class Sports
    {
        public abstract string PlayersName { get; set; }
        public abstract string Position { get; set; }
        public abstract string Roster();
        public string GameTime()
        {
            return "Let's Play";
        }
    }
    class Program
    {
        class Soccer : Sports
        {
            public override string PlayersName { get; set; }
            public override string Position { get; set; }
            public int Age { get; set; }

            public Soccer()
            {
                PlayersName = string.Empty;
                Position = string.Empty;
                Age = 0;
            }

            public Soccer(string playersName, string position, int age)
            {
                PlayersName = playersName;
                Position = position;
                Age = age;
            }

            public override string Roster()
            {
                return "Players Name: " + PlayersName + "\nPosition: " + Position + "\nPlayers Age: " + Age;
            }
        }
        static void Main(string[] args)
        {
            Soccer playerOne = new Soccer();
            playerOne.PlayersName = "Lionel Messi";
            playerOne.Position = "Forward";
            playerOne.Age = 25;

            Soccer playerTwo = new Soccer("Iker Casillas", "Goalkeeper", 31);
            Console.WriteLine(playerOne.Roster());
            Console.WriteLine(playerTwo.Roster());
        }
    }
}