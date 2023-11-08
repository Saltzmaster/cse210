class Reflecting: Activity{

    public Reflecting(){
        activity = "reflecting";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public List<string> refliction_prompts = new List<string>(){
       "Think of a time when you stood up for someone else.",
       "Think of a time when you did something really difficult.",
       "Think of a time when you helped someone in need.",
       "Think of a time when you did something truly selfless.",
    };
    public List<string> refliction_questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    public void do_activity(){
        Random random = new Random();
        int randomIndex = random.Next(refliction_prompts.Count);
        
        Console.WriteLine(refliction_prompts[randomIndex]);
        do_animation();
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(duration)){
            int randomQuestionIndex = random.Next(refliction_questions.Count);
            Console.WriteLine(refliction_questions[randomQuestionIndex]);
            do_animation();
        }
    }
}