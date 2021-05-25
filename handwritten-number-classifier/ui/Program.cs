using System;
using System.Windows.Forms;
using handwritten_number_classifier.Model.NeuralNet;

namespace handwritten_number_classifier.ui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //var t = new TensorFlowNeuralNet();
            //t.PrepareModel();
        }
    }
}