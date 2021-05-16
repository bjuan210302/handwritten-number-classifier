using System.Collections.Generic;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NeuralNet
    {
        // Initially, the NN has 784 neurons as input, two hidden layers of 8 neurons and an output layer of 10 neurons
        private const int NeuronsPerLayer = 8;
        private const int NeuronsOutLayer = 10;
        
        private List<NDArray> _weights;
        private List<NDArray> _biases;
        private NDArray X;
        private NDArray Y;

        public NeuralNet(NDArray x, NDArray y)
        {
            this.X = x;
            this.Y = y;
            _weights = new List<NDArray>();
            _biases = new List<NDArray>();
            
            //Each neuron in the input has a weight pointing to the NEURONS_PER_LAYER neurons of the next layer
            //Same for the other layers
            _weights.Add(np.random.rand((NeuronsPerLayer, x.shape[0]))); //W1
            _biases.Add(np.zeros((NeuronsPerLayer, 1))); //b1
            _weights.Add(np.random.rand((NeuronsOutLayer, NeuronsPerLayer))); //W2
            _biases.Add(np.zeros((NeuronsOutLayer, 1))); //b2
        }

        private List<NDArray> FeedForward(NDArray input)
        {
            var z1 = np.dot(X, _weights[0]) + _biases[0]; //Input * W1 + b1
            var a = ActivationFunction.ComputeRelu(z1);
            var z2 =  np.dot(X, _weights[1]) + _biases[1]; //Input * W2 + b2
            var yPredict = ActivationFunction.ComputeSigmoid(z2);

            return new List<NDArray> {z1, a, z2, yPredict};;
        }

        private NDArray BackPropagation(List<NDArray> forwardResults, NDArray input)
        {
            var z1 = forwardResults[0];
            var a = forwardResults[1];
            var z2 = forwardResults[2];
            var yPredict = forwardResults[3];

            var numExamples = input.shape[1];

            var lost = (1 / numExamples) * np.sum(-Y * np.log(yPredict) - (1 - Y) * np.log(1 - yPredict));

            //Calculating gradients
            var dLdZ2 = yPredict - Y;
            var dLdW2 = (1 / numExamples) * np.dot(dLdZ2, a.T);
            var dLdb2 = (1 / numExamples) * np.sum(dLdZ2, 1, true);
            var dLdZ1 = np.multiply(np.dot(_weights[1].T, dLdZ2), (1 - np.power(a, 2)));
            var dLdW1 = (1 / numExamples) * np.dot(dLdZ1, X.T);
            var dLdb1 = (1 / numExamples) * np.sum(dLdZ1, 1, true);

            _weights[1] += dLdW2;
            _biases[1] += dLdb2;
            _weights[0] += dLdW1;
            _biases[0] += dLdb1;

            return lost;
        }
    }
}