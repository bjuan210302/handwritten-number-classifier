# Handwritten Number Reader

_Explorate the MNIST Dataset, and train a neural network with it, in C#._

## Getting started 🚀

### Pre-requisites📋

Before executing the project download the [MINIST Dataset in CSV format](https://www.kaggle.com/oddrationale/mnist-in-csv). Both files, the training set and test set, should be in `the mnist_cvs` folder. The program looks for the datasets on paths:

```
project\handwritten-number-classifier\assets\mnist_csv\mnist_test.csv
project\handwritten-number-classifier\assets\mnist_csv\mnist_train.csv
```

### Libraries 🔧

This project uses [SciSharp/NumSharp 0.30.0](https://github.com/SciSharp/NumSharp). This should come installed as a NuGet package in the project.

## Documentation 📄

You can find some diagrams describing the structure of the project in the [Documentation](./Documentation/) folder. Additionally here is the [Engineering Method](https://drive.google.com/file/d/1LLQiy0oebz8SKDufRh-REl0oxAb6c0Rb/view?usp=sharing) from step one to three; and the [Functional and non-functional reqs](https://drive.google.com/file/d/17Ye1W7G4jEckY-LpDEtnvRtbsKSA-sio/view?usp=sharing).



## What to do ✅

Until now you can only explore the dataset, training a neural network is still in progress. Click the "Explore" button in the first screen will take you to the numbers window. Here you can scroll through the test dataset, and see the visual representation of the pixels in the dataset. Additionally, a filter and a histogram of each image is provided.

Clicking on the `View other charts` button will open a new window with general information about the distribution of the numbers in the set.

## Authors ✒️

* **Juan Bustamante** - [bjuan210302](https://github.com/bjuan210302)
* **Sebastián Jaramillo**- [sebasjarat03](https://github.com/sebasjarat03)
* **Duvan Cuero** - [merolemay](https://github.com/merolemay)

---
✌️
