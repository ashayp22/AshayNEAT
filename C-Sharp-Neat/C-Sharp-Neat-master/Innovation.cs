using System.Collections;
using System.Collections.Generic;

public class Innovation
{
    //static class of all the innovation values
    private List<SubInnovation> dataBase;


    public Innovation()
    {
        dataBase = new List<SubInnovation>();
    }

    public int CheckInnovation(int input, int output, string type) //checks to see if an innovation exists
    {
        foreach (SubInnovation innovation in dataBase)
        {
            if (innovation.sameInputOutput(input, output) && innovation.getInnovationType().Equals(type)) //same innovation
            {
                return innovation.getInnovationNumber(); //returns its id
            }
        }
        return -1;
    }

    public void CreateNewInnovation(int neuron1, int neuron2, string type, int neuronID, string typeNeuron)
    {
        SubInnovation newInnovation = new SubInnovation(type, dataBase.Count + 1, neuron1, neuron2, neuronID, typeNeuron); //creates a new innovation that is link
        dataBase.Add(newInnovation);
    }

    public int GetNeuronId(int id) //returns the id of a neuron given its innovation id(not same)
    {
        foreach (SubInnovation innovation in dataBase)
        {
            if (innovation.getInnovationNumber() == id)
            {
                return innovation.getNeuronId();
            }
        }
        return -1;
    }

    public int NextNumber() //next number
    {
        return dataBase.Count + 1;
    }

    public void ClearInnovations()
    {
        dataBase = new List<SubInnovation>();
    }


    public int databaseSize()
    {
        return dataBase.Count;
    }

}
