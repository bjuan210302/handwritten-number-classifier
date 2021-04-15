using System.Drawing;
using NumSharp;

namespace handwritten_number_classifier.Model
{
    public class Controller
    {
        private CsvHolder _holder;

        public Controller()
        {
            _holder = new CsvHolder();
            _holder.LoadTestSet(); 
        }

        public Bitmap getImageWithIndex(int index)
        {
            //TODO

            return null;
        }

        public NDArray getAllImagesWithLabel(int label)
        {
            //TODO
            return null;
        }
    }
}