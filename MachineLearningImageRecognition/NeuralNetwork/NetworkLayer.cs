using System;
using System.Collections.Generic;
using System.Text;
using NeuralNetwork.Neurons;

namespace NeuralNetwork
{
    public class NetworkLayer
    {
        /**
         * Enum to define the types of neurons the layer will have.
         * Didn't bother creating multiple layer classes because they won't
         * really behave differently other than some different equations
         * being applied for back propagation.
         */
        public enum Types { INPUT, HIDDEN, OUTPUT }

        /* Properties */

        /**
         * The type of neuron the layer will contain. The first layer of
         * a NN that receives input is the INPUT layer, the final layer
         * where in the case of this NN a class of image is chosen is the
         * OUTPUT layer, any layers in between are HIDDEN.
         */
        private Types _type;
        public Types Type
        {
            get { return this._type;  }
        }

        private Neuron[] _neurons; // Private attribute
        public Neuron[] Neurons // Public auto property; only want a client to be able to get neurons
        {
            get { return this._neurons;  }
        }

        private int _size;
        public int Size
        {
            get { return this._size; }
        }

        /**
         * A list of activation values for each neuron in this layer.
         */
        private float[] _currentActivation;

        /**
         * Need to maintain a history of the activations for this layer
         * for SGD. Each element in this list points to an old list of
         * activations from a previous iteration of feedforward
         * for the given minibatch.
         */
        private float[] _activationHistory;

        /**
         * The error calculated for this layer during the current iteration
         * of back propagation.
         */
        private float[] _currentError;

        /**
         * Similar to activationHistory but with error values.
         */
        private float[] _errorHistory;

        /**
         * The weight matrix w for this layer. Represents the weights for connections
         * with the previous layer in the network.
         */
        private float[][] _weights;

        public NetworkLayer ( int size, Types type )
        {
            this._size = size;
            this._type = type;
            if ( type == Types.INPUT )
            {
                this._neurons = new InputNeuron[size];
            }
            else if ( type == Types.HIDDEN )
            {
                this._neurons = new HiddenNeuron[size];
            }
            else
            {
                this._neurons = new OutputNeuron[size];
            }
        }
    }
}
