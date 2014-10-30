using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charting.bll
{
    public class TextDataPointLabel : DataPointLabel
    {

        /// <summary>
        /// Strongly typed "String" data for the chart label. 
        /// </summary>
        private string _textLabel { get; set; }

        public TextDataPointLabel(DataPointLabelType LabelDataType, object DataLabelValue): base(LabelDataType, DataLabelValue)
        {            
        }
        
        /// <summary>
        /// Converts the generic object value into a concrete type.
        /// </summary>
        protected override void ConvertLabelValueToDataType()
        {

            try{

                this._textLabel = base._dataLabelValue.ToString();
            
            }
            catch(Exception)
            {
                this._textLabel = string.Empty;
            }

        } // ConvertLabelValueToDataType


        public string GetLabel(DateReturnStyle returnStyle)
        {
            
            return this._textLabel;

        } // GetLabel

    } // class... 
} // namespace... 
