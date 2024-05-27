namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "(hello)";
            string str2 = "(hello)";
            string str3 = "(world)";

            bool bl1 = str1.Equals(str2);
            if (bl1) 
            {
                Console.WriteLine($"{str1} is equal to {str2}");
            }
            else 
            {
                Console.WriteLine($"{str1} is non equal to {str2}  ");
            }

            bool bl2 = str1.Equals(str3);
            if (bl2) 
            {
                Console.WriteLine($"{str1} is equal to {str3}");
            }
            else 
            {
                Console.WriteLine($"{str1} is non equal to {str3}");
            }

        }
    }
}
