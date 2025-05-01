namespace Pupil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> pupils = new List<Pupil>
            {
            new Pupil { id = Guid.NewGuid(), name = "Utkir", surname = "Tursunov", gradeLevel = 11, grade = Grade.Excellent },
            new Pupil { id = Guid.NewGuid(), name = "Sanjarbek", surname = "Nurilloyev", gradeLevel = 7, grade = Grade.Good },
            new Pupil { id = Guid.NewGuid(), name = "Bekzod", surname = "Shodiyev", gradeLevel = 8, grade = Grade.Satisfactory },
            new Pupil { id = Guid.NewGuid(), name = "Dilshod", surname = "Azizov", gradeLevel = 10, grade = Grade.Poor },
            new Pupil { id = Guid.NewGuid(), name = "Hakim", surname = "Jurayev", gradeLevel = 6, grade = Grade.VeryPoor }
            };

            Console.WriteLine("Please enter the grade of pupil");
            int.TryParse(Console.ReadLine(), out int input);

            Console.Clear();

            if (Enum.IsDefined(typeof(Grade), input))
            {
                Grade selectedGrade = (Grade)input;

                Console.WriteLine($"\nPupils with {selectedGrade} grade");

                for (int i = 0; i < pupils.Count; i++)
                {
                    if (pupils[i].grade == selectedGrade)
                    {
                        Console.WriteLine($"\nName:{pupils[i].name},\nSurname:{pupils[i].surname}," +
                            $"\nId:{pupils[i].id},\nGrade level:{pupils[i].gradeLevel}");
                    }

                }
            }
        }
    }
}
