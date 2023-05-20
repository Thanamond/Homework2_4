using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        string[] population = Console.ReadLine().Split();
        int maxPopulation = 0;
   
        for (int i = 1; i < N-K; i++)
        {
            int sum = 0;
            sum += int.Parse(population[i]);
            for (int j = 0; j < K; j++)
            {
                sum += int.Parse(population[i+1]);
                sum += int.Parse(population[i-1]);
            }
            if (sum > maxPopulation)
            {
                maxPopulation = sum;
            }
        }
        Console.WriteLine(maxPopulation);
    }
}
