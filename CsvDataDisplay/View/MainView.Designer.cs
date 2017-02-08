namespace CsvDataDisplay
{
    public partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTimeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeZone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1291, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.changeTimeZoneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // changeTimeZoneToolStripMenuItem
            // 
            this.changeTimeZoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTCToolStripMenuItem,
            this.cSTToolStripMenuItem,
            this.eSTToolStripMenuItem});
            this.changeTimeZoneToolStripMenuItem.Name = "changeTimeZoneToolStripMenuItem";
            this.changeTimeZoneToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.changeTimeZoneToolStripMenuItem.Text = "Change Time Zone";
            // 
            // uTCToolStripMenuItem
            // 
            this.uTCToolStripMenuItem.Name = "uTCToolStripMenuItem";
            this.uTCToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.uTCToolStripMenuItem.Text = "UTC";
            this.uTCToolStripMenuItem.Click += new System.EventHandler(this.uTCToolStripMenuItem_Click);
            // 
            // cSTToolStripMenuItem
            // 
            this.cSTToolStripMenuItem.Name = "cSTToolStripMenuItem";
            this.cSTToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.cSTToolStripMenuItem.Text = "CST";
            this.cSTToolStripMenuItem.Click += new System.EventHandler(this.cSTToolStripMenuItem_Click);
            // 
            // eSTToolStripMenuItem
            // 
            this.eSTToolStripMenuItem.Name = "eSTToolStripMenuItem";
            this.eSTToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.eSTToolStripMenuItem.Text = "EST";
            this.eSTToolStripMenuItem.Click += new System.EventHandler(this.eSTToolStripMenuItem_Click);
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimeZone.Location = new System.Drawing.Point(0, 477);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(95, 13);
            this.lblTimeZone.TabIndex = 2;
            this.lblTimeZone.Text = "Current Time Zone";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 490);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Main View";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimeZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTToolStripMenuItem;
        private System.Windows.Forms.Label lblTimeZone;
    }
}

