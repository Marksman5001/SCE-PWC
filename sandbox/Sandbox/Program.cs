using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("good afternoon");
        double area = CalculateCircleArea(10.2);
        Console.WriteLine(Convert.ToString(area));
    }
    static double CalculateCircleArea(double radius){
        double area=0;
        area=Math.PI*radius*radius;
        return area;
}

}