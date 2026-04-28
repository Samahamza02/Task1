namespace _1sttask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 25;
            int large = 35;
            Console.WriteLine("The number of small room you would like to be cleaned: ");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of large room you would like to be cleaned: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int cost = (small * x) + (large * y);
            double tax = cost * 0.06;

            Console.WriteLine($"The cost of cleaning : {cost}");
            Console.WriteLine($"The tax of cleaning : {tax}");
            Console.WriteLine("The total estimate of cleaning :"+(cost+tax));



        }
    }
}
