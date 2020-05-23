# XamDataGrid の設定
XamDataGrid はリッチな業務アプリケーションを簡単に作成するために、非常に多くのプロパティ設定が用意されています。実際にいくつかの機能を有効化して、グリッドUIをより機能的なものにしてみましょう。

## XamDataGrid におけるプロパティ設定

MainWindow.xaml を開いて、XamDataGridの列の設定や機能に関するプロパティ設定をいくつか行い、フィルタリングや列固定や集計などの機能を有効化してみます。以下のXAMLを参考に、編集してみましょう。

```xml
...
<Custom:XamDataGrid DataSource="{Binding Path=SalesRecords}" Grid.Row="1" Grid.ColumnSpan="2" >
    <Custom:XamDataGrid.FieldLayoutSettings>
        <Custom:FieldLayoutSettings AutoGenerateFields="False" FilterUIType="LabelIcons"/>
    </Custom:XamDataGrid.FieldLayoutSettings>
    <Custom:XamDataGrid.FieldSettings>
        <Custom:FieldSettings AllowRecordFiltering="True" FilterLabelIconDropDownType="MultiSelectExcelStyle" 
                                AllowSummaries="True" SummaryDisplayArea="InGroupByRecords" 
                                AllowFixing="NearOrFar"/>
    </Custom:XamDataGrid.FieldSettings>
    <!-- 列の設定 -->
    <Custom:XamDataGrid.FieldLayouts>
        <Custom:FieldLayout>
            <Custom:TextField Name="SalesPerson" Label="担当営業" />
            <Custom:DateTimeField Name="Date" Label="受注日" />
            <Custom:TextField Name="City" Label="都道府県" />
            <Custom:TextField Name="ProductName" Label="製品名" />
            <Custom:NumericField Name="NumberOfUnits" Label="数量" />
            <Custom:NumericField Name="UnitPrice" Label="単価" />
            <Custom:CurrencyField Name="AmountOfSale" Label="受注金額" />
        </Custom:FieldLayout>
    </Custom:XamDataGrid.FieldLayouts>
</Custom:XamDataGrid>
...
```

## 結果確認

アプリケーションを実行し、結果を確認します。

![](../assets/01-02-01.png)

## 備考
XamDataGrid には今回試した機能設定以外にも非常に多くの機能やUI表現を実現するための仕組みが用意されています。興味がある方は、以下のヘルプトピックより他にどんなことができるのか確認してください。

[XamDataGrid ヘルプ](https://jp.infragistics.com/help/wpf/xamdatagrid)

## Next
[02-00 チャート部品とControl Configulatorを利用したダッシュボードの作成](../02-Create-dashboard-with-Control-Configulator/02-00-Overview-of-Section2.md)
