namespace PirateTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            string? input;

            while (!close)
            {
                Console.Clear();

                Console.WriteLine("Input correct number for translation direction:\n" +
                    "1: Translate to pirate language\n" +
                    "2: Translate from pirate language\n" +
                    "3: Exit program");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1": TranslateTo.Run(); break;

                    case "2": TranslateFrom.Run(); break;

                    case "3": close = true;  break;
                }
            }

            Console.Clear();
        }
    }
}
