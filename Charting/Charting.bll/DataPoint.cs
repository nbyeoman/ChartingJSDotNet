using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartingObjects
{
    public class DataPoint
    {

        public DataPointLabel dataPointLabel { get; set; }
        public DataPointValue dataPointValue { get; set; } 
        
        /// <summary>
        /// Constructor - Determines label and value types.
        /// </summary>
        /// <param name="labelDataType">Determines if the label is a date, numeric, or string value.</param>
        /// /// <param name="valueDataType">Determines if the value is an integer or float value.</param>
        public DataPoint(DataPointLabelType labelDataType, object dataPointLabel, object dataPointValue, LabelReturnStyle returnStyle, byte dataPointPrecision)
        { 
            
           switch(labelDataType)
           {

               case DataPointLabelType.Date:
                   this.dataPointLabel = new DateDataPointLabel(labelDataType, dataPointLabel, returnStyle);
                   break;

               case DataPointLabelType.Text:
                   this.dataPointLabel = new TextDataPointLabel(labelDataType, dataPointLabel, returnStyle);
                   break;

               default:  //Default to Text
                   this.dataPointLabel = new TextDataPointLabel(labelDataType, dataPointLabel, returnStyle);
                   break;

           } // switch... 

            
            this.dataPointValue = new FloatDataPointValue(dataPointValue, dataPointPrecision);
                   
        } // constructor... 



    } // Class 
} // Namespace
