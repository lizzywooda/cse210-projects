public class Resume
{
    public string _member;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_member}");
        Console.WriteLine($"Jobs: ");

        foreach (Job jobs in _jobs)
        {
            jobs.Display();
        }
    }
}