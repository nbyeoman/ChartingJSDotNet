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
        public DataPoint(DataPointLabelType labelDataType, DataPointValueType valueDataType, object dataPointLabel, object dataPointValue)
        { 
            
           switch(labelDataType)
           {

               case DataPointLabelType.Date:
                   this.dataPointLabel = new DateDataPointLabel(labelDataType, dataPointLabel);
                   break;

               case DataPointLabelType.Text:
                   this.dataPointLabel = new TextDataPointLabel(labelDataType, dataPointLabel);
                   break;

               default:  //Default to Text
                   this.dataPointLabel = new TextDataPointLabel(labelDataType, dataPointLabel);
                   break;

           } // switch... 

           switch (valueDataType)
           {

               case DataPointValueType.Float:
                   this.dataPointValue = new FloatDataPointValue(valueDataType, dataPointValue);
                   break;

               case DataPointValueType.Integer:
                   this.dataPointValue = new IntegerDataPointValue(valueDataType, dataPointValue);
                   break;

               default: // Default to Float for safety... 
                   this.dataPointValue = new FloatDataPointValue(valueDataType, dataPointValue);
                   break;

           } // switch... 

        } // constructor... 



    } // Class 
} // Namespace
