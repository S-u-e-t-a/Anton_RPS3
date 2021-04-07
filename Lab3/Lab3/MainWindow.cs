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
            saveFileDialog1.Filter = @"Text files(*.txt)|*.txt";
            MaximizeBox = false;
            chartCO.Show();
            chartCO.Series["CassiniOvalPos"].Points.AddXY(0, 0);
            chartCO.Series["CassiniOvalNeg"].Points.AddXY(0, 0);
            chartCO.ChartAreas[0].AxisX.Minimum = 0;
            chartCO.ChartAreas[0].AxisX.Maximum = 100;
            chartCO.ChartAreas[0].AxisY.Minimum = 0;
            chartCO.ChartAreas[0].AxisY.Maximum = 100;
            if (InfoShowing.Default.Show == true)
            {
                InfoToolStripMenuItem_Click(null, null);
                ShowInfoOnStartToolStripMenuItem.Checked = true;
            }
            else ShowInfoOnStartToolStripMenuItem.Checked = false;
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

                TableButton.Enabled = true;
                SaveDataToolStripMenuItem.Enabled = true;
                SaveResultToolStripMenuItem.Enabled = true;

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
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) // Обработка закрытия окна сохранения введенных данных
                return;
            string fileOutputPath = saveFileDialog1.FileName; // Получение имени файла 
            saveFileDialog1.FileName = string.Empty;
            // Формирование результата
            string answer = LeftBorderUpDown.Text + " " +
                            RightBorderUpDown.Text + " " +
                            TopBorderUpDown.Text + " " +
                            BottomBorderUpDown.Text + " " +
                            ScaleUpDown.Text + " " +
                            CUpDown.Text + " " +
                            AUpDown.Text;
            // Сохранение результата
            WorkWithFiles.SaveToFile(fileOutputPath, answer);
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

        private void TableButton_Click(object sender, EventArgs e)
        {
            var table = new Table(valuesX, valuesY);
            table.Show();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("В файле должно содержаться только 7 чисел в строго определённом порядке:" + Environment.NewLine +
                                "левая граница, правая граница, верхняя граница, нижняя граница, шаг, коэффициент C, коэффициент А." + Environment.NewLine, "Внимание!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) 
                    return;
                string fileInputPath = openFileDialog1.FileName; 
                List<decimal> initialData = WorkWithFiles.FromFileInput(fileInputPath);
                openFileDialog1.FileName = string.Empty;
                if (initialData.Count > 7 || initialData.Count < 7)
                {
                    throw new ArgumentOutOfRangeException();
                }
                LeftBorderUpDown.Value = initialData[0];
                RightBorderUpDown.Value = initialData[1];
                TopBorderUpDown.Value = initialData[2];
                BottomBorderUpDown.Value = initialData[3];
                ScaleUpDown.Value = initialData[4];
                CUpDown.Value = initialData[5];
                AUpDown.Value = initialData[6];
                

            }
            catch (FormatException)
            {
                MessageBox.Show("Файл содержит некорректные данные.\n" +
                                "Файл не должен содержать букв и спец. символов.", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В файле недостаточно данных или файл содержит больше данных, чем нужно.", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) 
                return;
            string fileOutputPath = saveFileDialog1.FileName;
            saveFileDialog1.FileName = string.Empty;
            string answer = WorkWithFiles.MakeResult(LeftBorderUpDown.Text, RightBorderUpDown.Text, TopBorderUpDown.Text, BottomBorderUpDown.Text, ScaleUpDown.Text, CUpDown.Text, AUpDown.Text, valuesX, valuesY);
            WorkWithFiles.SaveToFile(fileOutputPath, answer);
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Гусев Антон " + Environment.NewLine +
                "Учебное заведение: СПБГТИ(ТУ)" + Environment.NewLine +
                "Группа: 494" + Environment.NewLine +
                "Использование WinForms для построения графика функции и вывод таблицы значений" + Environment.NewLine +
                "Функция: Овалы Кассини" + Environment.NewLine,
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowInfoOnStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowInfoOnStartToolStripMenuItem.Checked)
            {
                ShowInfoOnStartToolStripMenuItem.Checked = false;
                InfoShowing.Default.Show = false;
                InfoShowing.Default.Save();
            }
            else
            {
                ShowInfoOnStartToolStripMenuItem.Checked = true;
                InfoShowing.Default.Show = true;
                InfoShowing.Default.Save();
            }
        }
    }
}
