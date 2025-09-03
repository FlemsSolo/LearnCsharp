namespace Numbers
{
    public class NumberWriter
    {
        public void PrintEvenNumbersFromZeroToX(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintOddNumbersFromZeroToX(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintNumbersFromZeroToXDivisibleByY(int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}