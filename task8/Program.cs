namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "something";
            string str2 = "";

            bool bl1 = string.IsNullOrEmpty(str1);

            if (bl1)
            {
                Console.WriteLine("string-str1 is emty");
            }
            else
            {
                Console.WriteLine("string-str1 is not empty");
            }

            bool bl2 = string.IsNullOrWhiteSpace(str2); 
            if (bl2)
            {
                Console.WriteLine("string-str2 is white space");
            }
            else 
            {
                Console.WriteLine("string-str2 is not whitespace");

            }
        }
    }
}
