using System.Collections.Generic;
using System.Drawing;
using handwritten_number_classifier.Model.NeuralNet;
using NumSharp;
using Tensorflow;

namespace handwritten_number_classifier.Model
{
    public class Controller
    {
        private CsvHolder _holder;
        private NeuralNet.NeuralNet _nn;
        private TensorFlowNeuralNet _tfn;

        public Controller()
        {
            _nn = new NeuralNet.NeuralNet();
            _holder = new CsvHolder();
            _holder.LoadTestSet();
        }

        public List<NDArray> MakePrediction(int idx)
        {
            return _nn.MakePrediction(_holder.TestSet[idx, "1:"].reshape(1,784).transpose());
        }
        public NDArray MakePredictionTf(int idx)
        {
            return _tfn.MakePrediction(idx).numpy();
        }
        
        public Bitmap GetImageWithIndex(int index, int imageSize)
        {
            return _holder.GetImage(index, imageSize);
        }

        public NDArray GetAllIndexesWithLabel(int label)
        {
            return _holder.GetAllIndexesWithLabel(label);
        }

        public NDArray GetHistogramOf(int imgIndex)
        {
            //Returns [ByteValue, NumberOfOccurrences], shape = (256, 2)
            return _holder.GetHistogramOf(imgIndex);
        }

        public void LoadTensorflow()
        {
            _tfn = new TensorFlowNeuralNet();
            _tfn.PrepareModel();
        }
    }
}