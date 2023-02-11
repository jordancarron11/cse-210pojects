using System;

class Book
{
    private string _book;
    public Book (string book) 
    {
        _book = book;
        // _chapter  = chapter;
        // _verse = verse;
    }

    public string toString()
    {
        return string.Format("{0}", _book);
        // _chapter, _verse
    }
}