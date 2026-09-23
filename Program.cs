int totalsteps = 29;

for (int i = 1; i <= totalsteps; i++)
{
    Console.WriteLine($"Loading.. file {i} of {totalsteps} completed.");
    if (i % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached! Saving progress...\n");
    }
}

Console.WriteLine("\nLoading complete!");