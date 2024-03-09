 class PromptGenerator
    {
        private List<string> _prompts;

        public PromptGenerator()
        {
            // Initialize with some sample prompts
            _prompts = new List<string>
            {
                "What surprised me today?",
                "How did I challenge myself today?",
                "What was a small victory I achieved today?",
                "What did I learn today that I didn't know yesterday?",
                "What was the most beautiful thing I saw today?",
                "How did I show kindness or compassion to others today?",
                "What made me laugh out loud today?",
                "What made me feel grateful today?",
                "What mistake did I make today, and what did I learn from it?",
                "How did I take care of myself today, physically or emotionally?",
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        }

        public string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }