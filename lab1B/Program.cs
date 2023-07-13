namespace lab1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartSequence();
        }
        static void StartSequence()
        {
            int[] NumberArray = new int[4];
            int[] PopulateResult = Populate(NumberArray);
            int sum = GetSum (PopulateResult);
            Console.WriteLine(sum);
            for (int i = 0; i < PopulateResult.Length; i++)
            {

                Console.Write(PopulateResult[i] + " ");
            }
            int product = GetProduct(PopulateResult, sum);
            GetQuotient(product);

        }



        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Int32.Parse(userInput);
                array[i] = number;
            }
            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            if (sum < 20)
                {
                throw new Exception("Number is too low.");
            }
            return sum;
        }




        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a random number between 1 and {0}",
            array.Length);
            string randomIndex = Console.ReadLine();
            int randomIndexInt = Int32.Parse(randomIndex)- 1;
            if (randomIndexInt > array.Length)
            {
                throw new Exception("Out of Range!");
            }
            int randomNumber = array[randomIndexInt];
            Console.WriteLine("Random number is: {0}", randomNumber);
            int product = randomNumber * sum;
            Console.WriteLine("This is the product: {0}", product);
            return product;
        }
        static decimal GetQuotient(int product)
        {
            //promt user for number to divide it  by
            Console.WriteLine("Give me a number to divide the product by.");
            string userInput = Console.ReadLine();
            int divisor = Int32.Parse(userInput);
            if (divisor ==0)
            {
                throw new Exception("Out of Range!");
            }
            decimal quotient = product / divisor;

            Console.WriteLine("This is the Quotient: {0}", quotient);
            return quotient;
        }
        }
    }
