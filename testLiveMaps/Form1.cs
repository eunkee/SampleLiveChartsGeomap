using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testLiveMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();

            Dictionary<string, double> values = new Dictionary<string, double>
            {
                ["JP"] = 300,
                ["CN"] = 400,
                ["KR"] = 720,
                ["US"] = 700,
                ["GB"] = 220,
                ["AU"] = 200,
                ["ZA"] = 200,
                ["ID"] = 150,
                ["FR"] = 150
            };

            geoMap.HeatMap = values;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
