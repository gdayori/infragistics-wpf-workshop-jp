# Use Pivot Controls


## Check Pivot.xaml

Open Pivot.xaml and check what's in the xaml.

Pivot.xaml

```xml
<Window x:Class="IgWpfWorkshop.Pivot"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IgWpfWorkshop"
        mc:Ignorable="d"
        Title="Pivot" Height="600" Width="1000"
        xmlns:vm="clr-namespace:IgWpfWorkshop.ViewModel">
    <Window.DataContext>
        <vm:PivotViewModel/>
    </Window.DataContext>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="150"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="250"/>
        </Grid.ColumnDefinitions>
        
    </Grid>
</Window>

```

This xaml has
 - PivotViewModel bound to this view
 - Grid Column/Row definitions to split and layout the screen

## Add Pivot Controls and a data chart

Open Pivot.xaml and add following controls to XAML.
 - XamPivotGird
 - XamPivotDataSelector
 - XamPivotDataSlicer
 - XamDataChart

## Layout Controls

Set Grid setting to layout controls you put.
```xml
...
<ig:XamPivotGrid Grid.Column="1" Grid.RowSpan="1" />
<ig:XamPivotDataSelector Grid.Column="2" Grid.RowSpan="2" />
<ig:XamPivotDataSlicer Grid.Column="0" Grid.RowSpan="2" />
<ig:XamDataChart Grid.Column="1" Grid.Row="1" />
...
```

## Configure XamPivotGrid

Bind XamPivtGrid to SalesFlatDataSource.

```xml
...
<ig:XamPivotGrid Grid.Column="1" Grid.RowSpan="1" DataSource="{Binding Path=SalesFlatDataSource}" />
...
```

## Configure XamPivotDataSelector

Bind XamPivotDataSelector to SalesFlatDataSource.

```xml
...
<ig:XamPivotDataSelector Grid.Column="2" Grid.RowSpan="2" DataSource="{Binding Path=SalesFlatDataSource}" />
...
```

## Configure XamPivotDataSlicer

Bind XamPivotDataSlicer to SalesFlatDataSource. Note that you should set SlicerProvider but not DataSource property.

```xml
...
<ig:XamPivotDataSlicer Grid.Column="0" Grid.RowSpan="2" SlicerProvider="{Binding Path=SalesFlatDataSource}"/>
...
```

## Configure XamPivotGrid

Bind XamDataChart to SalesFlatDataSource and configure some property reagrding OlapXAxis.

```xml
...
<ig:XamDataChart Grid.Column="1" Grid.Row="1" >
    <ig:XamDataChart.Axes>
        <ig:NumericYAxis Name="YAxis"></ig:NumericYAxis>
        <ig:OlapXAxis DataSource="{Binding Path=SalesFlatDataSource}" YAxis="{Binding ElementName=YAxis}" OlapAxisSource="Rows"></ig:OlapXAxis>
    </ig:XamDataChart.Axes>
</ig:XamDataChart>
...
```

## Check the result

Run the app and check the result.

![](../assets/03-02-01.png)

## Note
If you want to know more about pivot controls please check the following help topic.

[Using xamPivotGrid](https://www.infragistics.com/help/wpf/xampivotgrid-using-xampivotgrid)
