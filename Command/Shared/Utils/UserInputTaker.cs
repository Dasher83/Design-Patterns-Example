namespace Command.Shared.Utils
{
    internal static class UserInputTaker
    {

        public static string TakeStringInput(string? prompt = null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (prompt != null)
            {
                Console.WriteLine(prompt);
            }
            string? userInput = Console.ReadLine();
            string correctInput = userInput != null ? userInput.Trim() : "";
            return correctInput;
        }

        public static int TakeIntInput(int? min = null, int? max = null, string? prompt = null)
        {
            int? correctInput = null;

            while (correctInput == null)
            {
                string userInput = TakeStringInput(prompt);
                try
                {
                    correctInput = int.Parse(userInput);
                    if (min != null)
                    {
                        if (correctInput < min)
                        {
                            throw new ArgumentOutOfRangeException("", $"Acceptable minimum: {min}"); ;
                        }

                        if (correctInput > max)
                        {
                            throw new ArgumentOutOfRangeException("", $"Acceptable maximum: {max}");
                        }
                    }
                }
                catch (FormatException)
                {
                    ConsoleColor previousColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid integer: {userInput}");
                    Console.WriteLine("Try again ...");
                    correctInput = null;
                    Console.ForegroundColor = previousColor;
                    continue;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    ConsoleColor previousColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again ...");
                    correctInput = null;
                    Console.ForegroundColor = previousColor;
                    continue;
                }
            }

            return (int)correctInput;
        }
    }
}
