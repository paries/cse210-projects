/**
    exceed the requirements 
    1. Randomly choose scriptures from a list
    2. in Scripture.cs a list is kept to manage not hiding the same word twice.
**/

class Program
{
    static void Main(string[] args)
    {
        List<Verse> verses = new List<Verse>();
        verses.Add(new Verse("3 Nephi", "And now it came to pass that there were a great multitude gathered together, of the people of Nephi, round about the temple which was in the land Bountiful; and they were marveling and wondering one with another, and were showing one to another the great and marvelous change which had taken place.", 11, 1));
        verses.Add(new Verse("3 Nephi", "And they were also conversing about this Jesus Christ, of whom the sign had been given concerning his death.", 11, 2));
        verses.Add(new Verse("3 Nephi", "And it came to pass that while they were thus conversing one with another, they heard a voice as if it came out of heaven; and they cast their eyes round about, for they understood not the voice which they heard; and it was not a harsh voice, neither was it a loud voice; nevertheless, and notwithstanding it being a small voice it did pierce them that did hear to the center, insomuch that there was no part of their frame that it did not cause to quake; yea, it did pierce them to the very soul, and did cause their hearts to burn.", 11, 3));
        verses.Add(new Verse("3 Nephi", "And it came to pass that again they heard the voice, and they understood it not.", 11, 4));
        verses.Add(new Verse("3 Nephi", "And again the third time they did hear the voice, and did open their ears to hear it; and their eyes were towards the sound thereof; and they did look steadfastly towards heaven, from whence the sound came.", 11, 5));
        verses.Add(new Verse("3 Nephi", "And behold, the third time they did understand the voice which they heard; and it said unto them:", 11, 6));
        verses.Add(new Verse("3 Nephi", "Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him.", 11, 7));

        int start = Random.Shared.Next(0, verses.Count );
        int end = Random.Shared.Next(start, verses.Count );

        Reference reference;
        String text="";

        if (start == end)
        {
            reference = new Reference(verses[start].GetBook(), verses[start].GetChapter(), verses[start].GetVerse());
            text = verses[start].GetText();
        }
        else
        {
            reference = new Reference(verses[start].GetBook(), verses[start].GetChapter(), verses[start].GetVerse(), verses[end].GetVerse());
            for (int i = start; i <= end; i++)
            {
                text += verses[i].GetText() + " ";
            }
        }

        Scripture scripture = new Scripture(reference, text);

        do
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press the enter key or type quit? ");
            String userInput = Console.ReadLine();
            if (userInput == "quit" || userInput == "q")
            {
                break;
            }
            if ( !scripture.IsCompletelyHidden())
            {
                int wordsHide = Random.Shared.Next(1, 3);
                scripture.HideRandomWords(wordsHide);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("There are no more words to hide. ");
                break;
            }
        } while (true);

    }
}