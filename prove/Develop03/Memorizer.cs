using System;

class Memorize
{
    private Scripture _scripture;
    private List<string> _verseSplit;
    private int _removedWords = 0;

    public Memorize(Scripture scripture)
    {
        _scripture = scripture;
        _verseSplit = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        _verseSplit = _scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = 3;
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _verseSplit.Count());
            if (_verseSplit[rndIndex].Contains('_') == false)
            {
                _verseSplit[rndIndex] = new string('_', _verseSplit[rndIndex].Length);
                wordsRemoved++;
                _removedWords++;

                if ((_verseSplit.Count() - numWordsToRemove) <= _removedWords && _removedWords < (_verseSplit.Count() + 1))
                {
                    wordsRemoved = 3;
                }
            }

        } while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _verseSplit);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _verseSplit)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }

        return retValue;
    }
}
