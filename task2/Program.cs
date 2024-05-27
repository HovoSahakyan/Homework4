namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hi!.";
            string str2 = " I am learning how to code in c#.";
            string str3 = " And i think programming is not that hard.";
            string str4 = " But i don't know why people think that it's that difficult.";
            Console.WriteLine(string.Concat(str1, str2, str3, str4));
        }
    }
}
