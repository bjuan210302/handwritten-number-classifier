using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier
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
            
              }
    }
}