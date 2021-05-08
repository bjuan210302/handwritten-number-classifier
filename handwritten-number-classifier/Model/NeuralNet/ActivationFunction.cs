using NumSharp;
using NumSharp.Generic;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public static class ActivationFunction
    {
        public static NDArray Compute(NDArray matrix)
        {
            //The Sigmoid Function
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }

        public static NDArray ComputeDerivative(NDArray matrix)
        {
            //TODO
            return null;
        }
    }
}