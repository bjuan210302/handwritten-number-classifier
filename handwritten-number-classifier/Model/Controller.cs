using System.Drawing;
using NumSharp;

namespace handwritten_number_classifier.Model
{
    public class Controller
    {
        private CsvHolder _holder;
        private NeuralNet.NeuralNet nn;

        public Controller()
        {
            nn = new NeuralNet.NeuralNet();
            _holder = new CsvHolder();
            _holder.LoadTestSet(); 
        }

        public NDArray MakePredictions(int idx)
        {
            return nn.MakePrediction(_holder.TestSet[idx, "1:"].reshape(1,784).transpose());
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
    }
}