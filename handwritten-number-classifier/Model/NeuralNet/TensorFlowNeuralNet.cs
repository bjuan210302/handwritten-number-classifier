using System;
using System.Collections.Generic;
using System.Linq;
using NumSharp;
using Tensorflow;
using Tensorflow.Keras.Layers;
using static Tensorflow.KerasApi;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class TensorFlowNeuralNet
    {
        LayersApi layers;
        Tensorflow.Keras.Engine.Model model;
        NDArray x_train, y_train, x_test, y_test;

        public TensorFlowNeuralNet()
        {
            layers = new LayersApi();
        }

        public Tensor MakePrediction(int idx)
        {
            return model.predict(x_test[idx].reshape(1, 784));
        }
        public Tensor MakePrediction(NDArray img)
        {
            return model.predict(img.reshape(1, 784));
        }
        
        public void PrepareModel()
        {
            PrepareData();
            BuildModel();
            CompileModel();
            Train(); 
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
            model.fit(x_train, y_train, batch_size: 64, epochs: 1, validation_split: 0.2f, verbose: 1);
        }
    }
}