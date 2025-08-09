public class Activity
{
    // Member variables
    private string _name;
    private string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    //Method
    public void DisplayStartingMessage()
    {
        Console.Clear(); // This line will clear the Console
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Showspinner(3);
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Showspinner(2);
        Console.WriteLine($"You have Completed the {_name} for {_duration} seconds.");
        Showspinner(3);
    }
    public void Showspinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the previous number
    }
    Console.WriteLine();
}

}