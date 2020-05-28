# AshayNEAT

AshayNEAT is my implementation of the NEAT (Neuroevolution of Augmenting Topologies) algorithm, developed by Kenneth O. Stanley and Risto Miikkulainen. 

According to the [original source](http://nn.cs.utexas.edu/downloads/papers/stanley.ec02.pdf), the algorithm is a genetic algorithm (GA) for the generation of evolving artificial neural networks. It alters both the weighting parameters and structures of networks, attempting to find a balance between the fitness of evolved solutions and their diversity. It is based on applying three key techniques: tracking genes with history markers to allow crossover among topologies, applying speciation (the evolution of species) to preserve innovations, and developing topologies incrementally from simple initial structures ("complexifying").

My version modifies the following to the algorithm:

1. The artificial neural networks start with only input and output neurons, and every input neuron doesn't have to be linked to an ouput neuron. This allows the algorithm to start with minimal complexity. 
2. The neural network isn't recurrent and only allows forward connections.
3. 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
Give examples
```

### Installing

A step by step series of examples that tell you how to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - The programming language used
* [Java](https://docs.oracle.com/en/java/) - The programming language used

## Authors

* **Ashay Parikh** - (https://ashayp.com/)

## License

This project is licensed under the Gnu General Public License - see the [LICENSE.md](https://github.com/ashayp22/AshayNEAT/blob/master/LICENSE) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc


