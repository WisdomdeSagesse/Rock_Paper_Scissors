
Random rd = new Random();

string rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";

string paper = @"

    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
";


string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";

string[] image = {rock, paper, scissors};

int user;
int computer;
string response = "";

while (response != "n")
{
    Console.WriteLine("What do you choose? Type 0 for Rock, 1 for Paper and 2 for Scissors");
    user = Convert.ToInt32(Console.ReadLine());
    if (user < 0 || user >2) Console.WriteLine("You entered an invalid number you lose.");
    else 
    {
        Console.WriteLine($"You chose {image[user]}");
        computer = rd.Next(0, 3);
        Console.WriteLine($"Computer chose {image[computer]}");

        if (user == 2 && computer == 1) Console.WriteLine("You win");
        else if (user == 1 && computer == 0) Console.WriteLine("You win");
        else if (user == 2 && computer == 0) Console.WriteLine("You lose");
        else if (user == 0 && computer == 2) Console.WriteLine("You win");
        else if (user == computer) Console.WriteLine("It is a draw");
        else Console.WriteLine("You lose");
    }
    
    Console.WriteLine("Do you want to play again? [y/n]");
    response = Console.ReadLine().ToLower();
}
 