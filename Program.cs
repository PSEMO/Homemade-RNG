#region Test code
int maxValue = 20;
double numbersGenerated = 0;

double[] counts = new double[maxValue];

while (numbersGenerated < 1000000000)
{
    int randomNumber = RNG(0, maxValue - 1);
    Console.WriteLine(randomNumber);
    Thread.Sleep(20);

    numbersGenerated++;
    counts[randomNumber]++;
}

writeCounts();

void writeCounts()
{
    for (int i = 0; i < maxValue; i++)
    {
        Console.WriteLine(i + ": " + counts[i]);
    }
    Console.WriteLine("---------------------");
}
#endregion

//Creates a random number between given limits (min and max are inclusive)
int RNG(int min, int max)
{
    //Tick count that represents current time between "DateTime.MinValue.Ticks" and "DateTime.MaxValue.Ticks"
    int seed = (int)DateTime.Now.Ticks;
    //makes the seed positive
    seed = (seed + (seed >> 31)) ^ (seed >> 31);

    //adds the min value and gets the remainder of seed/max
    return (seed % (max + 1)) + min;
}