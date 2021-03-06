﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public abstract class DataPointLabel
    {

        protected DataPointLabelType _labelDataType { get; set; }

        /// <summary>
        /// Specifies the format that the return string should be formatted as. No special formatting applied in a text implementaiton... 
        /// </summary>
        public LabelReturnStyle labelReturnStyle { get; set; }

        /// <summary>
        /// Provides the data type (enum) of the label. 
        /// </summary>
        public DataPointLabelType labelDataType { get { return this._labelDataType; } }
        
        /// <summary>
        /// Generic label that will be later cast to an appropriate data type based on the labelDataType property. 
        /// </summary>
        protected object _dataLabelValue { get; set; }

        /// <summary>
        /// Abstract Class constructor... 
        /// </summary>
        /// <param name="LabelDataType">Sets the label data type for retrieval from subclasses.</param>
        /// <param name="DataLabelValue">Generic value which will later be cast based on labelDataType when a concrete class is instantiated.</param>
        protected DataPointLabel(DataPointLabelType LabelDataType, object DataLabelValue, LabelReturnStyle labelReturnStyle)
        {
            this._labelDataType = LabelDataType;
            this._dataLabelValue = DataLabelValue;
            this.ConvertLabelValueToDataType();
            this.labelReturnStyle = labelReturnStyle;
        }

        /// <summary>
        /// Converts the generic label object to a strongly typed variable. 
        /// </summary>
        protected abstract void ConvertLabelValueToDataType();

        public abstract string GetLabel();


    } // class... 
} // namespace... 
