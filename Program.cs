namespace cleaningServiceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpets;
            int largeCarpets;
            int totalCarpets;
            double tax;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
             smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(smallCarpets);
            Console.WriteLine("Number of large carpets:");
             largeCarpets = Convert.ToInt32(Console.ReadLine());
             totalCarpets = smallCarpets * 25 + largeCarpets * 35;
             tax = totalCarpets * 0.06; 
            Console.WriteLine($"Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"Cost : {totalCarpets}");

            Console.WriteLine($"Tax :{tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate :{totalCarpets+tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
