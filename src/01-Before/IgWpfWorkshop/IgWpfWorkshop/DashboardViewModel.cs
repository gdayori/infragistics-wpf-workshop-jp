﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Samples.Data.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgWpfWorkshop.ViewModel
{
    class DashboardViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DashboardViewModel()
        {
            //Get all data required in the dashboard
            SalesDataSample salesDataSample = new SalesDataSample();
            salesAmountByProduct = salesDataSample.SalesAmountByProductData;
            top30LargeDeals = salesDataSample.Top30LargeDeals;
            totalSalesThisYear = salesDataSample.TotalSalesThisYear / 1000000;
            salesTargetThisYear = salesDataSample.SalesTargetThisYear / 1000000;
            monthlySalesAmount = salesDataSample.MonthlySalesAmount;
        }


        //Sales Amount By Product
        private ObservableCollection<SalesAmountByProduct> salesAmountByProduct;
        public ObservableCollection<SalesAmountByProduct> SalesAmountByProductData
        {
            get { return salesAmountByProduct; }
        }

        //Sales Target This Year
        private int salesTargetThisYear;
        public int SalesTargetThisYear
        {
            get { return salesTargetThisYear; }
        }

        //Amount Sales This Year
        private int totalSalesThisYear;
        public int TotalSalesThisYear
        {
            get { return totalSalesThisYear; }
        }

        //Large Deals This Year
        private ObservableCollection<Sale> top30LargeDeals;
        public ObservableCollection<Sale> Top30LargeDeals
        {
            get { return top30LargeDeals; }
        }

        //Monthly Sales Amount
        private ObservableCollection<MonthlySale> monthlySalesAmount;
        public ObservableCollection<MonthlySale> MonthlySalesAmount
        {
            get { return monthlySalesAmount; }
        }
    }
}
