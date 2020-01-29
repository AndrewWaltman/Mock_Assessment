using System;

namespace Mock_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give us a vowel.");
            char input1 = char.Parse(Console.ReadLine());
            IsVowel(input1);

            Console.WriteLine("Now we will count how many vowels there are in a sentence. Please give us a sentence.");
            string input2 = Console.ReadLine().ToLower();
            CountVowels(input2);

            Console.WriteLine("Now we're going to judge your sentences on the amount of vowels they hold! Write another sentence.");
            string input3 = Console.ReadLine().ToLower();
            TooManyVowels(input3);

        }
        public static bool IsVowel(char isVowel)
        {
            if (isVowel == 'a' || isVowel == 'e' || isVowel == 'i' || isVowel == 'o' || isVowel == 'u')
            {
                Console.WriteLine("Good job, you got a vowel.");
                return true;
            }
            else
            {
                Console.WriteLine("Not a vowel.");
                return false;
            }
        }
        public static int CountVowels(string countVowels)
        {
            int total = 0;
            for (int i = 0; i < countVowels.Length; i++)
            {
                if (countVowels[i] == 'a' || countVowels[i] == 'e' || countVowels[i] == 'i' || countVowels[i] == 'o' || countVowels[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("Your total number of vowels is " + total);
            return total;
        }
        public static string TooManyVowels(string tooManyVowels)
        {
            int total = 0;
            for(int i = 0; i < tooManyVowels.Length; i++)
            {
                if(tooManyVowels[i] == 'a' || tooManyVowels[i] == 'e' || tooManyVowels[i] == 'i' || tooManyVowels[i] == 'o' || tooManyVowels[i] == 'u')
                {
                    total++;
                }
            }
            if (total <= 4)
            {
                tooManyVowels = "Too few vowels.";
            }
            else if (total >= 5 && total <= 7)
            {
                tooManyVowels = "Right amount of vowels.";
            }
            else if (total > 7)
            {
                tooManyVowels = "Too many vowels.";
            }
            else
            {
                tooManyVowels = "This sentence had no vowels.";
            }
            Console.WriteLine(tooManyVowels);
            return tooManyVowels;
        }
    }
}
