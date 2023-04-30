internal static class Program
{
    private static async Task Main(string[] args)
    {
        ICalculator calculator = new Calculator();
        while (true)
        {
            Console.WriteLine("Enter x:");

            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            if (!double.TryParse(input, out var x))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            double result = await calculator.GetCalculationResultAsync((int)x);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to continue or press enter to exit");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                break;
            }

            Console.WriteLine();
        }
    }
}