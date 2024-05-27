using System;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "hello";
        string str3 = "world";
        int int1 = str1.GetHashCode();
        int int2 = str2.GetHashCode();
        int int3 = str3.GetHashCode();
        Console.WriteLine($"Hash code for str1: {int1}");
        Console.WriteLine($"Hash code for str2: {int2}");
        Console.WriteLine($"Hash code for str3: {int3}");

        if (int1 == int2)
        {
            Console.WriteLine("str1 and str2 have the same hash code.");
        }
        else
        {
            Console.WriteLine("str1 and str2 have different hash codes.");
        }

        if (int1 == int3)
        {
            Console.WriteLine("str1 and str3 have the same hash code.");
        }
        else
        {
            Console.WriteLine("str1 and str3 have different hash codes.");
        }
    }
}
