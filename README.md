# How to get the number of rows in .NET MAUI DataGrid
In this article, we will show you how to get the number of rows in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid)..
XAML
```
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ColumnWidthMode="Auto"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"
                           AutoGenerateColumnsMode="None"
                           ItemsSource="{Binding Employees}">
 
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                              HeaderText="Employee ID" />
            <syncfusion:DataGridTextColumn MappingName="Name"
                                           HeaderText="Employee Name" />
            <syncfusion:DataGridTextColumn MappingName="Title"
                                           HeaderText="Designation" />
            <syncfusion:DataGridDateColumn MappingName="HireDate"
                                           HeaderText="Hire Date" />
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
 ```
C#
The below code illustrates how to get the number of rows in DataGrid.
```
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
 
    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var headerCount = dataGrid.GetRowGenerator().Items.Where(row => (row.RowType == RowType.HeaderRow || row.RowType == RowType.StackedHeaderRow)).Count();
        var rowsCount = dataGrid.GetVisualContainer().RowCount - headerCount;
        await DisplayAlert("Row's Count", $"The Number of Rows in the DataGrid is {rowsCount}", "Ok");
    }

```
 ![NumberOfRows.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI1MDk0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.2VKg-vc6AQbpeOHRvoOBcsYGe9DadwR7iWRmdfTfM7w)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-get-the-number-of-rows-in-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to get the number of rows in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!


 
