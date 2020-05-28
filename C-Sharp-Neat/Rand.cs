using System;
using System.Collections;
using System.Collections.Generic;


public class Rand
{
    public static int randomInt(int min, int max)
    {
        Random random = new Random();    
        return (int)(random.Next(0, 1) * (max - min + 1)) + min;
    }

    public static double randomNumber(double min, double max)
    {
        Random random = new Random();  
        return random.Next(0, 1) * (max - min) + min;
    }
}
