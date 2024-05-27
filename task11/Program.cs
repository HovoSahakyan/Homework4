namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TTT";
            string str2 = "TTT";

            string str3 = new string('T', 3);

            bool areEqual1 = ReferenceEquals(str1, str2);
            Console.WriteLine($"Are str1 and str2 equal? {areEqual1}");

           
            bool areEqual2 = ReferenceEquals(str1, str3);
            Console.WriteLine($"Are str1 and str3 equal? {areEqual2}");
        }
    }
}
