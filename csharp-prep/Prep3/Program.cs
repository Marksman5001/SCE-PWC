using System;

class Program
{
    static void Main(string[] args)
    {
        int guess=0;
        int number=1;
        Random rnumber = new Random();
        number = rnumber.Next(1, 100);
        while(guess != number){
            Console.WriteLine("What is your guess for the number?");
            string guessstr = Console.ReadLine();
            guess = int.Parse(guessstr);
            Console.WriteLine(number);
            if(guess<number){
                Console.WriteLine("The number is higher!");
            }
            if(guess>number){
                Console.WriteLine("The number is smaller!");
            }
            if(guess==number){
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}