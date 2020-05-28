using System.Collections;
using System.Collections.Generic;

public class PNeuron
{
    private List<PLink> vecLinksIn;
    private List<PLink> vecLinksOut;

    //sum of weights x inputs

    private double sumActivation;

    //the output from this neuron

    private double dOutput;

    //what type of neuron this is?
    private string neuronType;

    //id
    private int neuronId;

    //sets the curvature of the sigmoid function
    private double activationResponse;

    //used in visualization of the phenotype
    private int PosX, PosY;
    private double SplitX, SplitY;

    //constructor

    public PNeuron(string type, int id, double y, double x, double ActResponse)
    {
        vecLinksIn = new List<PLink>();
        vecLinksOut = new List<PLink>();
        neuronType = type;
        neuronId = id;
        sumActivation = 0;
        dOutput = 0;
        PosX = 0;
        PosY = 0;
        SplitX = x;
        SplitY = y;
        activationResponse = ActResponse;
    }

    //accessors + mutators

    public List<PLink> getVecLinksIn()
    {
        return vecLinksIn;
    }

    public List<PLink> getVecLinksOut()
    {
        return vecLinksOut;
    }

    public int getVecLinkInSize()
    {
        return vecLinksIn.Count;
    }

    public int getVecLinkOutSize()
    {
        return vecLinksOut.Count;
    }

    public PLink getInLink(int i)
    {
        return vecLinksIn[i];
    }

    public PLink getOutLink(int i)
    {
        return vecLinksOut[i];
    }

    public void addIn(PLink arr)
    {
        vecLinksIn.Add(arr);
    }

    public void addOut(PLink arr)
    {
        vecLinksOut.Add(arr);
    }

    public string gettype()
    {
        return neuronType;
    }


    public double getSumActivation()
    {
        return sumActivation;
    }

    public double getOutput()
    {
        return dOutput;
    }

    public void setOutput(double d)
    {
        dOutput = d;
    }

    public string getNeuronType()
    {
        return neuronType;
    }

    public int getNeuronId()
    {
        return neuronId;
    }

    public double getActivationResponse()
    {
        return activationResponse;
    }

    public int getPosX()
    {
        return PosX;
    }

    public int getPosY()
    {
        return PosY;
    }

    public double getSplitX()
    {
        return SplitX;
    }

    public double getSplitY()
    {
        return SplitY;
    }

    //text format stuff

    public string getTextFormat()
    { //returns the string format of the neuron
        string encoding = "PN:";
        encoding += "0,0," + neuronType + "," + neuronId + "," + activationResponse + "," + PosX + "," + PosY + "," + SplitX + "," + SplitY;

        return encoding;
    }

}
