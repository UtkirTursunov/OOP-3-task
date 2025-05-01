namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Boxer> boxers = new List<Boxer>
            {
                new Boxer{Id = Guid.NewGuid(), Surname = "Zokirov", Name = "Ravshan", Age = 25, Weight = 85.4 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Botirov", Name = "Aziz", Age = 22, Weight = 95.1 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Tursunov", Name = "Komil", Age = 28, Weight = 102 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Kamolov", Name = "Ilhom", Age = 24, Weight = 68.1 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Nematov", Name = "Umid", Age = 26, Weight = 58 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Boburov", Name = "Dilshod", Age = 21, Weight = 62 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Hakimov", Name = "Naim", Age = 19, Weight = 48 },
                new Boxer{Id = Guid.NewGuid(), Surname = "Ziyodov", Name = "Uktam", Age = 21, Weight = 45 }
            };

            foreach (var boxer in boxers)
            {
                boxer.Category = Boxer.GetWeightCategory(boxer.Weight);
            }

            Console.WriteLine("Please enter the weight of boxers that you want to take from database");
            double.TryParse(Console.ReadLine(), out double input);

            WeightCategory category = Boxer.GetWeightCategory(input);

            if (category == WeightCategory.Lightweight)
            {
                Console.WriteLine("\nYou have selected Lightweight category, which weight is under 50kg:\nBoxers in this category:");
                List<Boxer> lightWeightBoxers = boxers.Where(b => b.Category == WeightCategory.Lightweight).ToList();

                foreach (var boxer in lightWeightBoxers)
                {
                    Console.WriteLine($" - Id: {boxer.Id}, Surname: {boxer.Surname}, Name: {boxer.Name}" +
                        $", Age: {boxer.Age}, Weight: {boxer.Weight}");
                }
            }
            else if (category == WeightCategory.Middleweight)
            {
                Console.WriteLine("\nYou have selected Middleweight category, which weight between 50kg and 76kg" +
                    ":\nBoxers in this category:");
                List<Boxer> middleWeightBoxers = boxers.Where(b => b.Category == WeightCategory.Middleweight).ToList();

                foreach (var boxer in middleWeightBoxers)
                {
                    Console.WriteLine($" - Id: {boxer.Id}, Surname: {boxer.Surname}, Name: {boxer.Name}" +
                        $", Age: {boxer.Age}, Weight: {boxer.Weight}");
                }
            }
            else if (category == WeightCategory.Heavyweight)
            {
                Console.WriteLine("\nYou have selected Heavyweight category, which weight more than 90kg:\nBoxers in this category:");
                List<Boxer> heavyWeightBoxers = boxers.Where(b => b.Category == WeightCategory.Heavyweight).ToList();

                foreach (var boxer in heavyWeightBoxers)
                {
                    Console.WriteLine($" - Id: {boxer.Id}, Surname: {boxer.Surname}, Name: {boxer.Name}" +
                        $", Age: {boxer.Age}, Weight: {boxer.Weight}");
                }
            }
            else if (category == WeightCategory.Underfined)
            {
                Console.WriteLine("We don't have boxers in this weight category (from 76kg to 90kg). Please try to enter another weight..");
            }
        }
    }
}

