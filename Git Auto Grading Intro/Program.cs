namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a method: Add, Subtract, Multiply, or Divide");
            string method = Console.ReadLine();
            Console.WriteLine("Enter another number!");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(solve(method));

            
        }

        public static string solve(string method)
        {
            if (method == "Add")
            {
                return "That equals " + Add;
            }
            if (method == "Subtract")
            {
                return "That equals " + Subtract;
            }
            if (method == "Multiply")
            {
                return "That equals " + Multiply;
            }
            if (method == "Divide")
            {
                return "Thats equals " + Divide;
            }
            else
            {
                return "Make sure you type the methods exactly as displayed";
            }
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static decimal Divide(int a, int b)
        {
            return a / b;
        }
    }
}


