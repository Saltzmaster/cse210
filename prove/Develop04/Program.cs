using System;

class Program
{
    static void Main(string[] args)
    {   
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing= new Listing();
        while(true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1.Start breathing activity");
            Console.WriteLine("    2.Start reflecting activity");
            Console.WriteLine("    3.Start listing activity");
            Console.WriteLine("    4.Quit");
            int choice = int.Parse(Console.ReadLine());

        switch (choice)
            {
            case 1:
                breathing.inro();
                breathing.do_activity();
                breathing.end();
                break;
            
            case 2:
                reflecting.inro();
                reflecting.do_activity();
                reflecting.end();
                break;
            case 3:
                listing.inro();
                listing.do_activity();
                listing.end();
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                return;
                
            }


        }
    }
}