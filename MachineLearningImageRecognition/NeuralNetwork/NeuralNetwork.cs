using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        public int NumLayers { get; set; }

        private NetworkLayer[] _layers;
        public NetworkLayer[] Layers
        {
            get { return this._layers; }
        }

        public NeuralNetwork()
        {

        }

    }
}
