using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> intlist = new List<int>();
        int newnumber=1;
        while(newnumber !=0){
            Console.WriteLine("What number do you want to add?");
            string number = Console.ReadLine();
            newnumber = int.Parse(number);
            if(newnumber!=0){
                intlist.Add(newnumber);
            }
        }
        int sum = intlist.Sum();
        double average = intlist.Average();
        int largest = intlist.Max();
        Console.WriteLine($"sum: {sum}");
        Console.WriteLine($"average: {average}");
        Console.WriteLine($"largest number: {largest}");


    }
}