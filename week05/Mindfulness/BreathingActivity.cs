public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity(string name, string description) : base(name, description) { }

    // Method
    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsed += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsed += 3;
        }

        DisplayEndingMessage();
    }
}