class Breathing:Activity{
    public Breathing(){
        activity = "Breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }

    public void do_activity(){
        DateTime startTime = DateTime.Now;

        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            Console.Write("\nBreathe in...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("\nBreathe out...");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }

}