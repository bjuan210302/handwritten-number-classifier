using System;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NeuralNet
    {
        // Initially, the NN has 784 neurons as input, one hidden layer of 8 neurons and a output layer of 10 neurons
        private int NUM_INPUT_TO_PROCESS = 1;
        private int INPUT_SIZE = 784;
        private int NEURONS_PER_LAYER = 8;
        
        private NDArray _x;
        private NDArray _y;
        private NDArray _biases;
        private NDArray _weights;

        public NeuralNet()
        {
            
        }
        public NeuralNet(NDArray x, NDArray y)
        {
            this._x = x;
            this._y = y;
        }
        
        public NeuralNet(String a)
        {
            //Each neuron in the input has a weight pointing to the NEURONS_PER_LAYER neurons of the next layer
            
            _weights = np.random.rand((INPUT_SIZE, NEURONS_PER_LAYER));
            
            //And the matrix multiplication of the input (NUM_INPUT_TO_PROCESS x INPUT_SIZE) * (INPUT_SIZE * NEURONS_PER_LAYER)
            // = (NUM_INPUT_TO_PROCESS x NEURONS_PER_LAYER)
            //Each one of those results needs to be summed with a bias integer

            //This [-10, 10] range for the biases is completely arbitrary
            _biases = np.random.randint(-10, 10, (NUM_INPUT_TO_PROCESS, NEURONS_PER_LAYER));
        }

        public NDArray ActivationFunction(NDArray matrix)
        {
            //The Sigmoid Function
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }
    }
}