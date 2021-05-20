using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public static class ActivationFunction
    {
        public static NDArray ComputeSigmoid(NDArray matrix)
        {
            matrix = 1 / (1 + np.exp(-1*matrix));
            return matrix;
        }
    }
}