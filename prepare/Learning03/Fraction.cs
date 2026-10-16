using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Fraction
{
//  Attributes: ================================================
    private int _top;
    private int _bottom;

//  Costructors: ===============================================

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

//  Getters & Setters: =========================================

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

//  Methods: ===================================================

    public string GetFractionString()
    {
        return $"{_top.ToString()}/{_bottom.ToString()}";
    }

    public double GetFractionDecimal()
    {
        return (double)_top / _bottom;
    }

}