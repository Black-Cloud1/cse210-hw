class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by guiding you through slow breathing."
                    );
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflecting Activity",
                        "This activity will help you reflect on times in your life when you showed strength or resilience."
                    );
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you focus by listing positive things in your life."
                    );
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}