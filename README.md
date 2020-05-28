# AshayNEAT

AshayNEAT is my implementation of the NEAT (Neuroevolution of Augmenting Topologies) algorithm, developed by Kenneth O. Stanley and Risto Miikkulainen. 

According to the [original paper on the algorithm](http://nn.cs.utexas.edu/downloads/papers/stanley.ec02.pdf), the algorithm is a genetic algorithm (GA) for the generation of evolving artificial neural networks. It alters both the weighting parameters and structures of networks, attempting to find a balance between the fitness of evolved solutions and their diversity. It is based on applying three key techniques: tracking genes with history markers to allow crossover among topologies, applying speciation (the evolution of species) to preserve innovations, and developing topologies incrementally from simple initial structures ("complexifying").

My version modifies the following to the algorithm:

1. The artificial neural networks start with only input and output neurons, and every input neuron doesn't have to be linked to an ouput neuron. This allows the algorithm to start with minimal complexity. 
2. The neural network isn't recurrent and only allows forward connections.
3. The probabilities of increasing complexity are larger, such as the probability of adding neurons or links. 
4. The activation function is Sigmoid, and there is no activation pertubation (the activation function doesn't change). 

## Getting Started

These instructions will get you a copy of the algorithm and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

Your machine needs to be compatiable for running Java or C# Code. I recommend using the following IDEs or Engines that I have used the algorithm with:

Java
```
jMonkeyEngine
NetBeans
```
C#
```
Unity Game Engine
Visual Studio
```

### Installing

A step by step series of examples that tell you how to get a development env running

Download the zipped version of this repository and choose the C# version or Java version of the algorithm. Then, add the unzipped files to your project directory

Next, adjust the hyperparameters found in Settings.cs or Settings.java if you want to.
```
public static int NUM_AI = 40; //changes the number of agents to 40
```
Then, declare and instantiate a reference to the algorithm in your code.
```
private Ga neatAlgorithm = new Ga(Settings.NUM_AI, 10, 2); //the parameters are the number of ai, the number of input neurons, the number of output neurons
```
Then, declare and instantiate a reference to the algorithm in your code.
```
private Ga neatAlgorithm = new Ga(Settings.NUM_AI, 10, 2); //the parameters are the number of ai, the number of input neurons, the number of output neurons
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

* My Sources
  * [AI Techniques for Game Programming by Mat Buckland](https://www.amazon.com/Techniques-Programming-Premier-Press-Development/dp/193184108X)
   * [Evolving Neural Networks through Augmenting Topologies by Kenneth O. Stanley and Risto Miikkulainen](http://nn.cs.utexas.edu/downloads/papers/stanley.ec02.pdf)
* Additional Sources
  * [NEAT: An Awesome Approach to NeuroEvolution](https://towardsdatascience.com/neat-an-awesome-approach-to-neuroevolution-3eca5cc7930f)
  * [The NeuroEvolution of Augmenting Topologies (NEAT) Users Page](https://www.cs.ucf.edu/~kstanley/neat.html)
* etc


