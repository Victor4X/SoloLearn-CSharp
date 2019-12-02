using System;

namespace Conditionals_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            string playerChoice;
            string computerChoice;
            int playerScore = 0;
            int computerScore = 0;
            Random rnd = new Random();
            string[] objects = {"Rock","Paper","Scissors"};

            Console.WriteLine("Welcome to Rock, Paper, Scissors (0.1)");

            // Main while loop

            while (true){

                // Player choice
                playerChoice = "";
                while (playerChoice == "")
                {
                    Console.WriteLine("Please choose either (Rock), (Paper), (Scissors) or (Exit)");
                    playerInput = Console.ReadLine();

                    switch(playerInput.ToLower()){
                        case "rock":
                            playerChoice = "Rock";
                            break;
                        case "paper":
                            playerChoice = "Paper";
                            break;
                        case "scissors":
                            playerChoice = "Scissors";
                            break;
                        case "exit":
                            ExitPlease();
                            break;
                        default:
                            Console.WriteLine("Dumbass");
                            break;
                    }

                }
                Console.WriteLine("You chose \"" + playerChoice + "\"");

                // Computer choice
                computerChoice = objects[rnd.Next(0, 3)];
                Console.WriteLine("The computer chose \"" + computerChoice + "\"");

                // Comparison
                if (playerChoice == computerChoice){
                    Console.WriteLine("It's a draw!");
                }
                else if ((playerChoice == "Rock" && computerChoice == "Scissors")||(playerChoice == "Paper" && computerChoice == "Rock")||(playerChoice == "Scissors" && computerChoice == "Paper")){
                    Console.WriteLine("Player wins!");
                    playerScore ++;
                }
                else{
                    Console.WriteLine("Computer wins!");
                    computerScore ++;
                }

                Console.WriteLine("The current score between Player - Computer is {0} - {1}", playerScore, computerScore);
            }
            
        }

        static void ExitPlease()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // Console app
            System.Environment.Exit(1);
        }
    }
}
