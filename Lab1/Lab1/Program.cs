namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first integer");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second integer");
        int second = Convert.ToInt32(Console.ReadLine());
        DoMath(first, second);

        //Console.WriteLine(first + " " + second);
    }

    public static void DoMath(int first, int second)
    {
        int result = first + second;
        Console.WriteLine($"{first} + {second} = {result}");
    }
}