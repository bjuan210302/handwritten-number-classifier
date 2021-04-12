using System;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NumSharp;

namespace handwritten_number_classifier.Model
{
    public class CsvParser
    {
        public static readonly string TRAINING_SET_PATH = "../../assets/mnist_csv/mnist_train.csv";
        public static readonly string TEST_SET_PATH = "../../assets/mnist_csv/mnist_test.csv";

        private NDArray trainingSetPath;
        private NDArray testSet;
        
        public void LoadTrainingSet()
        {
            this.trainingSetPath = LoadSet(TRAINING_SET_PATH);
        }

        public void LoadTestSet()
        {
            this.testSet = LoadSet(TEST_SET_PATH);
        }
        
        private NDArray LoadSet(string path)
        {
            StreamReader sr = new StreamReader(path);
            char[] delims = new[] {'\r', '\n'};
            string[] allLines = sr.ReadToEnd().Split(delims, StringSplitOptions.RemoveEmptyEntries);

            var infoMatrix = np.zeros((allLines.Length, allLines[0].Split(',').Length));

            for (int i = 0; i < allLines.Length; i++)
            {
                infoMatrix[i] = Array.ConvertAll(allLines[i].Split(','), int.Parse);
            }

            return infoMatrix;
        }

        public static Bitmap GenerateImage(NDArray alphas)
        {

            Bitmap img = new Bitmap(28, 28);

            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb(int.Parse(alphas[i, j].ToString()), 0, 0, 0));
                }
            }


            return ScaleImage(img, 280, 280);
        }

        public static Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
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