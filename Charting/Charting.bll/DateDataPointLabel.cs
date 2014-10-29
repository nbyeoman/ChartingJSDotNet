using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charting.bll
{
    public class DateDataPointLabel : DataPointLabel
    {

        /// <summary>
        /// Strongly typed "Date" data for the chart label. 
        /// </summary>
        private DateTime? _dateLabel { get; set; }

        public DateDataPointLabel(DataPointType LabelDataType, object DataLabelValue): base(LabelDataType, DataLabelValue)
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


        public string GetLabel(DateReturnStyle returnStyle)
        {
            
            if(this._dateLabel == null)
            {
                return string.Empty;
            }

            // _dateLabel has a valid datetime... 
            DateTime dateLabel = (DateTime)this._dateLabel;

            switch(returnStyle)
            {
                
                case DateReturnStyle.DateAndTime:
                    return dateLabel.ToString("M/d/y H:mm");
                    
                case DateReturnStyle.DateOnly:
                    return dateLabel.ToString("M/d/y");

                case DateReturnStyle.Time12HourOnly:
                    return dateLabel.ToString("H:mm");

                case DateReturnStyle.Time24HourOnly:
                    return dateLabel.ToString("h:mm tt");

                default:
                    return dateLabel.ToString("M/d/y");

            } // switch

        } // GetLabel

    } // Class... 
} // Namespace... 
