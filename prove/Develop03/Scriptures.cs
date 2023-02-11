using System;

class Scripture
{
    private string _scriptureText;
    private Reference _book;

    public Scripture (Reference book, string scriptureText)
    {
        _book = book;
        _scriptureText = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _scriptureText);
    }
}