public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Add \n" +
            "2. Subtract");
        string result = Console.ReadLine();
        int selection = int.Parse(result);

        if (selection == 1)
        {
            Console.WriteLine("Add the code to take in two numbers and add them here!");
        }
        else if (selection == 2)
        {
            Console.WriteLine("Add the code to take in two numbers and subtract them here!");
        }
    }
}
