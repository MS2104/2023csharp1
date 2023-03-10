namespace Variables_Extra_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            typeOut("Hello World!");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void typeOut(string str)
        {
            foreach(char c in str)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
        }
    }
}