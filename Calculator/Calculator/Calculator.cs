namespace Calculator
{
    public class SimpleCalculator
    {
        public SimpleCalculator()
        {
        }

        public int Add (int a, int b)
        {
            return a + b; 
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Divide(int a, int b)
        {
            float result = 0;
            if (b == 0)
            {
                Console.WriteLine("Division by zero. Press any key to continue...");
            }
            else
            {
                result = a / b;
            }

            return result;
        }


    }
}
