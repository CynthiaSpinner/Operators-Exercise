namespace OperatorExercise
{
    public class Program
    {
        //Exercise two__________
        public static double AreaOfCircle(double radius) 
        {
        
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        
        }


        static void Main(string[] args)
        {
            Console.WriteLine("please enter the radius of your circle");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
            
            Console.WriteLine();
            Console.WriteLine("press any key for exercise 1");
            Console.ReadLine();
            Console.Clear();

            //Exercise one__________
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;


            Console.WriteLine("Exercise One Results: ");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}" );


            
        }
    }
}
