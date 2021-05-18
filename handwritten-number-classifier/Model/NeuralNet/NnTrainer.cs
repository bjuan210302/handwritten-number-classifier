using System;
using System.Collections.Generic;
using NumSharp;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class NnTrainer
    {
        public static void Train()
        {
            var holder = new CsvHolder();
            holder.LoadTrainingSet();
            var nn = new NeuralNet();

            

            var batches = 1875;
            var batchesSize = 32;
            var epochs = 100;
            
            for (int i = 0; i < epochs; i++)
            {
                var loss = 0.0;
                Console.WriteLine("EPOCH {0} OF {1}", i, epochs);
                for (int j = 0; j < batches; j++)
                {
                    
                    string xFilter = j * batchesSize + ":" + (j + 1) * batchesSize;
                    string filter = xFilter + ",1:";
                    string filter2 = xFilter + ",0";

                    if (j % 25 == 0)
                    {
                        Console.WriteLine("[EPOCH {0} - BATCH {1} OF {2}] :: Using filters \"{3}\" and \"{4}\"", i, j, batches, filter, filter2);
                    }
                    
                    var dataX = (holder.TrainingSet[filter].T) / 255;
                    var dataY = holder.TrainingSet[filter2].T;

                    loss += nn.Train(dataX, dataY);
                }

                Console.WriteLine("EPOCH {0} DONE. AVERAGE LOSS = {1}", i, loss/60000.0);
                Shuffle(holder.TrainingSet);
            }


            var pred = nn.MakePrediction(holder.TrainingSet["5000,1:"].reshape(1, 784).T);
            Console.WriteLine(pred.ToString());
            Console.WriteLine(holder.TrainingSet["5000,0"].ToString());

            nn.PrintWB();
        }

        private static void Shuffle(NDArray matrix) //Making this method because the np.random.shuffle method doesn't work either
        {
            var rand = new Random(1).Next(0, matrix.shape[0]);
            var rand2 = new Random(2).Next(0, matrix.shape[0]);
            var aux = matrix[rand].copy();
            matrix[rand] = matrix[rand2];
            matrix[rand2] = aux;
        }
    }
}