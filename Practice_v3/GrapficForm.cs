using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_v3
{
    public partial class GrapficForm : Form
    {
        public GrapficForm(List<RegStorage> regStorages, List<string> names)
        {
            InitializeComponent();

            for(int i = 0; i<names.Count; i++)
            {
                chart1.Series.Add(names[i]);
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[i].BorderWidth = 3;
                chart1.Legends.Add(names[i]).Name = names[i];
                for(int j = 0; j<regStorages[i].ValueHistory.Count; j++)
                {
                    chart1.Series[i].Points.AddXY(j, regStorages[i].ValueHistory[j]);
                }
            }
        }
    }
}
