using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class WorkWithFiles
    {
        public static void SaveToFile(string fileOutputPath, string text)
        {
            System.IO.File.WriteAllText(fileOutputPath, text);
        }

        public static string MakeResult(string leftBorder, string rightBorder, string topBorder, string bottomBorder, string step, string coeffC, string coeffA, List<double> valuesX, List<double> valuesY)
        {
            string values;
            string answer = "Левая граница: " + leftBorder + Environment.NewLine +
                            "Правая граница: " + rightBorder + Environment.NewLine +
                            "Верхняя граница: " + topBorder + Environment.NewLine +
                            "Нижняя граница: " + bottomBorder + Environment.NewLine +
                            "Шаг: " + step + Environment.NewLine +
                            "Коэффициент C: " + coeffC + Environment.NewLine +
                            "Коэффициент A: " + coeffA + Environment.NewLine + Environment.NewLine +
                            "Таблица значений." + Environment.NewLine + Environment.NewLine;
            values = String.Format("{0, 12} {1, 15} {2, 15}", "Координата X", "Координата Y", "Координата -Y");
            for (int i = 0; i < valuesX.Count; i++)
            {
                values += String.Format("\n{0, 9} {1, 16} {2, 15}",
                                       Math.Round(valuesX[i], 2), Math.Round(valuesY[i], 2), -Math.Round(valuesY[i], 2));

            }
            answer += values;
            return answer;
        }
        public static List<decimal> FromFileInput(string fileInputPath)
        {
            string arrStr = null;
            arrStr = System.IO.File.ReadAllText(fileInputPath); 
            string[] stringSeparators = { "\r", "\n", " ", "\t" };
            List<decimal> tempList = arrStr.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries) 
                                  .Select(n => decimal.Parse(n)) 
                                  .ToList(); 
            fileInputPath = string.Empty; 
            return tempList;
        }
    }
}

