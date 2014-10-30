using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public class DateDataPointLabel : DataPointLabel
    {

        /// <summary>
        /// Strongly typed "Date" data for the chart label. 
        /// </summary>
        private DateTime? _dateLabel { get; set; }

        public DateDataPointLabel(DataPointLabelType LabelDataType, object DataLabelValue, LabelReturnStyle returnStyle): base(LabelDataType, DataLabelValue, returnStyle)
        {
        }
        
        /// <summary>
        /// Converts the generic object value into a concrete type.
        /// </summary>
        protected override void ConvertLabelValueToDataType()
        {

            try{

                this._dateLabel = (DateTime?)base._dataLabelValue;
            
            }
            catch(Exception)
            {
                this._dateLabel = null;
            }

        } // ConvertLabelValueToDataType


        public override string GetLabel()
        {
            
            if(this._dateLabel == null)
            {
                return string.Empty;
            }

            // _dateLabel has a valid datetime... 
            DateTime dateLabel = (DateTime)this._dateLabel;

            switch (base.labelReturnStyle)
            {

                case LabelReturnStyle.DateAndTime:
                    return dateLabel.ToString("M/d/y H:mm");

                case LabelReturnStyle.DateOnly:
                    return dateLabel.ToString("M/d/y");

                case LabelReturnStyle.Time12HourOnly:
                    return dateLabel.ToString("H:mm");

                case LabelReturnStyle.Time24HourOnly:
                    return dateLabel.ToString("h:mm tt");

                default: // Text...
                    return dateLabel.ToString("M/d/y");

            } // switch

        } // GetLabel

    } // Class... 
} // Namespace... 
