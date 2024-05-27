namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Pearl Harbor attack, (December 7, 1941), surprise aerial attack on the U.S. naval base at Pearl Harbor on Oahu Island, Hawaii, by the Japanese that precipitated the entry of the United States into World War II. The strike climaxed a decade of worsening relations between the United States and Japan.";

            bool bl1 = str1.Contains("Hawaii");
            if (bl1)
            {
                int int1 = str1.IndexOf("Hawaii");
                Console.WriteLine($"Word's index is {int1}");
            }


         }

     }
 }


    

