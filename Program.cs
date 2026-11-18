namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user about the number
            // add condition about the range
            // Generate random number from 1 to 4
            // use if else conditions jis sa wo match kara matlab 1 hoga to computer rock hoga 2 to paper etc
            // variable lo string ka us mein isko store karwa do


            int number = 0;
            Random game = new Random();
            game.Next(1, 4);
            string computerguessed;
            string userguessed;
            string playagain;
            
            int computergenerated = game.Next(1, 4);
            if (computergenerated == 1)
            {
                computerguessed = "Rock";
            }
            else if (computergenerated == 2)
            {
                computerguessed = "Paper";
            }
            else
            {
                computerguessed = "Scissor";
            }

            bool play = false;
            while (!play)
            {
                Console.WriteLine("Rock , Paper or scissor ?");
                userguessed = Console.ReadLine();

                if (userguessed == computerguessed)
                {
                    Console.WriteLine("OH IT IS SAME");
                    
                }
                else if (computerguessed == "Rock" && userguessed == "Paper")
                {
                    Console.WriteLine("You won");
                    
                }
                else if (computerguessed == "Paper" && userguessed == "Rock")
                {
                    Console.WriteLine("Computer Won!");
                    
                }
                else if (computerguessed == "Scissor" && userguessed == "Rock")
                {
                    Console.WriteLine("YOU WON");
                    
                }
                else if (computerguessed == "Rock" && userguessed == "Scissor")
                {
                    Console.WriteLine("Computer WON");
                    
                }
                else if (computerguessed== "Paper"&& userguessed== "Scissor")
                {
                    Console.WriteLine("You won");
                    

                }
                else if (computerguessed == "Scissor" && userguessed == "Paper")
                {
                    Console.WriteLine("User  won");
                    

                }
                Console.WriteLine($"Computer Guessed {computerguessed}, You entered {userguessed}");
                Console.WriteLine("Do you wish to PLAY AGAIN Y/N?");
                playagain = Console.ReadLine();
                if (playagain == "Y")
                {
                    play = false;
                }
                else if (playagain== "F")
                {
                    
                    Console.WriteLine("Thanks for Playing this Game");
                    play = true;

                }

            }
            
        }
    }
}
