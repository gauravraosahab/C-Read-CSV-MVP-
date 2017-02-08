using CsvDataDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CsvDataDisplay.services
{   /// <summary>
    /// Class for reading file and interpreting data in models
    /// </summary>
    public class ReadCsvFile
    {
        /// <summary>
        /// method intakes file name and check if has data in csv pattern
        /// for each valid record creates revent model record.
        /// </summary>
        /// <param name="file_name"></param>
        /// <returns>Tuple(list of Device Data Model and list of Log Data Model)</returns>
        public Tuple<List<DeviceDataModel>, List<LogDataModel>> ReadFile(string file_name)
        {
            List<DeviceDataModel> listDeviceData = new List<DeviceDataModel>();
            List<LogDataModel> listLogData = new List<LogDataModel>();

            // Check if file exists
            if (File.Exists(file_name))
            {
                using (var fs = File.OpenRead(file_name))
                using (var reader = new StreamReader(fs))
                {
                    // Csv file line pattern
                    var pattern = @"(?<AssetName>^[A-Za-z0-9-_ ]*),(?<AssetId>[A-Za-z0-9-_. ]*),(?<DataDate>[0-9-_:\/ ]*),(?<LATITUDE>[A-Za-z0-9-. ]*),(?<LONGITUDE>[A-Za-z0-9-. ]*),(?<EVENT>[A-Za-z0-9-. ]*),(?<VBAT>[A-Za-z0-9-. ]*),(?<SNR>[A-Za-z0-9-. ]*),(?<DURATION>[A-Za-z0-9-. ]*),(?<DISTANCE>[A-Za-z0-9-. ]*),(?<REPORTBODY>[A-Za-z0-9-. ]*)$";

                    // skip first line as its header
                    reader.ReadLine();
                    // loop to read through file till end of file
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        // skip code if line is empty or null
                        var result = Regex.Match(line, pattern);
                        if (result.Success)
                        {
                            if (result.Groups["EVENT"].Value.Trim().ToUpper().Equals(""))
                            {
                                var deviceDataRecord = new DeviceDataModel();
                                deviceDataRecord.AssetName = result.Groups["AssetName"].Value.Trim();
                                deviceDataRecord.AssetId = Convert.ToInt64(result.Groups["AssetId"].Value.Trim());
                                deviceDataRecord.DataDate = Convert.ToDateTime(result.Groups["DataDate"].Value.Trim());
                                deviceDataRecord.Latitude = float.Parse(result.Groups["LATITUDE"].Value.Trim());
                                deviceDataRecord.Longitude = float.Parse(result.Groups["LONGITUDE"].Value.Trim());
                                deviceDataRecord.Vbat = float.Parse(result.Groups["VBAT"].Value.Trim());
                                deviceDataRecord.Snr = Convert.ToInt32(result.Groups["SNR"].Value.Trim());
                                deviceDataRecord.ReportBody = result.Groups["REPORTBODY"].Value.Trim();
                                listDeviceData.Add(deviceDataRecord);
                            }
                            else if (result.Groups["EVENT"].Value.Trim().ToUpper().Equals("LOG"))
                            {
                                var logDataRecord = new LogDataModel();
                                logDataRecord.AssetName = result.Groups["AssetName"].Value.Trim();
                                logDataRecord.AssetId = Convert.ToInt64(result.Groups["AssetId"].Value.Trim());
                                logDataRecord.DataDate = Convert.ToDateTime(result.Groups["DataDate"].Value.Trim());
                                logDataRecord.Latitude = float.Parse(result.Groups["LATITUDE"].Value.Trim());
                                logDataRecord.Longitude = float.Parse(result.Groups["LONGITUDE"].Value.Trim());
                                logDataRecord.Event = result.Groups["EVENT"].Value.Trim();
                                logDataRecord.Vbat = float.Parse(result.Groups["VBAT"].Value.Trim());
                                logDataRecord.Snr = Convert.ToInt32(result.Groups["SNR"].Value.Trim());
                                logDataRecord.Duration = Convert.ToInt32(result.Groups["SNR"].Value.Trim());
                                logDataRecord.Distance = Convert.ToInt32(result.Groups["DURATION"].Value.Trim());
                                logDataRecord.ReportBody = result.Groups["REPORTBODY"].Value.Trim();
                                listLogData.Add(logDataRecord);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Data skipped data format incorrect.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File doesnot exist.");
            }
            return new Tuple<List<DeviceDataModel>, List<LogDataModel>>(listDeviceData, listLogData);
        }
    }
}
