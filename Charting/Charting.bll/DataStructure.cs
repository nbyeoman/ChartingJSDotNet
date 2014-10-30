using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartingObjects
{
    public class DataStructure
    {

        List<string> labels { get; set; }
        List<DataSet> datasets { get; set; }



        #region Constructor

        public DataStructure() {
            
            this.labels = new List<string>();
            this.datasets = new List<DataSet>();

        }

        #endregion

    } // Class... 
} // Namespace... 
