using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NumSharp;

namespace handwritten_number_classifier.Model
{
    public class CsvHolder
    {
        public const string TrainingSetPath = "../../assets/mnist_csv/mnist_train.csv";
        public const string TestSetPath = "../../assets/mnist_csv/mnist_test.csv";

        private NDArray _trainingSet;
        private NDArray _indexedTrainingSet;
        private NDArray _testSet;
        private NDArray _indexedTestSet;
        
        public void LoadTrainingSet()
        {
            this._trainingSet = LoadSet(TrainingSetPath);
            this._indexedTrainingSet = IndexLabels(_trainingSet);
        }

        public void LoadTestSet()
        {
            this._testSet = LoadSet(TestSetPath);
            this._indexedTestSet = IndexLabels(_testSet);
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
            var labels = matrix[":,0:1"];
        
            var index = np.arange(1,labels.size+1).reshape(labels.size,1);
         
            var indexedLabels =np.concatenate((labels.transpose(), index.transpose()));

            return indexedLabels;
        }

        public Bitmap GetImage(int index, int imgSize)
        {
            //Needs testing
            return GenerateImage(_testSet[index, "1:"], imgSize);
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
            //TODO:
            return null;
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