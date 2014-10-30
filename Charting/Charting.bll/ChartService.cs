using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public static class ChartService
    {

        public static void AddCompletedDataSetToChart(ChartData chartData, DataSet dataSet)
        {
            chartData.datasets.Add(dataSet);
        }

        public static bool AddDataPointToDataSet(ref DataSet dataSet, DataPoint dataPoint)
        {

            // Loop through existing datapoints (If they exist)... 
            foreach(DataPoint dp in dataSet.dataPoints)
            {

                // Verify matching data types in labels.. 
                if(dataPoint.dataPointLabel.labelDataType != dp.dataPointLabel.labelDataType)
                {
                    return false;
                }

                // Verify data point at "X" (label) axis hasn't been added already... 
                if(dataPoint.dataPointLabel.GetLabel() == dp.dataPointLabel.GetLabel())
                {
                    // Already exists... 
                    return false;
                }

            } // foreach..

            // If it makes it to this point, all is good, add it... 
            dataSet.dataPoints.Add(dataPoint); 
            return true;

        } // AddDataPointToDataSet... 

        public static void NormalizeDataSeriesDataPoints(ref DataSet dataset1, ref DataSet dataset2)
        {

            // Make sure there is some amount of data between the 2 sets... 
            if(dataset1.dataPoints.Count == 0 && dataset2.dataPoints.Count == 0){
                return;
            }

            DataPointLabelType lblType = DataPointLabelType.Text;
            LabelReturnStyle lblRs = LabelReturnStyle.Text;
            byte valPrec = 2;

            // Determine which set is larger, and use the data type from that.. 
            if(dataset1.dataPoints.Count > dataset2.dataPoints.Count())
            {
                lblType = dataset1.dataPoints[0].dataPointLabel.labelDataType;
                lblRs = dataset1.dataPoints[0].dataPointLabel.labelReturnStyle;
                valPrec = dataset1.dataPoints[0].dataPointValue.decimalPrecision;
            }else
            {
                lblType = dataset2.dataPoints[0].dataPointLabel.labelDataType;
                lblRs = dataset2.dataPoints[0].dataPointLabel.labelReturnStyle;
                valPrec = dataset2.dataPoints[0].dataPointValue.decimalPrecision;
            }

            // Get all the labels from the first list... 
            List<string> labels1 = dataset1.dataPoints.Select(x => x.dataPointLabel.GetLabel()).ToList<string>();

            // Get all the labels from the second list... 
            List<string> labels2 = dataset2.dataPoints.Select(x => x.dataPointLabel.GetLabel()).ToList<string>();

            // Compare the lists... 
            List<string> missingFrom1 = labels2.Except(labels1).ToList<string>();
            List<string> missingFrom2 = labels1.Except(labels2).ToList<string>();
            
            // Fill the first data set with null values where missing... 
            foreach(string mv in missingFrom1)
            {
                
                dataset1.dataPoints.Add(new DataPoint(lblType, (object)mv, (object)null, lblRs, valPrec));
            }

            // Fill the second data set with null values where missing... 
            foreach (string mv in missingFrom2)
            {
                dataset2.dataPoints.Add(new DataPoint(lblType, (object)mv, (object)null, lblRs, valPrec));
            }

        } // NormalizeDataSeries

    } // Class... 
} // Namespace... 
