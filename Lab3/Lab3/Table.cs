using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{

    public partial class Table : Form
    {
        public int rowCount;
        public static List<double> tempValuesX = new List<double> { };
        public static List<double> tempValuesY = new List<double> { };
        decimal left;
        decimal right;
        decimal top;
        decimal bottom;
        decimal coeffC;
        decimal coeffA;
        decimal step;

        public Table(List<double> valuesX, List<double> valuesY, MainWindow textBoxes)
        {
            left = textBoxes.LeftBorderUpDown.Value;
            right = textBoxes.RightBorderUpDown.Value;
            top = textBoxes.TopBorderUpDown.Value;
            bottom = textBoxes.BottomBorderUpDown.Value;
            coeffC = textBoxes.CUpDown.Value;
            coeffA = textBoxes.AUpDown.Value;
            step = textBoxes.ScaleUpDown.Value;

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

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            ExcelApp.Cells[1, 1] = "Результат построения Овалов Кассини";
            ExcelApp.Cells[2, 1] = "Левая граница: "; ExcelApp.Cells[2, 2] = left;
            ExcelApp.Cells[3, 1] = "Правая граница: "; ExcelApp.Cells[3, 2] = right;
            ExcelApp.Cells[4, 1] = "Верхняя граница: "; ExcelApp.Cells[4, 2] = top;
            ExcelApp.Cells[5, 1] = "Нижняя граница: "; ExcelApp.Cells[5, 2] = bottom;
            ExcelApp.Cells[6, 1] = "Коэффициент С: "; ExcelApp.Cells[6, 2] = coeffC;
            ExcelApp.Cells[7, 1] = "Коэффициент А: "; ExcelApp.Cells[7, 2] = coeffA;
            ExcelApp.Cells[8, 1] = "Шаг: "; ExcelApp.Cells[8, 2] = step;
            ExcelApp.Cells[9, 1] = "Таблица значений:";
            ExcelApp.Cells[10, 1] = "Х"; ExcelApp.Cells[10, 2] = "Y"; ExcelApp.Cells[10, 3] = "-Y";
            for (int i = 0; i < TableFunc.Rows.Count; i++)
            {
                for (int j = 0; j < TableFunc.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 11, j + 1] = TableFunc.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }

}
