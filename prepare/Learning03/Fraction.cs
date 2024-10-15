using System;

public class Fraction
{


    /* PRIVATE VARIABLES */
    private  int _top;
    private  int _bottom;



    /* CONSTRUCTOR */
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }



    /* CONSTRUCTOR W PARAM */
    public Fraction(int _top)
    {
        this._top = _top;
        this._bottom = 1;

    }


    /* CONSTRUCTOR W TWO PARAMS */
    
    public Fraction(int _top, int _bottom)
    {
        this._top = _top;
        this._bottom = _bottom;
    }

    /* GETTERS */
    public int Top
    {
        get {return _top;}
        set {_top = value;}

    }

    public int Bottom
    {
        get { return _bottom;}
        set { _bottom = value;}
    }

    /* FRACTION AS STRING */
    public string GetFraction()
    {
        return$"{_top}/{_bottom}";
    }

    /* DECIMAL VALUE */
    public double GetDecimal()
    {
        return(double)_top/_bottom;
    }

}