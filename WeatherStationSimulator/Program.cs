namespace WeatherStationSimulator
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();



            Console.ReadKey();
        }
    }
}
