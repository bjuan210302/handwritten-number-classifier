using NumSharp;
using NumSharp.Generic;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public static class ActivationFunction
    {
        public static NDArray ComputeSigmoid(NDArray matrix)
        {
            //The Sigmoid Function
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }

        public static NDArray ComputeRelu(NDArray matrix)
        {
            return np.maximum(matrix, 0);
        }
        public static NDArray ComputeDerivative(NDArray matrix)
        {
            //Derivative of te sigmoid function
            return matrix * (1 + -1*matrix); //For some reason "-matrix" is not a valid expression
        }
    }
}