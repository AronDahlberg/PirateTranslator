namespace PirateTranslator
{
    static internal class TranslateTo
    {
        static public void Run()
        {
            Console.Clear();

            Console.WriteLine("Input text:");

            string input = Console.ReadLine();

            string output = Translate(input);

            Console.WriteLine("Translation: " + output);

            Console.WriteLine("Press enter to continue");

            Console.ReadLine();
        }

        static private string Translate(string input)
        {
            string translation = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(IsConsonant(input[i]))
                {
                    translation += input[i] + "o" + input[i];
                }
                else
                {
                    translation += input[i];
                }
            }

            return translation;
            
        }

        static private bool IsConsonant(char c)
        {
            string consonant = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";

            if (consonant.Contains(c))
            {
                return true;
            }

            return false;
        }
    }
}
