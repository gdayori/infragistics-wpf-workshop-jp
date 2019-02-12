# Get started with XamDataGrid

If you have installed Infragistics WPF controls, all controls should be ready in the Toolbox in your Visual Studio. You can use them just like you develop with Common WPF Controls.

Please open the project in "before" folder you downloaded, which is in infragistics-wpf-workshop/src/before.

## Check MainWindowViewModel.cs

Open MainWindowViewModel.cs and check what's in the class.

```cs
...
public ICommand OpenDashboard { get; set; }
public ICommand OpenBiWindow { get; set; }

public MainWindowViewModel()
{

    //Get sales data to be bound to grid
    SalesDataSample salesDataSample = new SalesDataSample();
    salesRecords = salesDataSample.SalesData;

    // Commands
    OpenDashboard = new OpenDashboardCommand();
    OpenBiWindow = new OpenPivotCommand();
}

private ObservableCollection<Sale> salesRecords;
public ObservableCollection<Sale> SalesRecords
{
    get { return salesRecords; }
}
...
    
```

This class has
 - SalesRecords to be bound to XamDataGrid
 - OpenDashboardCommand to bring up the dashboard window (used in the 2nd section)
 - OpenPivotCommand to bring up the BI window (used in the 3rd section)

## Check MainWindow.xaml

Open MainWindow.xaml and check what's in the xaml.
```xml
<Window
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IgWpfWorkshop"
        xmlns:vm="clr-namespace:IgWpfWorkshop.ViewModel" xmlns:Custom="http://infragistics.com/DataPresenter" x:Class="IgWpfWorkshop.MainWindow"
        mc:Ignorable="d"
        Title="MainWindow" Height="600" Width="1000"
        >
    <Window.DataContext>
        <vm:MainWindowViewModel/>
    </Window.DataContext>
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="25px"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <Button Content="Dashboard" Command="{Binding OpenDashboard}" Grid.Column="0"/>
        <Button Content="Pivot" Command="{Binding OpenBiWindow}" Grid.Column="1"/>
    </Grid>
</Window>
```

This xaml has
 - MainWindowViewModel bound to this view
 - Grid Column/Row definitions to split and layout the screen
 - Two buttons to bring up another windows

## Add XamDataGrid in MainWindow.xaml

Open MainWindow.xaml and drag XamDataGrid in your Toolbox and drop into the designer. Reset the layout of XamDataGrid and bind the grid to SalesRecords by setting the DataSource property.

MainWindow.xaml

```xml
・・・
<Custom:XamDataGrid DataSource="{Binding Path=SalesRecords}" Grid.Row="1" Grid.ColumnSpan="2"/>
・・・
```

## Check the result

Run the app and check the result.

![](../assets/01-01-01.png)

## Note

XamDataGrid has a capability of generating column definitions automatically corresponding to the bound data. If you want to configure columns to display in detail you need to set AutoGenerateFields property to False and define all fields. (You'll do it later in the 2nd section.)

## Next
[01-02 Configure XamDataGrid](01-02-Configure-XamDataGrid.md)
