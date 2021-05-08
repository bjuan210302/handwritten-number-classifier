using System.Collections.Generic;
using System.Linq;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NeuralNet
    {
        // Initially, the NN has 784 neurons as input, two hidden layers of 8 neurons and an output layer of 10 neurons
        private const int InputSize = 784;
        private const int NumOfLayers = 2; //Two hidden layers
        private const int NeuronsPerLayer = 8;
        private const int NeuronsOutLayer = 10;
        
        private NDArray _layers;
        private List<NDArray> _weights;
        private List<NDArray> _biases;

        public NeuralNet()
        {
            _weights = new List<NDArray>();
            _biases = new List<NDArray>();
            //Each neuron in the input has a weight pointing to the NEURONS_PER_LAYER neurons of the next layer
            //Same for the other layers
            _weights.Add(np.random.rand((NeuronsPerLayer, InputSize))); //First layer weights
            _weights.Add(np.random.rand((NeuronsPerLayer, NeuronsPerLayer))); //Second layer weights
            _weights.Add(np.random.rand((NeuronsOutLayer, NeuronsPerLayer))); //Final layer weights
            
            //And the matrix multiplication of the input (NUM_INPUT_TO_PROCESS x INPUT_SIZE) * (INPUT_SIZE * NEURONS_PER_LAYER)
            // = (NUM_INPUT_TO_PROCESS x NEURONS_PER_LAYER)
            //Each one of those results needs to be summed with a bias integer

            //This [-10, 10] range for the biases is completely arbitrary
            _biases.Add(np.random.randint(-10, 10, (NeuronsPerLayer, 1)));
            _biases.Add(np.random.randint(-10, 10, (NeuronsPerLayer, 1)));
            _biases.Add(np.random.randint(-10, 10, (NeuronsOutLayer, 1)));
            
            //Finally an array to store layers values
            _layers = np.zeros((NeuronsPerLayer, NumOfLayers));
        }

        private NDArray ActivationFunction(NDArray matrix)
        {
            //The Sigmoid Function
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }

        private NDArray FeedForward(NDArray input)
        {
            //This method returns the output vector 
            //"input" must be a InputSize x 1 matrix
            NDArray info = input;
            for (int i = 0; i < NumOfLayers; i++)
            {
                _layers[i] = ActivationFunction(info.dot(_weights[i]) + _biases[i]); //Layer = WEIGHTS * INPUT + BIASES
                info = _layers[i];
            }
            
            return ActivationFunction(info.dot(_weights.Last()) + _biases.Last()); //Output vector
        }
    }
}