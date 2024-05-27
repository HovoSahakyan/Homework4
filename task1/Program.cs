namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "some text";
            int lenght = str1.Length;
            Console.WriteLine(lenght);

            string str3 = str1.ToLower();
            Console.WriteLine(str3);

            string str2 = str1.ToUpper();
            Console.WriteLine(str2);

            string sentence = "This World is full of amazing places ";
            Console.WriteLine(sentence.Substring(5,5));


        }
    }
}
