namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.WriteLine("Please enter first number:");
            num1=float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"A + B: {num1 + num2}\n");
            Console.WriteLine($"A - B: {num1 - num2}");
            Console.WriteLine("A x B:"+Math.Round((num1 * num2),2));
            
            if (num2 != 0)
            {
                Console.WriteLine($"A : B: {Math.Round((num1 / num2),2)}");
            }
            else
            {
                Console.WriteLine("Cannot be divided by 0!");
            }
            
        }
    }
}
