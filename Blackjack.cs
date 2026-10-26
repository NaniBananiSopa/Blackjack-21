Random random = new Random();
int cardOne = random.Next(2,12);
int cardTwo = random.Next(2,12);
int score = cardOne + cardTwo;
Console.WriteLine($"You have {cardOne} {cardTwo},your score is {score}");