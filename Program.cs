namespace C__4_strings
{
    internal class Program
    {
        static int Persistence(int number)
        {
            int sum = 0;
            while (number > 10)
            {                
                int[] num = [1];
                int buf;
                while (number > 0)
                {
                    buf = number % 10;
                    number = number / 10;
                    num.Append(buf);
                }
                number = 1;
                for (int i = 0; i < num.Length; i++)
                {
                    number *= num[i];
                }
                sum += 1;
            }
            return sum;

        }
        static int CountsBits(int number)
        {          
            int bin = 0, mod = 1;


            while (number > 0)
            {
                bin += (number % 2) * mod;
                mod *= 10;
                number /= 2;
            }
            return bin;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CountBits");
            int dec = 39;
            int number = CountsBits(dec);
            Console.WriteLine(number);

            Console.WriteLine("Persistence");
            int number_2 = Persistence(dec);
            Console.WriteLine(number_2);
        }
    }
}
