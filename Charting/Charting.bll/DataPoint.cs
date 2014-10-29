using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charting.bll
{
    public class DataPoint
    {

        public DataPointLabel dataPointLabel { get; set; }
        //public IDataPointValue dataPointValue { get; set; } // Swap over to abstract class to mirror the DataPointLable class... 

        
        /// <summary>
        /// Constructor - Determines label and value types.
        /// </summary>
        /// <param name="labelDataType">Determines if the label is a date, numeric, or string value.</param>
        /// /// <param name="valueDataType">Determines if the value is an integer or float value.</param>
        public DataPoint(DataPointType labelDataType, DataPointType valueDataType)
        { 
            
           switch(labelDataType)
           {

               case DataPointType.Float:
                   break;

               case DataPointType.Integer:
                   break;

               case DataPointType.Text:
                   break;

           } // switch... 

           switch (valueDataType)
           {

               case DataPointType.Float:
                   break;

               case DataPointType.Integer:
                   break;

               case DataPointType.Text:
                   break;

           } // switch... 


        } // constructor... 



    } // Class 
} // Namespace
