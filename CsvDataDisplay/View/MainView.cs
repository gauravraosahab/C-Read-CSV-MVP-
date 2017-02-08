using CsvDataDisplay.Model;
using CsvDataDisplay.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvDataDisplay
{
    public partial class MainView : Form
    {
        // connecting to resetner
        public DataPresenter Presenter { get; set; }
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(DateTime.Now);
            // background task initiated
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Factory.StartNew(() => { Presenter.OnClick_LoadData(); }));
            //Presenter.OnClick_LoadData();
            //Console.WriteLine(DateTime.Now);
        }

        public void BindData(List<ReportModel> model)
        {
            // Create due to threading and updating data after update.
            this.dataGridView1.Invoke(new Action(() => {
                this.dataGridView1.DataSource = model;
                this.lblTimeZone.Text = "Current Timezone : " + Presenter.CurrentTimeZone.Id;
                // sorting the way column should be ordered
                this.dataGridView1.Columns["AssetName"].DisplayIndex = 0;
                this.dataGridView1.Columns["AssetId"].DisplayIndex = 1;
                this.dataGridView1.Columns["DataDate"].DisplayIndex = 2;
                this.dataGridView1.Columns["Latitude"].DisplayIndex = 3;
                this.dataGridView1.Columns["Longitude"].DisplayIndex = 4;
                this.dataGridView1.Columns["Vbat"].DisplayIndex = 5;
                this.dataGridView1.Columns["Snr"].DisplayIndex = 6;
                this.dataGridView1.Columns["Event"].DisplayIndex = 7;
                this.dataGridView1.Columns["Duration"].DisplayIndex = 8;
                this.dataGridView1.Columns["Distance"].DisplayIndex = 9;
                this.dataGridView1.Columns["ReportBody"].DisplayIndex = 10;
                this.dataGridView1.Refresh();
            }));
            //this.dataGridView1.DataSource = model;
        }

        private void uTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeZoneInfo NewTimeZone = TimeZoneInfo.FindSystemTimeZoneById("UTC");
            Presenter.UpdateTime(NewTimeZone);
        }

        private void cSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeZoneInfo NewTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            Presenter.UpdateTime(NewTimeZone);
        }

        private void eSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeZoneInfo NewTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            Presenter.UpdateTime(NewTimeZone);
        }
    }
}
