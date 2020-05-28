using System.Collections;
using System.Collections.Generic;

public class SubInnovation : MonoBehaviour
{
    //fields

    private readonly string InnovationType; //neuron or link

    private readonly int InnovationID;

    private readonly int NeuronIn;
    private readonly int NeuronOut;

    private readonly int NeuronID;

    private readonly string NeuronType;


    //constructor

    public SubInnovation(string type, int id, int neuronin, int neuronout, int neuronid, string neurontype)
    {
        InnovationID = id;
        InnovationType = type;
        NeuronIn = neuronin;
        NeuronOut = neuronout;
        NeuronID = neuronid;
        NeuronType = neurontype;
    }

    public bool sameInputOutput(int input, int output)
    {
        return (NeuronIn == input) && (NeuronOut == output);
    }

    public string getInnovationType()
    {
        return InnovationType;
    }

    public int getInnovationNumber()
    {
        return InnovationID;
    }

    public int getNeuronId()
    {
        return NeuronID;
    }
}
