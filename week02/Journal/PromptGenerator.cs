using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What made you smill today?",
        "What did you do today?",
        "What was the best part of your day?",
        "How was your family today",
        "What do you want to achieve this week?",
        "How do you feel about your co-workers today?",
        "What was in your mind today?"
    };
    // Method
    public string GetRandomPrompt()
    //Import Random from the library
    //to generate a random prompt
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}