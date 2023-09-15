﻿using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void PrintInvoice(Orders order, List<OrderDetail> data)
        {
            InvoiceReport report = new InvoiceReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(order.OrderID.ToString(), order.OrderDate, order.ContactName, order.Address, order.PostalCode, order.City, order.Country, order.Phone, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}