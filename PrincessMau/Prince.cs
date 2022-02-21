using System;
namespace PrincessMau
{
    public class Prince
    {
        public Prince()
        {
            var game = new Game();
            Console.WriteLine("Ahhhhhh the Princess has been taken by the Trolls!");
            Console.WriteLine("");
            Name = game.GetUserResponse("Handsome Prince what is your name?");
            Console.Clear();
            LastName = game.GetUserResponse("And what is your last name?");
            Console.Clear();
            string FullPrinceName = (Name + " " + LastName);

            Console.WriteLine($"Welcome {FullPrinceName}, To our adventure in saving the princess!");
        }

        public string FullPrinceName { get; set; }
        private int Health = 3;

        public string Name { get; set; }

        public string LastName { get; set; }

        public int score { get; set; }

        public int GetHealth()
        {
            return Health;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public bool GameOver()
        {
            return Health == 0;
        }

        public void ResetHealth()
        {
            Health = 0;
        }


        public string NewPrinceName()
        {
            return $"{Name} {LastName}";
        }


    }
}