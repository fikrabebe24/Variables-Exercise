namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName="Bingo"; //Declaration syntax
            int dogAge = 5; //Declartions and Initialization
            char firstInitial = 'B' ;
            bool isHungry = true;
            double dogWeight = 110.7;
            decimal dogHeight = 2.5m;


            Console.WriteLine($"My dog's name is {dogName} and he is {dogAge} years old. His initial is {firstInitial}.");

            Console.ReadLine();

            Console.WriteLine($"He is {dogWeight}lbs and is {dogHeight} feet tall.");
            Console.WriteLine("and it is frustratingly {isHungry. ToString(). ToLower()} he is always hungry!");

        }
    }
}
