using System;
using NumSharp;
using Tensorflow.Keras.Layers;
using static Tensorflow.KerasApi;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class TensorFlowNeuralNet
    {
        string pathToWeights = "../../assets/tf/model";
        LayersApi layers;
        Tensorflow.Keras.Engine.Model model;
        NDArray x_train, y_train, x_test, y_test;

        public TensorFlowNeuralNet()
        {
            layers = new LayersApi();
        }

        public void PrepareModel()
        {
            PrepareData();
            BuildModel();
            CompileModel();
            Train(); 
        }

        public void LoadModel()
        {
            PrepareData();
            BuildModel();
            model.load_weights(pathToWeights);
        }
        private void PrepareData()
        {
            (x_train, y_train, x_test, y_test) = keras.datasets.mnist.load_data();
            x_train = x_train.reshape(60000, 784) / 255f;
            x_test = x_test.reshape(10000, 784) / 255f;
        }
        
        private void BuildModel()
        {
            // input layer
            var inputs = keras.Input(shape: 784);

            // 1st dense layer
            var outputs = layers.Dense(64, activation: keras.activations.Tanh).Apply(inputs);

            // 2nd dense layer
            outputs = layers.Dense(64, activation: keras.activations.Sigmoid).Apply(outputs);

            // output layer
            outputs = layers.Dense(10).Apply(outputs);

            // build keras model
            model = keras.Model(inputs, outputs, name: "mnist_model");
            // show model summary
            model.summary();
        }

        private void CompileModel()
        {
            // compile keras model into tensorflow's static graph
            model.compile(loss: keras.losses.SparseCategoricalCrossentropy(from_logits: true),
                optimizer: keras.optimizers.RMSprop(),
                metrics: new[] { "accuracy" });
        }

        private void Train()
        {
            // train model by feeding data and labels.
            model.fit(x_train, y_train, batch_size: 64, epochs: 1, validation_split: 0.2f, verbose: 1);
            ;
            // evluate the model
            //model.evaluate(x_test, y_test, verbose: 2);

            // save and serialize model
            //model.save_weights(pathToWeights, save_format:"h5");
            //model.save(pathToWeights);

            // recreate the exact same model purely from the file:
        }
    }
}