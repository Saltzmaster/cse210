class Activity{

    public string activity;
    public string description;

    public int duration;


    public void inro(){
        Console.WriteLine($"Welcome to the {activity} Activity");
        Console.WriteLine(description);

        Console.WriteLine("How long, in seconds, would you like for your section?");
        duration= int.Parse (Console.ReadLine());

        Console.WriteLine("Get read...");
        do_animation();

    }



    public void end(){
        Console.WriteLine("Well done!");
        do_animation();
        Console.WriteLine($"You have completed another {duration} seconds for the {activity} Activity");
        do_animation();
        Console.Clear();
    }

    public void do_animation(){
        for(int i= 0; i <3; i++){

            
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
        }
      
    }

}