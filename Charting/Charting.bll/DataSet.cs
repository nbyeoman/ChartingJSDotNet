using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartingObjects
{
    public class DataSet
    {

        public string label { get; set; }
        public List<DataPoint> dataPoints { get; set; }

        #region Constructor 

        public DataSet() {
            this.dataPoints = new List<DataPoint>();
        }

        #endregion

    } // Class... 
} // Namespace... 
