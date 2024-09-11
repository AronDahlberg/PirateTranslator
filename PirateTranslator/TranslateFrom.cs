namespace PirateTranslator
{
    class TranslateFrom
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
                translation += input[i];

                if (i < input.Length - 2 && input.Length > 2)
                {
                    if (IsConsonant(input[i]) && input[i + 1] == 'o' && input[i + 2] == input[i])
                    {
                        i += 2;
                    }
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
