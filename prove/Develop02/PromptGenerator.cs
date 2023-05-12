using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>()
        {
            "What was one positive thing that happened to me today?",
            "What did you eat for breakfast?",
            "What did you eat for lunch?",
            "What did you eat for dinner?",
            "What scriptures did you read today?",
            "What did the spirit teach you today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
