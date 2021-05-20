using System;
using System.Drawing;
using System.IO;
using NumSharp;

namespace handwritten_number_classifier.Model
{
    public class CsvHolder
    {
        public const string TrainingSetPath = "../../assets/mnist_csv/mnist_train.csv";
        public const string TestSetPath = "../../assets/mnist_csv/mnist_test.csv";

        public NDArray TrainingSet
        {
            get;
            set;
        }
        public NDArray TestSet
        {
            get;
            set;
        }
        private NDArray _indexedTestSet;
        
        public void LoadTrainingSet()
        {
            this.TrainingSet = LoadSet(TrainingSetPath);
        }

        public void LoadTestSet()
        {
            this.TestSet = LoadSet(TestSetPath);
            this._indexedTestSet = IndexLabels(TestSet);
        }
        
        private NDArray LoadSet(string path)
        {
            StreamReader sr = new StreamReader(path);
            char[] delimiters = {'\r', '\n'};
            string[] allLines = sr.ReadToEnd().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var infoMatrix = np.zeros((allLines.Length, allLines[0].Split(',').Length));

            for (int i = 0; i < allLines.Length; i++)
            {
                infoMatrix[i] = Array.ConvertAll(allLines[i].Split(','), int.Parse);
            }

            return infoMatrix;
        }

        private NDArray IndexLabels(NDArray matrix)
        {
            //Returns as [label, index]
            var labels = matrix[":,0"].reshape((matrix.shape[0], 1));
        
            var indexed = np.arange(0,matrix.shape[0]).reshape((matrix.shape[0], 1));
            
            indexed = np.concatenate((labels, indexed), 1);
            
            return indexed;
        }

        public NDArray GetHistogramOf(int imgIndex)
        {
            //_testSet[imgIndex, "1:"] is the pixels of the image with index imgIndex
            var pixels = TestSet[imgIndex, "1:"];
            var histogramPoints = np.zeros((256, 2));

            for (int i = 0; i < histogramPoints.shape[0]; i++)
            {
                var mask = pixels[":"] == i;
                histogramPoints[i, 0] = i; // Byte value
                histogramPoints[i, 1] = pixels[mask].size; //Number of occurrences of the byte value i
            }
            
            //Returns [ByteValue, NumberOfOccurrences]
            return histogramPoints;
        }
        
        public Bitmap GetImage(int index, int imgSize)
        {
            return GenerateImage(TestSet[index, "1:"].reshape((28,28)).transpose(), imgSize);
        }
        private Bitmap GenerateImage(NDArray alphas, int imgSize)
        {

            Bitmap img = new Bitmap(28, 28);

            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb(int.Parse(alphas[i, j].ToString()), 0, 0, 0));
                }
            }

            return ScaleImage(img, imgSize, imgSize);
        }

        public NDArray GetAllIndexesWithLabel(int label)
        {
            var mask = _indexedTestSet[":, 0"] == label;
            return _indexedTestSet[mask][":, 1"];
        }
        private Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / bmp.Width;
            var ratioY = (double)maxHeight / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);
         
            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);
         
            var newImage = new Bitmap(newWidth, newHeight);
         
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);
         
            return newImage;
        }
        
    }
}