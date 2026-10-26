

namespace Home_test;

class Program
{
    static void Main(string[] args)
    {
        // zad 1 inicializaciq na obekti ///////////////////////////////////////////////////////////////////////////

        //    int promenlivaIzbor = int.Parse(Console.ReadLine());
        //    switch (promenlivaIzbor)
        //    {
        //        case 1: int a = int.Parse(Console.ReadLine()); a++; Console.WriteLine(a); break;
        //        case 2: double b = double.Parse(Console.ReadLine()); b += 1.0; Console.WriteLine(b); break;
        //        case 3: string c = Console.ReadLine(); Console.WriteLine(c + "*"); break;
        //        default: Console.WriteLine("Невалидино"); break;
        //    }


        // zad 2 print na chisla cikal ///////////////////////////////////////////////////////////////////////////


        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.WriteLine(i);
        //}


        // zad 3 matrica ///////////////////////////////////////////////////////////////////////////


        //int n = int.Parse(Console.ReadLine());
        //for (int row = 1; row <= n; row++)
        //{
        //    for (int col = row; col < row + n; col++)
        //    {
        //        Console.Write(col + " ");

        //    }
        //    Console.WriteLine();

        //}


        // zad 4 sortirane na chisla ///////////////////////////////////////////////////////////////////////////


        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());
        //double min = Math.Min((Math.Min(a, b)), c);
        //double max = Math.Max((Math.Max(a, b)), c);
        //double mid = (a + b + c) - max - min;
        //Console.WriteLine($"{min}-{mid}-{max}");

        // zad 5 shah mozhe li figurata da oride tam

        //int figura = int.Parse(Console.ReadLine());
        //int x1 = int.Parse(Console.ReadLine());
        //int y1 = int.Parse(Console.ReadLine());
        //int x2 = int.Parse(Console.ReadLine());
        //int y2 = int.Parse(Console.ReadLine());

        //if (figura < 1 || figura > 5)
        //{
        //    Console.WriteLine("Nqma takawa fig");
        //    return;
        //}

        //if (((x1 < 1) || (x1 > 8)) || ((x2 < 1) || (x2 > 8)) || ((y1 < 1) || (y1 > 8)) || (y2 < 1) || (y2 > 8))
        //{
        //    Console.WriteLine("Nevalidni danni");
        //    return;
        //}
        //if (x1 == x2 && y1 == y2)
        //{
        //    Console.WriteLine("Towa e sashtoto pole");
        //}

        //int dx = Math.Abs(x1 - x2);
        //int dy = Math.Abs(y1 - y2);
        //bool isValidMove = false;

        //switch (figura)
        //{
        //    case 1:
        //        isValidMove = (x1 == x2 || y1 == y2);
        //        break;
        //    case 2:
        //        isValidMove = (dx == dy);
        //        break;
        //    case 3:
        //        isValidMove = (dx == 1 && dy == 2 || (dx == 2 && dy == 1));
        //        break;
        //    case 4:
        //        isValidMove = (dx <= 1 && dy <= 1);
        //        break;
        //    case 5:
        //        isValidMove = (x1 == x2 || y1 == y2 || dx == dy);
        //        break;
        //}

        //if (isValidMove)
        //    Console.WriteLine("Da");
        //else
        //    Console.WriteLine("Ne");


        // zad 5 kino bilet ///////////////////////////////////////////////////////////////////////////


        //int age = int.Parse(Console.ReadLine());
        //int day = int.Parse(Console.ReadLine());


        //if (age < 0 || age > 120 || day < 1 || day > 7)
        //{
        //    Console.WriteLine("Newalidni danni");
        //    return;

        //}



        //double price = 0;
        //if (age <= 6)
        //{
        //    Console.WriteLine("free");
        //    return;
        //}
        //if (age > 7 && age < 17)
        //{
        //    price += 4.0;
        //}

        //else if (age > 18 && age < 64)
        //{
        //    price += 6.0;
        //}
        //else if (age > 65)
        //{
        //    price += 3.5;
        //}



        //if (day == 3)
        //{
        //    price *= 0.7;
        //}
        //else if (day == 6 || day == 7)
        //{
        //    price += 1.0;
        //}
        //Console.WriteLine($"{price:f2}");


        // zad 5 ocenka


        //Console.WriteLine("Tochki (o-100): ");
        //int points = int.Parse(Console.ReadLine());
        //string mark;
        //if (points >= 90) mark = "6";
        //else if (points >= 75) mark = "5";
        //else if (points >= 60) mark = "4";
        //else if (points >= 45) mark = "3";
        //else mark = "2";
        //Console.WriteLine(mark);


        // zad 6 piramida

        //int h = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= h; i++)
        //{
        //    for (int j = 0; j < h -i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 0; j < 2*i -1; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}


        // zad 7 ocenki walidni

        //int note = 0;
        //do
        //{
        //    int current_note = int.Parse(Console.ReadLine());
        //    note += current_note;
        //    if (note > 2 && note < 7)
        //    {
        //        Console.WriteLine($"Ocenka : {note}");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Newalidna ocenka");
        //        note -= current_note;
        //    }


        //} while (note < 2 || note > 7);


        // zad 8 suma na n chisla


        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //for (int i = 0; i < n ; i++)
        //{
        //    int chislo = int.Parse(Console.ReadLine());
        //    sum += chislo;
        //}
        //Console.WriteLine(sum);


        // zad 9 pechatane na chisla


        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i < n + 1; i++)
        //{
        //    Console.WriteLine(i);

        //}


        // zad 10 fibanochi


        //ulong a = 0;
        //ulong b = 1;
        //for (int i = 1; i <= 100;i++)
        //{
        //    Console.WriteLine(a);
        //    ulong next = a + b;
        //    a = b;
        //    b = next;
        //}



        // zad 11 blackjack



        Console.WriteLine("Welcome to Blackjack");
        Console.WriteLine("You are starting with 20 euros, every bet is 5 euros");
        Random random = new Random();
        int bank = 20;
        string play = "yes";
        bool busted = false;
        outerloop:
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
                        goto outerloop;
                        //break;
                    }
                    if (score > 21)
                    {
                        Console.WriteLine("Busted,You lose");
                        bank = bank - 5;
                        Console.WriteLine($"You have {bank} euros");
                        busted = true;
                        goto outerloop;
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
                    busted = true;
                    goto outerloop;
                    //break;
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
            //continue;
        }

    }
}

























    