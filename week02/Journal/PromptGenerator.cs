namespace week02.Journal
{
    public class PromptGenerator
    {
        List<string> _prompts = [
            "What are three things I am greatful for today?",
            "My intentions today were... ",
            "My goals today were... how did they go?",
            "If I couldnt fail today I would...",
            "Three thing I loved about myself today were...",
            "I can experience joy about today by...",
            "My ideal day looks like",
            "Where do I see Myself in a day/month/year?",
            "I am proud of myself for..."
        ];
        //credit to the following website for the list above.  https://www.justanothermummyblog.com/journaling-101-how-to-start-and-why-journal-prompts/
        public string GetRandomPrompt()
        {
            //creates random int than places it with the prompt.
            Random random = new Random();
            int ranint = random.Next(0, 9);
            string prompt = _prompts[ranint];
            return prompt;
        }

    }
}