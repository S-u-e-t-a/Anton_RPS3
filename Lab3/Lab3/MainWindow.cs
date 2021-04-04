using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainWindow : Form
    {
        private static double leftBorder; // Левая граница
        private static double rightBorder; // Правая граница
        private static double topBorder; // Верхняя граница
        private static double bottomBorder; // Нижняя граница
        private static double step; // Шаг
        private static double coeffC; // Коэффициент C
        private static double coeffA; // Коэффициент A
        private static double x; // Координата X
        private static double y; // Координата Y
        public static List<double> valuesX = new List<double>(); // Список координат X функции
        public static List<double> valuesY = new List<double>(); // Список координат Y функции

        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            chartCO.Show();
            chartCO.Series["CassiniOvalPos"].Points.AddXY(0, 0);
            chartCO.Series["CassiniOvalNeg"].Points.AddXY(0, 0);
            chartCO.ChartAreas[0].AxisX.Minimum = 0;
            chartCO.ChartAreas[0].AxisX.Maximum = 100;
            chartCO.ChartAreas[0].AxisY.Minimum = 0;
            chartCO.ChartAreas[0].AxisY.Maximum = 100;
        }


        private void CreateChartButton_Click(object sender, EventArgs e)
        {


            try
            {
                valuesX.Clear();
                valuesY.Clear();
                chartCO.Series["CassiniOvalPos"].Points.Clear();
                chartCO.Series["CassiniOvalNeg"].Points.Clear();

                leftBorder = (double)LeftBorderUpDown.Value;
                rightBorder = (double)RightBorderUpDown.Value;
                topBorder = (double)TopBorderUpDown.Value;
                bottomBorder = (double)BottomBorderUpDown.Value;
                step = (double)ScaleUpDown.Value;
                coeffC = (double)CUpDown.Value;
                coeffA = (double)AUpDown.Value;


                if (topBorder <= bottomBorder || leftBorder >= rightBorder)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (coeffA == coeffC && coeffC == 0)
                {
                    MessageBox.Show("График вырождается в точку." + Environment.NewLine +
                              "Измените значение коэффициентов.", "Предупреждение!",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                chartCO.ChartAreas[0].AxisX.Minimum = leftBorder;
                chartCO.ChartAreas[0].AxisX.Maximum = rightBorder;
                chartCO.ChartAreas[0].AxisY.Minimum = bottomBorder;
                chartCO.ChartAreas[0].AxisY.Maximum = topBorder;


                x = -Math.Sqrt(Math.Pow(coeffC, 2) + Math.Pow(coeffA, 2));
                chartCO.Series["CassiniOvalPos"].Points.AddXY(x, 0);
                chartCO.Series["CassiniOvalNeg"].Points.AddXY(x, 0);
                valuesX.Add(x);
                valuesY.Add(0);

                for (x = -Math.Sqrt(Math.Pow(coeffC, 2) + Math.Pow(coeffA, 2)) + step; x < Math.Sqrt(Math.Pow(coeffC, 2) + Math.Pow(coeffA, 2)); x += step)
                {
                    y = CassiniOval.CalculatePointOnTheGraph(coeffA, coeffC, x); // Рассчёт координаты Y
                    // Проверка на построения графика в заданном интервале
                    if (x - step > rightBorder || x - step < leftBorder || y > topBorder || y < bottomBorder)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    chartCO.Series["CassiniOvalPos"].Points.AddXY(x, y); // Добавление точки на график
                    chartCO.Series["CassiniOvalNeg"].Points.AddXY(x, -y);
                    valuesX.Add(x); // Добавление точки в таблицу
                    valuesY.Add(y);
                }

                x = Math.Sqrt(Math.Pow(coeffC, 2) + Math.Pow(coeffA, 2));
                chartCO.Series["CassiniOvalPos"].Points.AddXY(x, 0);
                chartCO.Series["CassiniOvalNeg"].Points.AddXY(x, 0);
                valuesX.Add(x);
                valuesY.Add(0);

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("График не может быть построен при указанных данных." + Environment.NewLine +
                               "Измените значение коэффициентов, шага или границ.", "Ошибка!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                valuesX.Clear();
                valuesY.Clear();
                chartCO.Series["CassiniOvalPos"].Points.Clear();
                chartCO.Series["CassiniOvalNeg"].Points.Clear();

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine +
                                "Нижняя граница должна быть меньше верхней." + Environment.NewLine +
                                "Левая граница должна быть меньше правой.", "Ошибка!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                valuesX.Clear();
                valuesY.Clear();
                chartCO.Series["CassiniOvalPos"].Points.Clear();
                chartCO.Series["CassiniOvalNeg"].Points.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Одно из значений было недопустимо малым или недопустимо большим.",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valuesX.Clear();
                valuesY.Clear();
                chartCO.Series["CassiniOvalPos"].Points.Clear();
                chartCO.Series["CassiniOvalNeg"].Points.Clear();
            }
        }

        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void AUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateChartButton_Click(null, null);
        }

        private void CUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateChartButton_Click(null, null);
        }

        private void ScaleUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateChartButton_Click(null, null);
        }


    }
}
