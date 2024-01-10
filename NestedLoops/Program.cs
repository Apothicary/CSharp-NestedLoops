namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Nested loops is essentially a loop within a loop
             * They are used for a variety of things, such as sorting algorithims 
             */ 

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol or character would you like to use?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
