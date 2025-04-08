using System;

class InvalidCargoCapacityException
{
    public static void Check(int capacity)
    {
        if (capacity < 0 || capacity > 100000)
            throw new Exception("Cargo capacity must be between 0 and 100000.");
    }
}
