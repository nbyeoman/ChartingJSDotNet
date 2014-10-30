using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public class ChartData
    {

        public List<DataSet> datasets { get; set; }
        public DataPointLabelType dataPointLabelType { get; set; }

        public ChartData(DataPointLabelType dataPointLabelType)
        {
            this.dataPointLabelType = dataPointLabelType;
            this.datasets = new List<DataSet>();
        }


    } // Class... 
} // Namespace... 
