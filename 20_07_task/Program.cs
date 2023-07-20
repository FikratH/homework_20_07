namespace _20_07_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write one or two numbers (one for squaring, two for raising to power)");
            string[] stringArray = Console.ReadLine().Split();
            int[] numArray = new int[stringArray.Length];

            foreach(string num in stringArray)
            {
               numArray[Array.IndexOf(stringArray,num)] = int.Parse(num);
            }
            if(numArray.Length == 1) {
                SquareOrPower(numArray[0]);
            }
            if(numArray.Length==2)
            {
                SquareOrPower(numArray[0], numArray[1]);
            }
        }
        public static void SquareOrPower(int n)
        {
            Console.WriteLine(n * n);
        }
        public static void SquareOrPower(int n , int k)
        {
            Console.WriteLine(Math.Pow(Convert.ToDouble(n), Convert.ToDouble(k)));
        }
    }
}