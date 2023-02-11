using System;
//going to hold my differnt References 
class Reference
{
    private string _Reference;
    public Reference (string Reference) 
    {
        _Reference = Reference;
    }

    public string toString()
    {
        return string.Format("{0}", _Reference);
    }
}