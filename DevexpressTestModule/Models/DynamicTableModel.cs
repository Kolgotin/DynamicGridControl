using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace DevexpressTestModule.Models
{
    public class DynamicTableModel
    {

        public int Id { get; set; }
        public double CellWidth { get; set; }
        public string StrValue { get; set; }

        public bool IsBorerNull { get; set; }

        public Brush CellBackgroundBrush { get; set; }

        public DynamicTableModel(string strVal, double cellWidth, bool isBorerNull = false)
        {
            StrValue = strVal;
            CellWidth = cellWidth;
            IsBorerNull = isBorerNull;
            CellBackgroundBrush = Brushes.AliceBlue;
        }
    }
}
