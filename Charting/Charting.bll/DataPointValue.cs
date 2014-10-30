using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public abstract class DataPointValue
    {

        /// <summary>
        /// Determines the number of decimal places for rounding purposes. 
        /// </summary>
        public byte decimalPrecision { get; set; }

        /// <summary>
        /// Generic label that will be later cast to an appropriate data type based on the valueDataType property. 
        /// </summary>
        protected object _dataPointValue { get; set; }

        /// <summary>
        /// Abstract Class constructor... 
        /// </summary>
        /// <param name="ValueDataType">Sets the value data type for retrieval from subclasses.</param>
        /// <param name="dataPointValue">Generic value which will later be cast based on _valueDataType when a concrete class is instantiated.</param>
        protected DataPointValue(object dataPointValue, byte DecimalPrecision)
        {
            this._dataPointValue = dataPointValue;
            this.decimalPrecision = DecimalPrecision; 
            this.ConvertPointValueToDataType();
        }

        /// <summary>
        /// Converts the generic value object to a strongly typed variable. 
        /// </summary>
        protected abstract void ConvertPointValueToDataType();

        /// <summary>
        /// Returns the actual data point value.
        /// </summary>
        /// <returns></returns>
        public abstract float? Value();

    } // Class... 
} // Namespace... 
