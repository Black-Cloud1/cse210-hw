public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts = new List<string>{
    "What are some goals you’ve accomplished recently?",
    "Who are people that inspire you?",
    "What are things that make you smile?",
    "What are places you feel most relaxed?",
    "What are acts of kindness you’ve witnessed or done?",
    "What are things you’re looking forward to?",
    "What are lessons you’ve learned this year?",
    "What are hobbies or activities that bring you joy?",
    "What are challenges you’ve overcome?",
    "What are things you love about nature?"
    };

public ListingActivity(string name, string description) : base(name, description) {}
    // Methods
    public void Run()
    {
        DisplayStartingMessage(); // typo in method name, see below
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You may begin listing items...");
        Showspinner(3);

        List<string> responses = GetListFromUser();
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}