using System;
using System.Linq;
using NumSharp;
using NumSharp.Generic;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public static class ActivationFunction
    {
        public static NDArray ComputeSoftMax(NDArray matrix)
        {
            //The Sigmoid Function
            //var exps = np.exp(matrix - matrix.max());
            //return exps / exps.ToArray<double>().Sum();
            
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }

        public static NDArray ComputeSigmoid(NDArray matrix)
        {
            //return np.maximum(matrix, 0);
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }
        public static NDArray ComputeSigmoidDerivative(NDArray matrix)
        {
            //Derivative of te sigmoid function
            return matrix * (1 + -1*matrix); //For some reason "-matrix" is not a valid expression
        }
    }
}