using System.Collections;
using System.Collections.Generic;

public class PLink
{
    //pointers to the neurons this link connects

    private PNeuron pIn;
    private PNeuron pOut;

    //the connection weights

    private double weight;


    //is this link a recurrent link

    private bool recurrent;

    public PLink(double w, PNeuron inn, PNeuron outn, bool r)
    {
        pIn = inn;
        pOut = outn;
        weight = w;
        recurrent = r;
    }
    //accessors

    public bool getRecurrent()
    {
        return recurrent;
    }

    public double getWeight()
    {
        return weight;
    }

    public PNeuron getPIn()
    {
        return pIn;
    }

    public PNeuron getPOut()
    {
        return pOut;
    }

    public string getTextFormat()
    { //returns a text encoding of the link
        string encoding = "PL:";
        encoding += pIn + "," + pOut + "," + weight + "," + recurrent;
        return encoding;
    }

}
