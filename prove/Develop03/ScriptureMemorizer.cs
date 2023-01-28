using System;

class ScriptureMemorizer
{
    private Scripture _scripture;
    private List<string> _scriptureTextList;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureTextList = new List<string>();
        TexttoList();
    }

    private void TexttoList()
    {
        _scriptureTextList = _scripture.toString().Split(" ").ToList();
    }

    public void WordsRemover()
    {
        int wordsToRemove = new Random().Next(2,4);
        int wordsRem = 0;

        do
        {
            int ramInx = new Random().Next(0, _scriptureTextList.Count());
            if (_scriptureTextList[ramInx].Contains('_') == false)
            {
                _scriptureTextList[ramInx] = new string('_', _scriptureTextList[ramInx].Count());
                wordsRem++;
                if (_scriptureTextList.Count() == wordsRem)
                {
                    _scriptureTextList[1] = new string('_', _scriptureTextList[].Count());
                    wordsRem++;
                }
            }
            
        }while(wordsRem != wordsToRemove);
    }
    public string toString()
        {
            return string.Join(' ', _scriptureTextList);
        }

    public bool NothingLeftOut()
    {
        bool value = false;

        foreach(string word in _scriptureTextList)
        {
            if (word.Contains('_') == false)
            {
                value = true;
                break;
            }
        }

        return value;
    }
}