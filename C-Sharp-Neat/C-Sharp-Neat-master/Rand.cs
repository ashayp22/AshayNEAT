using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand
{
    public static int randomInt(int min, int max)
    {
        return (int)(Random.Range(0f,1f) * (max - min + 1)) + min;
    }

    public static double randomNumber(double min, double max)
    {
        return Random.Range(0f, 1f) * (max - min) + min;
    }
}
