using System;
using System.IO;
using NumSharp;
namespace handwritten_number_classifier.Interface
{
    public class Controller 
    {

        private int[,] tabletop(int [,] matrix)
        {
            var nd = new NDArray(matrix);
            var ns = nd[":,0:1"];
        
            var index = NumSharp.np.arange(1,ns.size+1).reshape(ns.size,1);
            var a = np.array(ns);
         
            var rs =np.concatenate((a.transpose(), index.transpose()));

            return (int[,]) rs;
        }
     
    }
}