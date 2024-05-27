using System.Runtime.InteropServices;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Yerevan,London,Rome,Washington";
            string[] str2 = str1.Split(',');
            string str3 = str2[0];
            string str4 = str2[1];
            string str5 = str2[2];
            string str6 = str2[3];
            Console.WriteLine("Yerevan");
            Console.WriteLine("London");
            Console.WriteLine("Rome");
            Console.WriteLine("Washington");
        }
    }
}
