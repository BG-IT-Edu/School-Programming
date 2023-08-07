using rm.Trie;
using System;

class PrefixWords
{
    static void Main()
    {
        var trie = new Trie();
        var text = Console.ReadLine();
        var prefix = Console.ReadLine();
        foreach (var word in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            trie.AddWord(word);
        }

        Console.WriteLine(trie.Count());
        Console.WriteLine(trie.UniqueCount());
        var allWords = trie.GetWords();
        var removedWords = trie.GetWords(prefix);
        Console.WriteLine(string.Join(", ", allWords));
        Console.WriteLine(string.Join(", ", removedWords));

        trie.RemovePrefix(prefix);

        Console.WriteLine(string.Join(", ", trie.GetWords()));
    }
}
