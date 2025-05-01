namespace Box;

public class Boxer
{
    public Guid Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public WeightCategory Category { get; set; }

    public static WeightCategory GetWeightCategory(double weight)
    {
        if (weight < 50)
        {
            return WeightCategory.Lightweight;
        }
        else if (weight >= 50 && weight < 76)
        {
            return WeightCategory.Middleweight;
        }
        else if (weight >= 90)
        {
            return WeightCategory.Heavyweight;
        }
        else
        {
            return WeightCategory.Underfined;
        }
    }
}
