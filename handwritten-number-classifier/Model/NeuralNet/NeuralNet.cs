using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            _weights.Add(np.load("../../assets/nnModel/W1.npy") ); //W1
            _biases.Add(np.load("../../assets/nnModel/b1.npy") ); //b1
            _weights.Add(np.load("../../assets/nnModel/W2.npy") ); //W2
            _biases.Add(np.load("../../assets/nnModel/b2.npy") ); //b2
        }

        public NDArray MakePrediction(NDArray X)
        {
            return FeedForward(X)[3];
        }
        private List<NDArray> FeedForward(NDArray X)
        {
            var z1 = np.dot(_weights[0], X) + _biases[0]; //Input * W1 + b1
            //Console.WriteLine("W1 Shape: " + _weights[0].Shape.ToString());
            //Console.WriteLine("b1 Shape: " + _biases[0].Shape.ToString());
            //Console.WriteLine("Z1 Shape: " + z1.Shape.ToString());
            
            //Console.WriteLine("W1: {0}", _weights[0].ToString());
            //Console.WriteLine("b1: {0}", _biases[0].ToString());
            //Console.WriteLine("Z1: {0}", z1.ToString());

            var a = np.tanh(z1);
            //Console.WriteLine("A shape: " + a.Shape.ToString());
            var z2 =  np.dot(_weights[1],a) + _biases[1]; //Input * W2 + b2
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
            //Console.WriteLine("[IN BACKPROP] yPredict: " + yPredict.ToString());
            //Console.WriteLine("[IN BACKPROP] Y Shape: " + expectedY.Shape.ToString());
            //Console.WriteLine("[IN BACKPROP] Y: " + expectedY.ToString());
            //Console.WriteLine("[IN BACKPROP] a: " + a.ToString());

            var costSum = np.power((yPredict - expectedY), 2);
            costSum = (1 / no_examples) * SumHorizontal(costSum);
            costSum = costSum.ToArray<double>().Sum();
            
            
            //Calculating gradients

            var dLdZ2 = yPredict - expectedY;
            //Console.WriteLine("dLdZ2: " + dLdZ2.ToString());
            //Console.WriteLine("[IN BACKPROP] dLdZ2 shape: " + dLdZ2.Shape.ToString());
            var dLdW2 = (1/no_examples) * np.dot(dLdZ2, a.T);
            var dLdb2 = (1 / no_examples) * SumHorizontal(dLdZ2);
           
            
            var dLdZ1 = np.multiply(np.dot(_weights[1].T, dLdZ2), (1 - np.power(a, 2))); //8x1
            //Console.WriteLine("[IN BACKPROP] dLdZ1 shape: " + dLdZ1.Shape.ToString());
            var dLdW1 = (1/no_examples) * np.dot(dLdZ1, X.T);
            //Console.WriteLine("dLdZ1" + dLdZ1.ToString());
            var dLdb1 = (1 / no_examples) * SumHorizontal(dLdZ1);
            //Console.WriteLine("dLdb1" + dLdb1.ToString());
            
            
            //Adjusting weights and biases
            var leaningRate = 0.5f;
            _weights[1] -= dLdW2 * leaningRate;
            _biases[1] -= dLdb2 * leaningRate;
            _weights[0] -= dLdW1 * leaningRate; //Tiene que ser 8x784
            _biases[0] -= dLdb1 * leaningRate;
            
            return costSum;
        }
        
        private NDArray SumHorizontal(NDArray matrix)
        {
            //Doing this because the np.sum method is acting weird.
            var aux = np.zeros(matrix.shape[0], 1);
            
            for (int i = 0; i < matrix.shape[0]; i++)
            {
                aux[i] = matrix[i].ToArray<double>().Sum();
            }

            return aux;
        }
        public double Train(NDArray data, NDArray labels)
        {
            labels = labels.reshape(labels.size);

            NDArray expectedY = np.zeros((10, labels.shape[0]), NPTypeCode.Double);
            
            for (int i = 0; i < labels.shape[0]; i++)
            {
                double a = labels[i];
                expectedY[(int)a,i] = 1;
            }

            var resultForward = FeedForward(data);

            var loss = BackPropagation(data, resultForward, expectedY, data.shape[1]);

            return loss;
        }

        public void PrintWB()
        {
            Console.WriteLine("-----------------NEURAL NET DATA---------------");
            Console.WriteLine("W1 \n {0}", _weights[0]);
            Console.WriteLine("W2 \n {0}", _weights[1]);
            Console.WriteLine("b1 \n {0}", _biases[0]);
            Console.WriteLine("b2 \n {0}", _biases[1]);
        }
        
    }
}