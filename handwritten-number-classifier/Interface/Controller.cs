using System;
using System.IO;
using NumSharp;
namespace handwritten_number_classifier.Interface
{
    public class Controller 
    {
        public static readonly string TRAINING_SET_PATH = "../../assets/mnist_csv/mnist_train.csv";
        public static readonly string TEST_SET_PATH = "../../assets/mnist_csv/mnist_test.csv";
        
        private NDArray testSet;
        
        
        private void LoadTestSet()
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

        private void tabletop(int [,] matrix)
        {
            var nd = new NDArray(matrix);
            var ns = nd[":,0:1"];
        
            var index = NumSharp.np.arange(1,ns.size+1).reshape(ns.size,1);
         
            var rs =np.concatenate((ns, index));
            
             Console.WriteLine(ns+"  ");
             Console.WriteLine(index+"  ");
            Console.WriteLine(rs.ToString());
        }
        
        public static void Main ()
        {
            Controller test = new Controller();
            int [,] matrix= new int[,]{{0,1,4,5},{2,3,6,7}};
            test.tabletop(matrix);
        }
    }
}