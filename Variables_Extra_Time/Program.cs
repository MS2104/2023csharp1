namespace Variables_Extra_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();
            } 
        }
    }
}