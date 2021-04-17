using System;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class ChartsWindow : Form
    {
        private Controller c;
        public ChartsWindow(Controller c)
        {
            MaximizeBox = false;
            InitializeComponent();
            this.c = c;
            
            FillCharts();
        }

        private void FillCharts()
        {
            FillBarChart();
            FillPieChart();
        }

        //Quantity chart
        private void FillBarChart()
        {
            //Preparing style
            barChart.Legends.Clear();
            
            //Fill
            for (int i = 0; i < 10; i++)
            {
                barChart.Series[0].Points.AddXY(i, c.GetAllIndexesWithLabel(i).shape[0]);
            }
        }

        //ProportionChart
        private void FillPieChart()
        {
            //Preparing style
            pieChart.Series[0].XValueMember = "Name";
            pieChart.Series[0].YValueMembers = "Count";
            pieChart.Series[0].IsValueShownAsLabel = true;
            
            //Fill
            for (int i = 0; i < 10; i++)
            {
                double proportion = ((double)c.GetAllIndexesWithLabel(i).shape[0] / 10000.0f)*100; //10000 is the total number of examples, hardcoded bad i know
                pieChart.Series[0].Points.AddXY(i, proportion);
            }
        }
    }
}