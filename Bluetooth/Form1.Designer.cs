namespace Bluetooth
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gauge_tab = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.mac_address_label = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.Chart_tab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGuage = new System.Windows.Forms.TabPage();
            this.tempGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.tempGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.tempGaugeSingleLabel1 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.tempGuage = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.highest_temp_label = new System.Windows.Forms.Label();
            this.gauge_tab.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Chart_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabGuage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempGuage)).BeginInit();
            this.tabDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBTDevices
            // 
            this.cbBTDevices.FormattingEnabled = true;
            this.cbBTDevices.Location = new System.Drawing.Point(45, 7);
            this.cbBTDevices.Margin = new System.Windows.Forms.Padding(2);
            this.cbBTDevices.Name = "cbBTDevices";
            this.cbBTDevices.Size = new System.Drawing.Size(129, 21);
            this.cbBTDevices.TabIndex = 0;
            this.cbBTDevices.SelectedIndexChanged += new System.EventHandler(this.cbBTDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Display";
            // 
            // gauge_tab
            // 
            this.gauge_tab.Controls.Add(this.Settings);
            this.gauge_tab.Controls.Add(this.tabDashboard);
            this.gauge_tab.Controls.Add(this.Chart_tab);
            this.gauge_tab.Controls.Add(this.tabGuage);
            this.gauge_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gauge_tab.Location = new System.Drawing.Point(0, 0);
            this.gauge_tab.Name = "gauge_tab";
            this.gauge_tab.SelectedIndex = 0;
            this.gauge_tab.Size = new System.Drawing.Size(918, 297);
            this.gauge_tab.TabIndex = 9;
            this.gauge_tab.Click += new System.EventHandler(this.gauge_tab_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.mac_address_label);
            this.Settings.Controls.Add(this.btnDisconnect);
            this.Settings.Controls.Add(this.cbBTDevices);
            this.Settings.Controls.Add(this.btnSend);
            this.Settings.Controls.Add(this.txtDisplay);
            this.Settings.Controls.Add(this.txtSend);
            this.Settings.Controls.Add(this.btnConnect);
            this.Settings.Controls.Add(this.btnDiscover);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(910, 271);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // mac_address_label
            // 
            this.mac_address_label.AutoSize = true;
            this.mac_address_label.Location = new System.Drawing.Point(42, 30);
            this.mac_address_label.Name = "mac_address_label";
            this.mac_address_label.Size = new System.Drawing.Size(0, 13);
            this.mac_address_label.TabIndex = 8;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(376, 7);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(804, 224);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 21);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(45, 55);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(828, 155);
            this.txtDisplay.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(45, 225);
            this.txtSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(743, 20);
            this.txtSend.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(284, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(194, 7);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(75, 23);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "Discover";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // Chart_tab
            // 
            this.Chart_tab.Controls.Add(this.chart1);
            this.Chart_tab.Location = new System.Drawing.Point(4, 22);
            this.Chart_tab.Name = "Chart_tab";
            this.Chart_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Chart_tab.Size = new System.Drawing.Size(910, 271);
            this.Chart_tab.TabIndex = 1;
            this.Chart_tab.Text = "Chart";
            this.Chart_tab.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(904, 265);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tabGuage
            // 
            this.tabGuage.Controls.Add(this.tempGuage);
            this.tabGuage.Location = new System.Drawing.Point(4, 22);
            this.tabGuage.Name = "tabGuage";
            this.tabGuage.Size = new System.Drawing.Size(910, 271);
            this.tabGuage.TabIndex = 2;
            this.tabGuage.Text = "Gauge";
            this.tabGuage.UseVisualStyleBackColor = true;
            // 
            // tempGaugeArc1
            // 
            this.tempGaugeArc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.tempGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.tempGaugeArc1.BindEndRange = true;
            this.tempGaugeArc1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeArc1.Name = "tempGaugeArc1";
            this.tempGaugeArc1.RangeEnd = 60D;
            this.tempGaugeArc1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeArc1.UseCompatibleTextRendering = false;
            this.tempGaugeArc1.Width = 40D;
            // 
            // tempGaugeArc2
            // 
            this.tempGaugeArc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.tempGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.tempGaugeArc2.BindStartRange = true;
            this.tempGaugeArc2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeArc2.Name = "tempGaugeArc2";
            this.tempGaugeArc2.RangeEnd = 100D;
            this.tempGaugeArc2.RangeStart = 60D;
            this.tempGaugeArc2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeArc2.UseCompatibleTextRendering = false;
            this.tempGaugeArc2.Width = 40D;
            // 
            // tempGaugeSingleLabel1
            // 
            this.tempGaugeSingleLabel1.BindValue = true;
            this.tempGaugeSingleLabel1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeSingleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.tempGaugeSingleLabel1.LabelFontSize = 10F;
            this.tempGaugeSingleLabel1.LabelText = "Text";
            this.tempGaugeSingleLabel1.LocationPercentage = new System.Drawing.SizeF(0F, -0.1F);
            this.tempGaugeSingleLabel1.Name = "tempGaugeSingleLabel1";
            this.tempGaugeSingleLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tempGaugeSingleLabel1.UseCompatibleTextRendering = false;
            // 
            // tempGuage
            // 
            this.tempGuage.BackColor = System.Drawing.Color.White;
            this.tempGuage.CausesValidation = false;
            this.tempGuage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempGuage.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tempGaugeArc1,
            this.tempGaugeArc2,
            this.tempGaugeSingleLabel1});
            this.tempGuage.Location = new System.Drawing.Point(0, 0);
            this.tempGuage.Name = "tempGuage";
            this.tempGuage.Size = new System.Drawing.Size(910, 271);
            this.tempGuage.StartAngle = 180D;
            this.tempGuage.SweepAngle = 180D;
            this.tempGuage.TabIndex = 6;
            this.tempGuage.Text = "radRadialGauge1";
            this.tempGuage.Value = 60F;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.highest_temp_label);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(910, 271);
            this.tabDashboard.TabIndex = 3;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // highest_temp_label
            // 
            this.highest_temp_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highest_temp_label.AutoSize = true;
            this.highest_temp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highest_temp_label.Location = new System.Drawing.Point(371, 63);
            this.highest_temp_label.Name = "highest_temp_label";
            this.highest_temp_label.Size = new System.Drawing.Size(98, 108);
            this.highest_temp_label.TabIndex = 0;
            this.highest_temp_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 297);
            this.Controls.Add(this.gauge_tab);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gauge_tab.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Chart_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabGuage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempGuage)).EndInit();
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBTDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl gauge_tab;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label mac_address_label;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.TabPage Chart_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabGuage;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge tempGuage;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc tempGaugeArc1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc tempGaugeArc2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel tempGaugeSingleLabel1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label highest_temp_label;
    }
}

