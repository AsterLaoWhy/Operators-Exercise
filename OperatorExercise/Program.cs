namespace OperatorExercise
{
    public class Program
    {
        static void AreaOfCircle()
        {
            Console.WriteLine("Please type a number");
            double radius  = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with the radius {radius} is {area}.");
        }
        static void Main(string[] args)
        {
             
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a/b;
            int remainder = a%b;
            Console.WriteLine($"{a}/{b} is  {quotient} and the remainder is {remainder}");
            AreaOfCircle();
            //The value of K in the following code is 4*4 which is 16. ++i increments I before using it and J++ keeps the variable then increments it after running the line
            //Console.WriteLine("Hello, World!");
        }
    }
}
