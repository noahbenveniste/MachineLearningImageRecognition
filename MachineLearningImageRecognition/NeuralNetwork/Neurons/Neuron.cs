using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neurons
{
    public abstract class Neuron
    {
        /**
         * Represents the result of multiplying the row vector of incoming
         * weights by the column vector of incoming activations and addding
         * the bias.
         */
        public int WeightedSum { get; set; }

        /**
         * The result of applying the sigmoid function to the weighted sum
         */
        public int Activation { get; set; }
        
    }
}
