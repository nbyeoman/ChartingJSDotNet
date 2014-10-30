using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charting.bll
{
    public abstract class DataPointValue
    {

        /// <summary>
        /// Provides the data type (enum) of the value. 
        /// </summary>
        protected DataPointValueType _valueDataType { get; set; }

        /// <summary>
        /// Generic label that will be later cast to an appropriate data type based on the valueDataType property. 
        /// </summary>
        protected object _dataPointValue { get; set; }

        /// <summary>
        /// Abstract Class constructor... 
        /// </summary>
        /// <param name="ValueDataType">Sets the value data type for retrieval from subclasses.</param>
        /// <param name="dataPointValue">Generic value which will later be cast based on _valueDataType when a concrete class is instantiated.</param>
        protected DataPointValue(DataPointValueType ValueDataType, object dataPointValue)
        {
            this._valueDataType = ValueDataType;
            this._dataPointValue = dataPointValue;
            this.ConvertPointValueToDataType();
        }

        /// <summary>
        /// Converts the generic value object to a strongly typed variable. 
        /// </summary>
        protected abstract void ConvertPointValueToDataType();

    } // Class... 
} // Namespace... 
