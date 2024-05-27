namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "bonita";
            string str2 = "BONITA";
            bool bl1 = str1.Equals(str2);

            if (bl1 )
            {
                Console.WriteLine("equal");

            }
            else 
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
