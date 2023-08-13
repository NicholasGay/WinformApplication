namespace Bluetooth
{
    partial class Guage_cs
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
            this.radRadialGauge1 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle1 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels1 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeSingleLabel1 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRadialGauge1
            // 
            this.radRadialGauge1.BackColor = System.Drawing.Color.White;
            this.radRadialGauge1.CausesValidation = false;
            this.radRadialGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRadialGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeNeedle1,
            this.radialGaugeLabels1,
            this.radialGaugeSingleLabel1});
            this.radRadialGauge1.Location = new System.Drawing.Point(0, 0);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.RangeEnd = 50D;
            this.radRadialGauge1.Size = new System.Drawing.Size(938, 270);
            this.radRadialGauge1.StartAngle = 205D;
            this.radRadialGauge1.SweepAngle = 130D;
            this.radRadialGauge1.TabIndex = 6;
            this.radRadialGauge1.Text = "radRadialGauge1";
            this.radRadialGauge1.Value = 33.33F;
            // 
            // radialGaugeArc1
            // 
            this.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc1.BindEndRange = true;
            this.radialGaugeArc1.Name = "radialGaugeArc1";
            this.radialGaugeArc1.RangeEnd = 33.330001831054688D;
            this.radialGaugeArc1.Width = 40D;
            // 
            // radialGaugeArc2
            // 
            this.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc2.BindStartRange = true;
            this.radialGaugeArc2.Name = "radialGaugeArc2";
            this.radialGaugeArc2.RangeEnd = 50D;
            this.radialGaugeArc2.RangeStart = 33.330001831054688D;
            this.radialGaugeArc2.Width = 40D;
            // 
            // radialGaugeNeedle1
            // 
            this.radialGaugeNeedle1.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle1.BindValue = true;
            this.radialGaugeNeedle1.InnerPointRadiusPercentage = 4D;
            this.radialGaugeNeedle1.LenghtPercentage = 110D;
            this.radialGaugeNeedle1.Name = "radialGaugeNeedle1";
            this.radialGaugeNeedle1.Thickness = 0.7D;
            this.radialGaugeNeedle1.Value = 33.33F;
            // 
            // radialGaugeLabels1
            // 
            this.radialGaugeLabels1.DrawText = false;
            this.radialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels1.LabelRadiusPercentage = 112F;
            this.radialGaugeLabels1.LabelsCount = 1;
            this.radialGaugeLabels1.Name = "radialGaugeLabels1";
            // 
            // radialGaugeSingleLabel1
            // 
            this.radialGaugeSingleLabel1.BindValue = true;
            this.radialGaugeSingleLabel1.LabelFormat = "n2";
            this.radialGaugeSingleLabel1.LabelText = "Text";
            this.radialGaugeSingleLabel1.LocationPercentage = new System.Drawing.SizeF(0F, 0.25F);
            this.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1";
            // 
            // Guage_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 270);
            this.Controls.Add(this.radRadialGauge1);
            this.Name = "Guage_cs";
            this.Text = "Guage";
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel1;
    }
}
