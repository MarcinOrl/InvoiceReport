using DevExpress.DataAccess.ObjectBinding;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DXApplication1
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void InitData(string orderid, DateTime orderdate, string customer, string address, string postalcode, string city, string phone, List<OrderDetail> data)
        {
            pOrderID.Value = orderid;
            pDate.Value = orderdate.Date;
            pCustomerName.Value = customer;
            pAddress.Value = address;
            pPostalCode.Value = postalcode;
            pCity.Value = city;
            pPhone.Value = phone;
            objectDataSource1.DataSource = data;
        }
    }
}
