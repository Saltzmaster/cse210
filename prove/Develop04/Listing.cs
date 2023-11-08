class Listing:Activity{

    public Listing(){
        activity = "listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public List<string> listening_prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    public void do_activity(){
        Random random = new Random();
        int randomIndex = random.Next(listening_prompts.Count);
        Console.WriteLine(listening_prompts[randomIndex]);
        do_animation();
        Console.WriteLine("When you finish hit enter.");
        Thread.Sleep(2000);
        Console.WriteLine("(Put your entry here):");
        string entry;
        var entries = new System.Collections.Generic.List<string>();
        while (true)
        {
            entry = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entry))
            {
                break;
            }
            entries.Add(entry);
        }
        Console.WriteLine("You have entered the following entries:");
        foreach (var i in entries)
        {
            Console.WriteLine(i);
        }
    }
}
