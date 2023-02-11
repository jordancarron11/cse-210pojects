using System;

class Scripture
{
    private string _scriptureText;
    private Book _book1;

    public Scripture (Book book1, string scriptureText)
    {
        _book1 = book1;
        _scriptureText = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _scriptureText);
    }
}