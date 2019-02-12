# Layout window with XamLayoutManager

## Put and configure XamTileManager

Open Dashboard.xaml and put XamTileManager from the toolbox on the designer.

![](../assets/02-02-01.png)

Add some tiles for dashboard widgets in XamTileManager and configure them as below. Just copy & paste the code below to your project, it's not so important writing all code by hand here.

Dashboard.xaml

```xml
...
<Grid>
    <ig:XamTileManager>
        <ig:XamTileManager.NormalModeSettings>
            <ig:NormalModeSettings TileLayoutOrder="UseExplicitRowColumnOnTile"
                                    VerticalTileAreaAlignment="Stretch"
                                    HorizontalTileAreaAlignment="Stretch">
                <ig:NormalModeSettings.TileConstraints>
                    <ig:TileConstraints PreferredWidth="400" PreferredHeight="300"/>
                </ig:NormalModeSettings.TileConstraints>
            </ig:NormalModeSettings>
        </ig:XamTileManager.NormalModeSettings>

        <ig:XamTile
            Header="Sales Amount By Product in this year"
            ig:XamTileManager.Column="0"
            ig:XamTileManager.Row="0" 
            ig:XamTileManager.ColumnSpan="1"
            ig:XamTileManager.RowSpan="1">
        </ig:XamTile>

        <ig:XamTile
            Header="Total Sales Amount in this year"
            ig:XamTileManager.Column="1"
            ig:XamTileManager.Row="0" 
            ig:XamTileManager.ColumnSpan="1"
            ig:XamTileManager.RowSpan="1">
        </ig:XamTile>

        <ig:XamTile
            Header="Top 30 large deals in this year"
            ig:XamTileManager.Column="2"
            ig:XamTileManager.Row="0" 
            ig:XamTileManager.ColumnSpan="1"
            ig:XamTileManager.RowSpan="2">
        </ig:XamTile>

        <ig:XamTile
            Header="Monthly Sales Amount in this year"
            ig:XamTileManager.Column="0"
            ig:XamTileManager.Row="1" 
            ig:XamTileManager.ColumnSpan="2"
            ig:XamTileManager.RowSpan="1" >
        </ig:XamTile>
    </ig:XamTileManager>
</Grid>
...
```

XamTileManager has 4 tiles which are for
 - Displaying Sales Amount By Product in a **PieChart**
 - Displaying Total Sales Amount in **BulletGraph**
 - Displaying Top 30 large deals in **Grid**
 - Displaying Monthly Sales Amount in **Chart**

## Check the result

Run the app and check the result. You can change the tile layout by dragging & dropping or clicking the tile icon on right side of the tile header.

![](../assets/02-02-02.png)

## Note
You can learn more about XamTileManager in the help topic.

[Using xamTileManager](https://www.infragistics.com/help/wpf/xamtilemanager-using-xamtilemanager)

Infragistics WPF contains another nice layout control named XamDockManager which provides experience like Visual Studio docking pane. If you have some time to give it try, check the help topic and try it!

[Using xamDockManager](https://www.infragistics.com/help/wpf/xamdockmanager-using-xamdockmanager)



## Next
[02-03 Configure PieChart](02-03-Configure-PieChart.md)
