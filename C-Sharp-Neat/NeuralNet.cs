﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuralNet
{
    private List<PNeuron> vecpNeurons;

    private int depth;

    public NeuralNet(List<PNeuron> n, int d)
    {
        vecpNeurons = n;
        depth = d;
    }

    public NeuralNet()
    {

    }

    //update method for the neural network
    public List<double> Update(List<double> inputs, string runtype) //parameter is 'snapshot' or 'active' 
    {
        //create a vector for the outputs
        List<double> outputs = new List<double>();

        //if the mode is snapshot, then we require all the neurons to be 
        //iterated through as many times as the network is deep. If the 
        //mode is set to active, then the method can return an output after just one iteration

        int FlushCount;

        if (runtype.Equals("snapshot"))
        {
            FlushCount = depth;
        }
        else
        {
            FlushCount = 1;
        }


        //iterate through the network FlushCount times

        for (int i = 0; i < FlushCount; i++)
        {
            //clear the output vector
            outputs = new List<double>();

            //this is an index into the current neuron
            int cNeuron = 0;

            //first set the outputs of the 'input' neurons to be equal 
            //to the values passed into the function in inputs

            while (vecpNeurons[cNeuron].getNeuronType().Equals("input"))
            {
                vecpNeurons[cNeuron].setOutput(inputs[cNeuron]);
                cNeuron++;
            }

            //set the output of the bias to 1
            vecpNeurons[cNeuron].setOutput(1);

            //then we step through the network a neuron at a time

            while (cNeuron < vecpNeurons.Count)
            {
                //this will hold the sum of all the inputs * weights
                double sum = 0;

                //sum this neuron's inputs by iterating through all the links into the neuron
                for (int lnk = 0; lnk < vecpNeurons[cNeuron].getVecLinkInSize(); lnk++)
                {
                    //get this link's weight
                    double Weight = vecpNeurons[cNeuron].getInLink(lnk).getWeight();

                    //get the output from the neuron this link is coming from
                    double NeuronOutput = vecpNeurons[cNeuron].getInLink(lnk).getPIn().getOutput();


                    //add to sum
                    sum += Weight * NeuronOutput;
                }

                //System.out.println(sum);

                //now we put the sum through the activation function and assign the 
                //value to the neuron's output
                vecpNeurons[cNeuron].setOutput(Sigmoid(sum, vecpNeurons[cNeuron].getActivationResponse())); //sigmoid the dinosaur(hehe)

                if (vecpNeurons[cNeuron].getNeuronType().Equals("output"))
                {
                    //add to out outputs
                    outputs.Add(vecpNeurons[cNeuron].getOutput());
                }

                //next neuron
                cNeuron++;
            }

        } //next ieration through the network


        //the network outputs need to be reset if tis type of update is performed
        //otherweise it is possible for dependencies to be built on the order the training data is presented

        if (runtype.Equals("snapshot"))
        {
            for (int n = 0; n < vecpNeurons.Count; n++)
            {
                vecpNeurons[n].setOutput(0);
            }
        }

        //return the outputs
        return outputs;
    }

    public double Sigmoid(double sum, double activation) //activation function
    {
        return 1.0 / (1 + Mathf.Pow(Mathf.Exp(1), (float)((-1 * sum) / activation)));
    }

    //draws the neural network on the screen
    public int getNNsize()
    {
        return vecpNeurons.Count;
    }

    public int getIdFromIndex(int index)
    {
        return vecpNeurons[index].getNeuronId();
    }

    public Vector2 getNodePosition(int index) //returns the position of a node based on its index
    {
        return new Vector2((float)vecpNeurons[index].getSplitX(), (float)vecpNeurons[index].getSplitY());
    }

    public Vector2 getNodePositionFromID(int id) //returns the position of a node based on its ID
    {
        foreach(PNeuron s in vecpNeurons)
        {
            if (s.getNeuronId() == id)
            {
                return new Vector2((float)s.getSplitX(), (float)s.getSplitY());
            }
        }
        return new Vector2(0, 0);
    }

    public List<PLink> getForwardConnections(int index)
    {
        return vecpNeurons[index].getVecLinksOut();
    }

    public string getTypeFromId(int id) //gets the type of neuron from id
    {
        foreach (PNeuron n in vecpNeurons)
        {
            if (n.getNeuronId() == id)
            {
                return n.getNeuronType();
            }
        }
        return "";
    }


    //returns a pneuron based on its index

    public PNeuron getNeuronFromIndex(int index)
    {
        return vecpNeurons[index];
    }

}
