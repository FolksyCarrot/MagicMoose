using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseQuestion();
}

void MooseQuestion() {
    Console.WriteLine("Ask a Question: ");
    string question = Console.ReadLine();
    int length = question.Length;

    if (length > 0) {
        int answer = RandomNumberGenerator();
        if (answer == 0) {
            Console.WriteLine("As I see it, yes.");
        }
        else if (answer == 1) {
            Console.WriteLine("Ask again later.");
        }
        else if (answer == 2) {
            Console.WriteLine("Better not tell you now.");
        }
        else if (answer == 3) {
            Console.WriteLine("Cannot predict now.");
        }
        else if (answer == 4) {
            Console.WriteLine("Concentrate and ask again.");
        }
        
    }
    else {
        Console.WriteLine("nothing");
    }
}


static int RandomNumberGenerator() {
    Random r = new Random();
    int genRand= r.Next(0,4);
    return genRand;
}
