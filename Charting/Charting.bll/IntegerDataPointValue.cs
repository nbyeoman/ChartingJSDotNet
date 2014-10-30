using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public class IntegerDataPointValue : DataPointValue
    {

        /// <summary>
        /// Strongly typed "Integer" data for the point value.. 
        /// </summary>
        private int? _dataValue { get; set; }

        public IntegerDataPointValue(DataPointValueType VabelDataType, object dataPointValue) : base(VabelDataType, dataPointValue)
        {            
        }
        
        /// <summary>
        /// Converts the generic object value into a concrete type.
        /// </summary>
        protected override void ConvertPointValueToDataType()
        {

            try{

                this._dataValue = (int)base._dataPointValue;
            
            }
            catch(Exception)
            {
                this._dataValue = null;
            }

        } // ConvertValueToDataType


        public int? GetValue()
        {
            
            if(this._dataValue == null)
            {
                return null;
            }

            // _dataValue has a valid int... 
            return this._dataValue;

        } // GetValue 

    } // Class... 
} // Namespace... 
