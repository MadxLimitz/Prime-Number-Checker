class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        bool exitRequested = false;

        while (!exitRequested)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter the upper limit to find prime numbers:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("-----------------------------------");

                for (int i = 0; i < userNumber; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{i} is a prime number.");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Press 'Enter' to restart or 'Escape' to end the Programm");

                var userKey = Console.ReadKey();

                if (userKey.Key == ConsoleKey.Escape)
                    exitRequested = true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred during the process! {ex}");
                Console.ResetColor();
                Thread.Sleep(5000);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}