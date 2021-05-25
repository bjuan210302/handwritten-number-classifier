using System.Collections.Generic;
using System.Linq;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NeuralNet
    {
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

        public List<NDArray> MakePrediction(NDArray X)
        {
            return FeedForward(X/255);
        }
        private List<NDArray> FeedForward(NDArray X,  bool forPrediction = false)
        {
            var z1 = np.dot(_weights[0], X) + _biases[0]; //Input * W1 + b1
            var a = np.tanh(z1);
            var z2 =  np.dot(_weights[1],a) + _biases[1]; //Input * W2 + b2
            var yPredict = ActivationFunction.ComputeSigmoid(z2);

            return forPrediction ? new List<NDArray> {a, yPredict} : new List<NDArray> {z1, a, z2, yPredict};
        }

        private double BackPropagation(NDArray X, List<NDArray> forwardResults, NDArray expectedY, double noExamples)
        {
            var a = forwardResults[1];
            var yPredict = forwardResults[3];
            
            //Calculating gradients
            var dLdZ2 = yPredict - expectedY;
            var dLdW2 = (1/noExamples) * np.dot(dLdZ2, a.T);
            var dLdb2 = (1 / noExamples) * SumHorizontal(dLdZ2);
            
            var dLdZ1 = np.multiply(np.dot(_weights[1].T, dLdZ2), (1 - np.power(a, 2)));
            var dLdW1 = (1/noExamples) * np.dot(dLdZ1, X.T);
            var dLdb1 = (1 / noExamples) * SumHorizontal(dLdZ1);
            
            //Adjusting weights and biases
            var leaningRate = 0.5f;
            _weights[1] -= dLdW2 * leaningRate;
            _biases[1] -= dLdb2 * leaningRate;
            _weights[0] -= dLdW1 * leaningRate;
            _biases[0] -= dLdb1 * leaningRate;
            
            var costSum = np.power((yPredict - expectedY), 2);
            costSum = (1 / noExamples) * SumHorizontal(costSum);
            costSum = costSum.ToArray<double>().Sum();
            
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
            np.save("../../../W1_NEW", _weights[0]);
            np.save("../../../W2_NEW", _weights[1]);
            np.save("../../../b1_NEW", _biases[0]);
            np.save("../../../b2_NEW", _biases[1]);
        }
        
    }
}