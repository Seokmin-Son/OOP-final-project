using System;

class InvalidPriceException
{
    public static void Check(double price)
    {
        if (price < 0)
            throw new Exception("Price cannot be negative.");
    }
}
