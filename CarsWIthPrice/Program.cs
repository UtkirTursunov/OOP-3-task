namespace CarsWIthPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car {Name = "Chevrolet", Model = "Damas", Price = 90000000},
                new Car {Name = "Mercedes", Model = "Gelik", Price = 1000000000},
                new Car {Name = "Toyota", Model = "Prado", Price = 500000000},
                new Car {Name = "Chevrolet", Model = "Tahoe", Price = 1200000000},
                new Car {Name = "Toyota", Model = "Lexus", Price = 1100000000},
                new Car {Name = "Chevrolet", Model = "Cobalt", Price = 140000000}
            };

            Console.WriteLine("Please enter the first prices and the second price, than you can" +
                " see cars which price are between these prices...");
            Console.WriteLine("\nEnter the first price:");
            decimal.TryParse(Console.ReadLine(), out decimal input);

            Console.WriteLine("Enter the second price:");
            decimal.TryParse(Console.ReadLine(), out decimal input2);

            if (input == input2)
            {
                Console.WriteLine("You should enter difference prices, not equal. Please try again!");
            }
            else
            {
                if (input > input2)
                {
                    decimal temp = input;
                    input = input2;
                    input2 = temp;
                }

                bool found = false;

                foreach (var car in cars)
                {
                    if (car.Price > input && car.Price < input2)
                    {
                        Console.WriteLine($"\nName:{car.Name}, Model:{car.Model}, Price: {car.Price}");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("\nNo cars found in the selected price range.");
                }
            }
        }
    }
}
