namespace VariableIntroConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration and Initialization 
            int myAge = 26;
            string myName = "DJ";
            bool enjoyCoding = true;
            string homeTown = "Pocatello, Idaho";
            char andSymbol = '&';
            decimal pi = 3.14159255359m;
            double randomNumber = 6.23;

            Console.WriteLine($"Hi my name is {myName}, and I am {myAge} years old!");
            Console.WriteLine($"I am orignally from {homeTown}");
            Console.WriteLine($"My two favorite numbers are {pi} {andSymbol} {randomNumber}");
            Console.WriteLine($"When asked if I enjoy coding? I would reply {enjoyCoding}");
            
            
        }
    }
}
