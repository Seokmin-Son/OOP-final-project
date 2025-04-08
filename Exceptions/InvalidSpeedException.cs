using System;

class InvalidSpeedException
{
    public static void Check(double speed)
    {
        if (speed <= 0)
            throw new Exception("Speed must be greater than zero.");
    }
}
s