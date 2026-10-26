Console.WriteLine("Welcome to Blackjack");
Console.WriteLine("You are starting with 20 euros, every bet is 5 euros");
Random random = new Random();
int bank = 20;
string play = "yes";
bool busted = false;
while (play == "yes")
{
    Console.WriteLine($"You have {bank} euros");
    Console.WriteLine("Do you want to play a hand?(yes/no)");
    play = Console.ReadLine();
    int cardOne = random.Next(2, 12);
    int cardTwo = random.Next(2, 12);
    int score = cardOne + cardTwo;
    Console.WriteLine($"You have {cardOne} and {cardTwo},your score is {score}");
    int dCardOne = random.Next(2, 12);
    Console.WriteLine($"Dealer drew {dCardOne}");
    while (score <= 21)
    {
        Console.WriteLine("Do you want to hit or stand: enter h for hit and s for stand");
        string hitOrStand = Console.ReadLine();
        if (hitOrStand == "h")
        {
            int cardThree = random.Next(2, 12);
            score = cardThree + score;
            Console.WriteLine($"{cardThree}, your new score is {score}");
            if (score == 21)
            {
                Console.WriteLine("BLACKJACK");
                Console.WriteLine("You win 7 euros");
                bank = bank + 7;
                break;
            }
            if (score > 21)
            {
                Console.WriteLine("Busted,You lose");
                bank = bank - 5;
                Console.WriteLine($"You have {bank} euros");
                busted = true;
            }
        }
        else if (hitOrStand == "s")
        {
            Console.WriteLine($"{score} is your final score");
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    int dCardTwo = random.Next(2, 12);
    int dScore = dCardOne + dCardTwo;
    
    while (dScore <= 17)
    {
        Console.WriteLine($"Dealer drew {dCardTwo},Dealers score is {dScore}");
        int dCardThree = random.Next(2, 12);
        dScore = dCardThree + dScore;
        Console.WriteLine($"Dealer drew {dCardThree}, Dealers new score is {dScore}");
        if (dScore > 21)
        {
            Console.WriteLine("Dealer busted, You win");
            bank = bank + 5;
            Console.WriteLine($"You have {bank} euros");
            busted=true;
            break;
        }
    }
    if (busted != true)
    {
        if (dScore > score)
        {
            Console.WriteLine("You lose");
            bank = bank - 5;
        }
        else if (score > dScore)
        {
            Console.WriteLine("You win");
            bank = bank + 5;
        }
        else if (score == dScore)
        {
            Console.WriteLine("Push");
        }
       
    }
}