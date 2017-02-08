using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDataDisplay.Model
{
    public class LogDataModel: DeviceDataModel
    {
        // data
        public string Event { get; set; }
        public Int32 Duration { get; set; }
        public Int32 Distance { get; set; }
    }
}
