using System;
public class Fraction
{
    private int topNumber;
    private int bottomNumber;

        public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int first)
    {
        topNumber = first;
        bottomNumber = 1;
    }

    public Fraction(int first, int second)
    {
        topNumber = first;
        bottomNumber = second;
    }
    public string GetFractionText(){
        string _text = $"{topNumber}/{bottomNumber}";
        return _text;
    }
    public double GetDecimalValue(){
        return (double)topNumber / (double)bottomNumber;
    }

    
}