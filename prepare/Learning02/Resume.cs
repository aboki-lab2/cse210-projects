using System;

public class Resume
{
    public string _name;

    // The list is first initialized and populated.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // The Display method for each of the three jobs are called
            job.Display();
        }
    }
}