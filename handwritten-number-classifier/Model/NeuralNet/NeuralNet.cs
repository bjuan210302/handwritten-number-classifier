using System;
using System.Collections.Generic;
using System.Linq;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NeuralNet
    {
        // Initially, the NN has 784 neurons as input, two hidden layers of 8 neurons and an output layer of 10 neurons
        private const int NeuronsPerLayer = 8;
        private const int NeuronsOutLayer = 10;
        private const int NumFeaturesPerExample = 784;
        
        private List<NDArray> _weights;
        private List<NDArray> _biases;

        public NeuralNet()
        {
            _weights = new List<NDArray>();
            _biases = new List<NDArray>();
            
            //Each neuron in the input has a weight pointing to the NEURONS_PER_LAYER neurons of the next layer
            //Same for the other layers
            _weights.Add(np.random.rand((NeuronsPerLayer, NumFeaturesPerExample))); //W1
            _biases.Add(np.zeros((NeuronsPerLayer, 1))); //b1
            _weights.Add(np.random.rand((NeuronsOutLayer, NeuronsPerLayer))); //W2
            _biases.Add(np.zeros((NeuronsOutLayer, 1))); //b2
        }

        private List<NDArray> FeedForward(NDArray X)
        {
            var z1 = np.dot(X, _weights[0].transpose()) + _biases[0].transpose(); //Input * W1 + b1
            //Console.WriteLine("W1 Shape: " + _weights[0].Shape.ToString());
            //Console.WriteLine("b1 Shape: " + _biases[0].Shape.ToString());
            //Console.WriteLine("Z1 Shape: " + z1.Shape.ToString());
            var a = ActivationFunction.ComputeRelu(z1);
            //Console.WriteLine("A shape: " + a.Shape.ToString());
            var z2 =  np.dot(a, _weights[1].transpose()) + _biases[1].transpose(); //Input * W2 + b2
            //Console.WriteLine("W2 Shape: " + _weights[1].Shape.ToString());
            //Console.WriteLine("b2 Shape: " + _biases[1].Shape.ToString());
            //Console.WriteLine("Z2 Shape: " + z2.Shape.ToString());
            var yPredict = ActivationFunction.ComputeSigmoid(z2);
            //Console.WriteLine("yPredict Shape: " + yPredict.Shape.ToString());

            return new List<NDArray> {z1, a, z2, yPredict};
        }

        private double BackPropagation(NDArray X, List<NDArray> forwardResults, NDArray expectedY, double no_examples)
        {
            var z1 = forwardResults[0];
            var a = forwardResults[1];
            var z2 = forwardResults[2];
            var yPredict = forwardResults[3];
            //Console.WriteLine("[IN BACKPROP] yPredict Shape: " + yPredict.Shape.ToString());
            Console.WriteLine("[IN BACKPROP] yPredict: " + yPredict.ToString());
            //Console.WriteLine("[IN BACKPROP] Y Shape: " + expectedY.Shape.ToString());
            Console.WriteLine("[IN BACKPROP] Y: " + expectedY.ToString());
            //Console.WriteLine("[IN BACKPROP] a: " + a.ToString());

            var loss = np.power((yPredict - expectedY), 2).reshape(NeuronsOutLayer).ToArray<Double>();
            var lossTotal = loss.Sum();
            
            //Calculating gradients
            var dLdZ2 = yPredict - expectedY; //1x10
            //Console.WriteLine(dLdZ2.ToString());
            //Console.WriteLine("[IN BACKPROP] dLdZ2 shape: " + dLdZ2.Shape.ToString());
            var dLdW2 = (1/no_examples) * np.dot(dLdZ2.transpose(), a);
            var dLdb2 = (1/no_examples) * np.sum(dLdZ2.transpose(), 1, true);
            var dLdZ1 = np.multiply(np.dot(_weights[1].T, dLdZ2.T), (1 - np.power(a, 2)).transpose()); //8x1
            //Console.WriteLine("[IN BACKPROP] dLdZ1 shape: " + dLdZ1.Shape.ToString());
            var dLdW1 = (1/no_examples) * np.dot(dLdZ1, X);
            var dLdb1 = (1/no_examples) * np.sum(dLdZ1, 1, true);
            
            //Adjusting weights and biases
            _weights[1] += dLdW2;
            _biases[1] += dLdb2;
            _weights[0] += dLdW1; //Tiene que ser 8x784
            _biases[0] += dLdb1;
            
            return lossTotal;
        }

        public double Train(NDArray data, NDArray labels)
        {
            var totalLoss = 0.0;
            
            for (int i = 0; i < data.shape[0]; i++)
            {
                Console.WriteLine("------------------------ " + i + " --------------");
                var x = data[i,":"].reshape(1, NumFeaturesPerExample);
                NDArray expectedY = np.zeros((10, 1), NPTypeCode.Int32);
                expectedY[labels[i]] = 1;
                
                var resultForward = FeedForward(x);
                
                var loss = BackPropagation(x, resultForward, expectedY.transpose(), (double)data.shape[0]);
                Console.WriteLine(loss);
                totalLoss += loss;
            }

            return totalLoss / (double)data.shape[0];
        }
    }
}