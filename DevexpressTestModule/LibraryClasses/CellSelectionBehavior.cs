using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DevexpressTestModule.LibraryClasses
{
    /// <summary>
    /// пример скачан с сайта devexpress по ссылке:
    /// https://supportcenter.devexpress.com/Ticket/Details/T111707/selected-cells-binding-for-wpf-gridcontrol
    /// </summary>
    public class CellSelectionBehavior : Behavior<GridControl>
    {
        public List<object> SelectedCells
        {
            get { return (List<object>)GetValue(SelectedCellsProperty); }
            set { SetValue(SelectedCellsProperty, value); }
        }
        public static readonly DependencyProperty SelectedCellsProperty = DependencyProperty.Register("SelectedCells", typeof(List<object>), typeof(CellSelectionBehavior), null);

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged += AssociatedObject_SelectionChanged;
        }
        protected override void OnDetaching()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged -= AssociatedObject_SelectionChanged;
        }

        private void AssociatedObject_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            SelectedCells = ((TableView)AssociatedObject.View).GetSelectedCells().Cast<object>().ToList();
        }
    }
}
