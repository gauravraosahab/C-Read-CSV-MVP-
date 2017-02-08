using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvDataDisplay.Model
{
    public class DeviceDataModel
    {
        // data
        public string AssetName { get; set; }
        public long AssetId { get; set; }
        public DateTime DataDate { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Vbat { get; set; }
        public Int32 Snr { get; set; }
        public string ReportBody { get; set; }
    }
}
