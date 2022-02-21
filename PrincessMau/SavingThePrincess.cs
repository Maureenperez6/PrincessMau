using System;
using System.Threading;

namespace PrincessMau
{
    public class SavingThePrincess : Game
    {
        public SavingThePrincess()
        {

        }


        public void runSavingThePrincessGame()
        {

            bool cont = true;

            do
            {

                var prince = new Prince();
                MainMenu();

                string answer;

                do

                {

                    answer = GetUserResponse("Would you like to save the princess? Enter yes or no");
                    Console.Clear();

                    if (answer == "no")
                    {

                        Console.WriteLine("How Rude!");
                        LoseLife();
                    }

                    else if (answer == "yes")

                    {
                        Console.WriteLine("Great! Lets go get her!");
                        break;
                    }
                }


                while (prince.IsAlive());



                Console.WriteLine("What a brave prince you are!");
                Console.WriteLine();

                string answertwo;

                while (prince.IsAlive())
                {
                    answertwo = GetUserResponse("Would you like to help the villagers on the way? Yes or No?");
                    Console.Clear();


                    if (answertwo == "no")
                    {

                        Console.WriteLine("Maybe you're not so brave after all!!");
                        LoseLife();

                    }
                    else if (answertwo == "yes")
                    {
                        Console.WriteLine("How fortunate are we you came along !");
                        break;
                    }

                }



                while (prince.IsAlive())
                {
                    Console.WriteLine("Your braveness and kindness will not go unseen!");
                    Console.WriteLine();

                    string answerthree;

                    Console.WriteLine("A couple of villagers need your help.. Are you ready to help them?");
                    Console.WriteLine();
                    Console.WriteLine("Or would you rather save the princess first?");
                    Console.WriteLine();
                    answerthree = GetUserResponse("Reply: help villagers : or : save princess");
                    

                    if (answerthree == "help villagers")
                    {
                        Console.WriteLine("Great choice! It's better to help the villagers while there is still day light!");
                        break;
                    }

                    else if (answerthree == "save princess")
                    {
                        Console.Clear();
                        Console.WriteLine("Try again! We don't want it to be dark when you help the villagers, help them first.");
                        LoseLife();
                       
                    }
                     

                }

                while (prince.IsAlive())
                {

                    Console.WriteLine($"Alrighty {prince.FullPrinceName}, we only have time to help one villager.");

                    string answerfour;

                    Console.WriteLine("Who will you help! Choose a letter!");

                    answerfour = GetUserResponse("A.Mario the plumber, his toilets are clogged B.Daisy the baker, needs to bake 6 cakes C.Luisa, needs help " +
                        "hanging one basket of laundry?");
                    Console.Clear();
                    if (answerfour == "A")
                    {
                        Console.WriteLine("Ewww! Now you stink and the princess doesnt want you near her!");
                        LoseLife();
                    }

                    else if (answerfour == "B")
                    {
                        Console.WriteLine("You took too Long now the day is over!");
                        LoseLife();
                    }
                    else if (answerfour == "C")
                    {
                        Console.WriteLine("Excellent ! That shouldnt take too long.");
                        break;
                    }

                    else
                    { Console.WriteLine("Looks like you're not interested in getting the princess today!"); LoseLife(); }


                }

                while (prince.IsAlive())
                {
                    Console.WriteLine($"We are almost done {prince.FullPrinceName}, now it's time to save the princess !!");

                    string answerfive;
                    Console.WriteLine("Are you ready to face the trolls ?!");

                    answerfive = GetUserResponse("How will you defeat the trolls? is it A.Slapping them? B.Punching them? or C.Dropkicking them?");
                    Console.Clear();
                    if (answerfive == "A")
                    {
                        Console.WriteLine("That could work but that can also get you killed!");
                        LoseLife();

                    }

                    else if (answerfive == "B")
                    {
                        Console.WriteLine("That could work but that can also get you killed!");
                        LoseLife();

                    }

                    else if (answerfive == "C")
                    {
                        Console.WriteLine("You will sure get them if you do that!");
                        cont = false;
                        break;

                    }
                    else
                    { Console.WriteLine("That sounds like we aren't saving the princess after all!"); LoseLife(); }


                }


                
                if (!cont)
                {
                    Console.WriteLine("Mission Complete!");
                    Console.WriteLine("If you want to try again say: yes!");
                    var uInput = Console.ReadLine();

                    if (uInput.ToLower() == "yes" || uInput == "Yes")
                    {
                        prince.ResetHealth();
                        runSavingThePrincessGame();
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        cont = false;
                    }
                }
                else

                    Console.WriteLine($" {prince.Name} {prince.LastName}, you are a lengendary prince!!");
               
            }
            while (cont);
            }

        }
    }

                
                





