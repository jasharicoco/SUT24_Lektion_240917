namespace SUT24_Lektion_240917
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this super awesome game!");
            Console.WriteLine("Choose a nickname:");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Welcome, {userNick}!");
        }
    }
}
