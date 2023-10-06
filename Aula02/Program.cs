using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Helo World!!");
        if (args.GetLength(0) > 0 )
        {
            Console.WriteLine(args.GetValue(0));
        } else { Console.WriteLine("Parâmetro ausente"); }
        Console.ReadLine();
    }
}