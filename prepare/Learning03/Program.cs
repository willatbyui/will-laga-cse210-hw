using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will\'s Encapsulation Learning Activity ");




        /* CREATE FRACTIONS */
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);



        /* CONVERT FRACTION TO DECIMAL */
            // first fraction
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());

            // second fraction
        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction2.GetDecimal());

            // third fraction
        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimal());

            // fourth fraction
        Console.WriteLine(fraction4.GetFraction());
        Console.WriteLine(fraction4.GetDecimal());

        /* TEST GETTER/SETTER */

        fraction1.Top = 6;
        fraction1.Bottom = 7;
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());

    }
}