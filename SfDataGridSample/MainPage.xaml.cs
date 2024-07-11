using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var headerCount = dataGrid.GetRowGenerator().Items.Where(row => (row.RowType == RowType.HeaderRow || row.RowType == RowType.StackedHeaderRow)).Count();
            var rowsCount = dataGrid.GetVisualContainer().RowCount - headerCount;
            await DisplayAlert("Row's Count", $"The Number of Rows in the DataGrid is {rowsCount}", "Ok");
        }
    }
}
