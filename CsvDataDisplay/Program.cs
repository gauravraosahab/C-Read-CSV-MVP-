using CsvDataDisplay.Model;
using CsvDataDisplay.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvDataDisplay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // model
            List<DeviceDataModel> deviceDatamodel = new List<DeviceDataModel>();
            List<LogDataModel> logDatamodel = new List<LogDataModel>();

            //view
            MainView view = new MainView();

            // Presenter
            DataPresenter presenter = new DataPresenter(deviceDatamodel, logDatamodel, view);

            Application.Run(view);
        }
    }
}
