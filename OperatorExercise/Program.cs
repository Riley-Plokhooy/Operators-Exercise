namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius) 
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle() 
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"This area of a circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 2)}");
        }


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int sub =  a - b;
            int mult = a * b;

            int div = a / b;
            int remainder = a % b;

            //Console.WriteLine($"{a}/{b} is {div} remainder {remainder}");

            //PrintAreaOfCircle();

            int i = 3;
            int j = 4;
            int k = ++i * j++;

            Console.WriteLine(k); // What will this output? 16
        }
    }
}
