using System;

namespace BeatTheOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine("Welcome to the Casino. The odds are " + odds);

            //while (player.Cash > 0)
            //{
            //    player.WriteMyInfo();
            //    Console.Write("How much do you want to bet: ");
            //    string howMuch = Console.ReadLine();
            //    //if (howMuch == "") return;
            //    if (int.TryParse(howMuch, out int amount))
            //    {
            //        int pot = player.GiveCash(amount) * 2;
            //        int value = random.Next(0, 1); 
            //        if (value > odds)
            //        {
            //            player.ReceiveCash(pot);
            //            Console.WriteLine("You win " + pot);
            //        }
            //        else
            //        {
            //            player.GiveCash(pot);
            //            Console.WriteLine("Bad luck, you lose.");
            //        }  
            //    }
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                //if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            

            
            Console.WriteLine("The house always wins.");
        }
    }
}
