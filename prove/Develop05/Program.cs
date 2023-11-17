using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;
                case "2":
                    DisplayGoals(goals);
                    break;
                case "3":
                    SaveGoals("goals.txt", goals);
                    Console.WriteLine("Goals saved.");
                    break;
                case "4":
                    goals = LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    break;
                case "5":
                    RecordEvent(goals);
                    break;
                case "6":
                    SaveGoals("goals.txt", goals);
                    Console.WriteLine("Goals saved. Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                goals.Add(CreateSimpleGoal());
                break;
            case "2":
                goals.Add(CreateEternalGoal());
                break;
            case "3":
                goals.Add(CreateChecklistGoal());
                break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                goals.Add(CreateSimpleGoal());
                break;
        }
    }

    static Simple CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string nameTs = Console.ReadLine();
        Console.Write("Enter a short description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the initial value of the goal: ");
        int pointsTs = int.Parse(Console.ReadLine());

        return new Simple(nameTs, pointsTs);
    }

    static Eternal CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string nameTs = Console.ReadLine();
        Console.Write("Enter a short description of the goal: ");
        string tsDescription = Console.ReadLine();
        Console.Write("Enter the initial value of the goal: ");
        int pointsTs = int.Parse(Console.ReadLine());

        return new Eternal(nameTs, pointsTs, tsDescription);
    }

    static Checklist CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string nameTs = Console.ReadLine();
        Console.Write("Enter a short description of the goal: ");
        string tsDescription = Console.ReadLine();
        Console.Write("Enter the initial value of the goal: ");
        int pointsTs = int.Parse(Console.ReadLine());
        Console.Write("Enter the required count for the checklist goal: ");
        int tsRequiredCount = int.Parse(Console.ReadLine());

        return new Checklist(nameTs, pointsTs, tsDescription, tsRequiredCount);
    }

    static void RecordEvent(List<Goal> goals)
    {
        DisplayGoals(goals);

        Console.Write("\nEnter the index of the goal to record an event: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            goals[index].TsRecord();
            Console.WriteLine("Event recorded. Points added.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void DisplayGoals(List<Goal> goals)
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goals.Count; i++)
        {
            goals[i].TsDisplay();
        }
        Console.WriteLine($"\nTotal Score: {goals.Sum(g => g.TsPoints)}\n");
    }

    static void SaveGoals(string fileName, List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.TsToString());
            }
        }
    }

    static List<Goal> LoadGoals(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    Goal goal = CreateGoalInstance(parts[0]);
                    goal.TsFromString(line);
                    loadedGoals.Add(goal);
                }
            }
        }

        return loadedGoals;
    }

    static Goal CreateGoalInstance(string goalType)
    {
        switch (goalType)
        {
            case nameof(Simple):
                return new Simple("", 0);
            case nameof(Eternal):
                return new Eternal("", 0, "");
            case nameof(Checklist):
                return new Checklist("", 0, "", 0);
            default:
                throw new ArgumentException("Invalid goal type");
        }
    }
}