using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
   
    public partial class Table : Form
    {
        public int rowCount;
        public static List<double> tempValuesX = new List<double> { };
        public static List<double> tempValuesY = new List<double> { };
        public Table(List<double> valuesX, List<double> valuesY)
        {
            tempValuesX.Clear();
            tempValuesY.Clear();
            rowCount = valuesX.Count;
            for (int i = 0; i < valuesX.Count; i++)
            {
                tempValuesX.Add(valuesX[i]);
                tempValuesY.Add(valuesY[i]);
            }
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            TableFunc.Rows.Clear();
            TableFunc.RowCount = rowCount;
            for (int i = 0; i < tempValuesX.Count; i++)
            {
                TableFunc[0, i].Value = Math.Round(tempValuesX[i], 2);
                TableFunc[1, i].Value = Math.Round(tempValuesY[i], 2);
                TableFunc[2, i].Value = -Math.Round(tempValuesY[i], 2);
            }
        }
    }
}
