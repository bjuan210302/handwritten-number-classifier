# Handwritten Number Reader

_Explorate the MNIST Dataset, and train a neural network with it, in C#._

## Getting started 🚀

### Pre-requisites📋

Before executing the project download the [MINIST Dataset in CSV format](https://drive.google.com/file/d/18xeBRcreQl0ruWZ2btFcOyUiCCJQRdtE/view?usp=sharing). Both files, the training set and test set, should be in `the mnist_cvs` folder. The program looks for the datasets on paths:

```
project\handwritten-number-classifier\assets\mnist_csv\mnist_test.csv
project\handwritten-number-classifier\assets\mnist_csv\mnist_train.csv
```
### Libraries 🔧

This project uses some open source machine learning C# libraries. This should come installed as a NuGet package in the project.

* [SciSharp/NumSharp 0.30.0](https://github.com/SciSharp/NumSharp).
* [TensorFlow.NET 0.40.1](https://github.com/SciSharp/TensorFlow.NET).
* [TensorFlow.Keras 0.5.1](https://github.com/SciSharp/Keras.NET).
* [SciSharp.TensorFlow.Redist](https://www.nuget.org/packages/SciSharp.TensorFlow.Redist).

## Documentation 📄

You can find some diagrams describing the structure of the project in the [Documentation](./Documentation/) folder. 
Additionally here is the [Engineering Method](/Documentation/Método%20de%20la%20ingeniería.pdf) from step one to three; and the [Functional and non-functional reqs](/Documentation/Requerimientos.pdf). Also here is the [Experimental Design](https://docs.google.com/spreadsheets/d/140YvZwjEVPOJ-aF8ruU-nUFoFgS2prBjWgsCoQBag3o/edit#gid=0)



## What to do [NEW] ✅

Click the "Explore" button in the first screen to see the numbers window. Here you can scroll through the test dataset, and see the visual representation of the pixels in the dataset. Additionally, a filter and a histogram of each image is provided.

Clicking on the `View other charts` button will open a new window with general information about the distribution of the numbers in the set.

Click on the "Neural Network" button to test and play with two implementations of a neural net to recognize the numbers in the dataset. Theres a couple of important things to consider:

* Loading the Neural Network window is slow. As TensorFlow.NET `model.save` method is still in development, wa cant load a trained model, so it quickly trains a new one when you need it.
* Our own implementation of the neural net is already trained, but is not as trained as we would like it to be. It still predicts numbers rigth most of the time :).
* You can draw in real time numbers and test the neural net with them (only works with our own implementation).

## Authors ✒️

* **Juan Bustamante** - [bjuan210302](https://github.com/bjuan210302)
* **Sebastián Jaramillo**- [sebasjarat03](https://github.com/sebasjarat03)
* **Duvan Cuero** - [merolemay](https://github.com/merolemay)

---
✌️
