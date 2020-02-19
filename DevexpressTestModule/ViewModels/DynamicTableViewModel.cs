using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevexpressTestModule.LibraryClasses;
using DevexpressTestModule.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace DevexpressTestModule.ViewModels
{
    [POCOViewModel]
    public class DynamicTableViewModel : ViewModelBase
    {
        public List<object> SelectedCells { get; set; }
        public ObservableCollection<Dictionary<int, DynamicTableModel>> CommonEditCollection { get; set; }

        private RelayCommand _deleteNewRowCommonEdit;
        public RelayCommand DeleteNewRowCommonEdit
        {
            get
            {
                return _deleteNewRowCommonEdit ??
                    (_deleteNewRowCommonEdit = new RelayCommand(obj =>
                    {
                    }));
            }
        }

        public DynamicTableViewModel()
        {
            CommonEditCollection = CreateDynamicTableData();
        }

        private void MergeCells()
        {
            CommonEditCollection.ToList().ForEach(row =>
            {
            });
        }

        private Dictionary<string, string> FillCurrentDictionaryRow(IEnumerable<string> stringRow, int maxCount)
        {
            int currentCount = stringRow.Count();
            var dictRow = Enumerable.Range(0, maxCount)
                .ToDictionary(i => ColumnNameForChildEditGrid.ColumnHeaderName + i, i => i < currentCount ? stringRow.ElementAt(i) : stringRow.Last());
            return dictRow;
        }

        private ObservableCollection<Dictionary<int, DynamicTableModel>> CreateDynamicTableData()
        {
            double width = 800;
            return new ObservableCollection<Dictionary<int, DynamicTableModel>>()
            {
                new Dictionary<int, DynamicTableModel>()
                {
                    [1] = new DynamicTableModel("1", width),
                    [2] = new DynamicTableModel("test", width),
                    [3] = new DynamicTableModel("", width, true),
                    [4] = new DynamicTableModel("testtest1", width)
                },
                new Dictionary<int, DynamicTableModel>()
                {
                    [1] = new DynamicTableModel("2", width),
                    [2] = new DynamicTableModel("TEST", width),
                    [3] = new DynamicTableModel("test2", width),
                    [4] = new DynamicTableModel("testtest2", width)
                },
                new Dictionary<int, DynamicTableModel>()
                {
                    [1] = new DynamicTableModel("3", width),
                    [2] = new DynamicTableModel("TEST", width),
                    [3] = new DynamicTableModel("test3", width),
                    [4] = new DynamicTableModel("testtest3", width)
                }
            };
        }
    }
}