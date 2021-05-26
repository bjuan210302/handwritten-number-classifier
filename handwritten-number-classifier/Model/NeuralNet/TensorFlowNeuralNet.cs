using NumSharp;
using Tensorflow;
using Tensorflow.Keras.Layers;
using static Tensorflow.KerasApi;

namespace handwritten_number_classifier.Model.NeuralNet
{
    public class TensorFlowNeuralNet
    {
        private readonly LayersApi _layers;
        private Tensorflow.Keras.Engine.Model _model;
        private NDArray _xTrain, _yTrain, _xTest, _yTest;
        
        public TensorFlowNeuralNet()
        {
            _layers = new LayersApi();
        }

        public Tensor MakePrediction(int idx)
        {
            return _model.predict(_xTest[idx].reshape(1, 784));
        }
        public Tensor MakePrediction(NDArray img)
        {
            return _model.predict(img.reshape(1, 784));
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
            (_xTrain, _yTrain, _xTest, _yTest) = keras.datasets.mnist.load_data();
            _xTrain = _xTrain.reshape(60000, 784) / 255f;
            _xTest = _xTest.reshape(10000, 784) / 255f;
        }
        
        private void BuildModel()
        {
            // input layer
            var inputs = keras.Input(shape: 784);

            // 1st dense layer
            var outputs = _layers.Dense(64, activation: keras.activations.Tanh).Apply(inputs);

            // 2nd dense layer
            outputs = _layers.Dense(64, activation: keras.activations.Sigmoid).Apply(outputs);

            // output layer
            outputs = _layers.Dense(10, keras.activations.Sigmoid).Apply(outputs);

            // build keras model
            _model = keras.Model(inputs, outputs, name: "mnist_model");
        }

        private void CompileModel()
        {
            // compile keras model into tensorflow's static graph
            _model.compile(loss: keras.losses.SparseCategoricalCrossentropy(from_logits: true),
                optimizer: keras.optimizers.RMSprop(),
                metrics: new[] { "accuracy" });
        }

        private void Train()
        {
            _model.fit(_xTrain, _yTrain, batch_size: 64, epochs: 1, validation_split: 0.2f, verbose: 1);
        }
    }
}