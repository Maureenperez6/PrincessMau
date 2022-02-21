﻿using System;
using System.Threading;

namespace PrincessMau
{
    public class Game
    {
        public Game()
        {
        }


        public string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string userResponse = Console.ReadLine();
            while (userResponse == "")
            {
                Console.WriteLine("Please enter your responce.");
                Console.WriteLine(question);
                userResponse = Console.ReadLine();
            }
            return userResponse;
        }


        protected void LoseLife()
        {

        }

        protected void MainMenu()
        {
            Console.WriteLine(@"                                                                        
             ________00000000000___________000000000000_________
             ______00000000_____00000___000000_____0000000______
             ____0000000_____________000______________00000_____
             ___0000000_______________0_________________0000____
             __000000____________________________________0000___
             __00000_____________________________________ 0000__
             _00000______________________________________00000__
             _00000_____________________________________000000__
             _000000_________________________________0000000___
             ___0000000______________________________0000000____
             ____000000____________________________000000______
             _______000000________________________000000________
             __________00000_____________________0000___________
             _____________0000_________________0000_____________
             _______________0000_____________000________________
             _________________000_________000___________________
             _________________ __000_____00_____________________
             ______________________00__00_______________________
             ________________________00_________________________

                
       
                                                                                   ");
            Thread.Sleep(2000);
            Console.Clear();
        }


    }
}
