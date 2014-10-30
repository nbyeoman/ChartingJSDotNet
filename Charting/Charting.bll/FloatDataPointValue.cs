using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public class FloatDataPointValue : DataPointValue 
    {

        /// <summary>
        /// Strongly typed "Float" data for the point value.. 
        /// </summary>
        private float? _dataValue { get; set; }

        public FloatDataPointValue(object dataPointValue, byte decimalPrecision): base(dataPointValue, decimalPrecision)
        {            
        }
        
        /// <summary>
        /// Converts the generic object value into a concrete type.
        /// </summary>
        protected override void ConvertPointValueToDataType()
        {

            try{

                this._dataValue = (float)base._dataPointValue;
            
            }
            catch(Exception)
            {
                this._dataValue = null;
            }

        } // ConvertValueToDataType


        public override float? Value()
        {
            
            if(this._dataValue == null)
            {
                return null;
            }

            // _dataValue has a valid float... 
            try
            {
                this._dataValue = (float)Math.Round((Decimal)this._dataValue, base.decimalPrecision);
            }catch(Exception)
            {
                // Do not round number, and return it as-is... 
            }

            return this._dataValue;

        } // GetValue 

    } // Class 
} // Namespace
