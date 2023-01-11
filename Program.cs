namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            //Use the new keyword to create an instance of the array.
            //The new operator is used to create an object or instantiate an object.
            //Here in the example an object is created for the class using the new.

            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            // double int dice = random.NextDouble(1, 7 ) for a double number

            Console.WriteLine("Roll or not?");
            Console.WriteLine("Please say Yes or No.");
            string input = Console.ReadLine();

            if(input=="Yes")
            {
                Console.WriteLine("You rolled a {0} and a {1}", dice1, dice2);
            }
            else
            {
                Console.WriteLine("You quit.");
            }

            //Console.WriteLine(dice);

            //Console.ReadKey();

        }
    }
}