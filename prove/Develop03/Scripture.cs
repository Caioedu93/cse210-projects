using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private List<int> hiddenIndices;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        hiddenIndices = new List<int>();
        SplitWords(text);
    }

    private void SplitWords(string text)
    {
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordCount = words.Count;
        int wordToHideCount = random.Next(1, wordCount - hiddenIndices.Count + 1);

        while (wordToHideCount > 0)
        {
            int index = random.Next(wordCount);
            if (!hiddenIndices.Contains(index))
            {
                hiddenIndices.Add(index);
                words[index].Hide();
                wordToHideCount--;
            }
        }
    }

    public string GetReferenceString()
    {
        return reference.ToString();
    }

    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            if (hiddenIndices.Contains(i))
            {
                renderedWords.Add("______");
            }
            else
            {
                renderedWords.Add(words[i].GetText());
            }
        }

        return string.Join(" ", renderedWords);
    }

    public bool IsCompletelyHidden()
    {
        return hiddenIndices.Count == words.Count;
    }
}
