
class PromptFactory
{
    public List<int> _usedPrompts = new List<int>();
    public List<string> _prompts = new List<string>
    {
    "What's one moment from today I want to remember, and why did it stand out?",
    "What am I carrying right now (a worry, a frustration, a hope) that I haven't said out loud?",
    "When did I feel most like myself this week?",
    "What's something I'm avoiding, and what would happen if I faced it?",
    "Who made a difference in my life recently, and have I told them?",
    "What would I do with tomorrow if I knew no one would judge me?",
    "What's a belief I held five years ago that I've since changed my mind about?",
    "What drained my energy today, and what restored it?",
    "If my younger self could see my life now, what would surprise them most?",
    "What am I grateful for that I usually take for granted?",
    "What's a small win I haven't given myself credit for?",
    "Where in my life am I saying yes when I really mean no?",
    "What does a good day look like for me, in specific detail?",
    "What's a fear that has quietly shaped my choices?",
    "What do I want to let go of before the end of this year?"
    };
    public string GetNextRandomPrompt()
    {
        int maxAttempts = 25;
        int attempt = 0;
        do
        {
            attempt++;
            int n = Random.Shared.Next(0, _prompts.Count);
            if (!_usedPrompts.Contains(n))
            {
                _usedPrompts.Add(n);
                return _prompts[n];
            }
        } while (true && attempt < maxAttempts);
        
        _usedPrompts.Clear();
        return _prompts[0];
    }
}