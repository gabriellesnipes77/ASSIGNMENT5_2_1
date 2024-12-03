namespace ASSIGNMENT5_2_1
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)

        {
            s = s.Trim();


            int length = 0;


            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && length > 0)
                {
                    break;
                }

                if (s[i] != ' ')
                {
                    length++;
                }
            }

            return length;
        }

         public static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello, World!"));
            Console.WriteLine(LengthOfLastWord("fly me to the moon"));
            Console.WriteLine(LengthOfLastWord("word"));
            Console.WriteLine(LengthOfLastWord("singleWord"));
        }
    }
}
