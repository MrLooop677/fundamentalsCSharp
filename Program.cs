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
            Console.WriteLine("Number of large carpets:");
             largeCarpets = Convert.ToInt32(Console.ReadLine());
             totalCarpets = smallCarpets * 25 + largeCarpets * 35;
             tax = totalCarpets * 0.06; 
            Console.WriteLine($"Price per small room: {25:C}");
            Console.WriteLine($"Price per large room: {35:C}");
            Console.WriteLine($"Cost : {totalCarpets:C}");

            Console.WriteLine($"Tax :{tax:C}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate :{totalCarpets+tax :C}");
            Console.WriteLine("This estimate is valid for 30 days");




        }
    }
}
