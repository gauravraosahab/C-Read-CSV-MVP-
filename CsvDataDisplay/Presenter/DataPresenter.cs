using CsvDataDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvDataDisplay.services;

namespace CsvDataDisplay.Presenter
{   /// <summary>
/// Model to combine Device data model and LogData model for view to display.
/// </summary>
    public class ReportModel : LogDataModel
    {

        /// <summary>
        /// Changes Time from provided timezone to new time zone.
        /// </summary>
        /// <param name="CurrentTimeZone"></param>
        /// <param name="NewTimeZone"></param>
        public void UpdateTimezone(TimeZoneInfo CurrentTimeZone, TimeZoneInfo NewTimeZone)
        {
            // Convert and update to new timezone
            DataDate = TimeZoneInfo.ConvertTime(DataDate, CurrentTimeZone, NewTimeZone);
        }
        public ReportModel(DeviceDataModel deviceDataModel)
        {
            AssetId = deviceDataModel.AssetId;
            AssetName = deviceDataModel.AssetName;
            DataDate = deviceDataModel.DataDate;
            Latitude = deviceDataModel.Latitude;
            Longitude = deviceDataModel.Longitude;
            ReportBody = deviceDataModel.ReportBody;
            Snr = deviceDataModel.Snr;
            Vbat = deviceDataModel.Vbat;
        }
        public ReportModel(LogDataModel logDatamodel)
        {
            AssetId = logDatamodel.AssetId;
            AssetName = logDatamodel.AssetName;
            DataDate = logDatamodel.DataDate;
            Latitude = logDatamodel.Latitude;
            Longitude = logDatamodel.Longitude;
            ReportBody = logDatamodel.ReportBody;
            Snr = logDatamodel.Snr;
            Vbat = logDatamodel.Vbat;
            Duration = logDatamodel.Duration;
            Event = logDatamodel.Event;
            Distance = logDatamodel.Distance;
        }
    }
    /// <summary>
    /// Presenter class to connect model and view.
    /// </summary>
    public class DataPresenter
    {
        private List<DeviceDataModel> deviceDatamodel;
        private List<LogDataModel> logDatamodel;
        private MainView view;
        public TimeZoneInfo CurrentTimeZone;
        public List<ReportModel> reportModel = new List<ReportModel>();

        public DataPresenter(List<DeviceDataModel> deviceDatamodel, List<LogDataModel> logDatamodel, MainView view)
        {
            // assign default values
            this.deviceDatamodel = deviceDatamodel;
            this.logDatamodel = logDatamodel;
            this.view = view;

            view.Presenter = this;
        }

        /// <summary>
        /// Method works on click event
        /// </summary>
        public void OnClick_LoadData()
        {
            string file_name;
            file_name = @"C:\Users\gaura\Desktop\metOcean\214863258263612.csv";
            var file_reader = new ReadCsvFile();
            // Tuple for multiple type of objects
            Tuple<List<DeviceDataModel>, List<LogDataModel>> datamodels;
            datamodels = file_reader.ReadFile(file_name);
            this.deviceDatamodel = datamodels.Item1;
            this.logDatamodel = datamodels.Item2;
            // type cast to new list
            this.reportModel = this.deviceDatamodel.Select(r => new ReportModel(r)).ToList<ReportModel>();
            this.reportModel.InsertRange(this.reportModel.Count(), this.logDatamodel.Select(r => new ReportModel(r)).ToList<ReportModel>());
            // Set default timezone to UTC
            this.CurrentTimeZone = TimeZoneInfo.Utc;

            this.view.BindData(this.reportModel);
        }

        /// <summary>
        /// Method to update time
        /// </summary>
        /// <param name="NewTimeZone"></param>
        public void UpdateTime(TimeZoneInfo NewTimeZone)
        {
            // Update date to to new timezone
            reportModel.ForEach(record => record.UpdateTimezone(this.CurrentTimeZone, NewTimeZone));
            this.CurrentTimeZone = NewTimeZone;
            this.view.BindData(reportModel);
        }
    }
}
