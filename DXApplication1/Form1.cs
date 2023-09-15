using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string query = "select d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice from [Order Details] d inner join Products p on d.ProductID = p.ProductID" + $" where d.OrderID = '{obj.OrderID}'";
                        List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();
                        using (frmPrint frm = new frmPrint())
                        {
                            frm.PrintInvoice(obj, list);
                            frm.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select o.OrderID, c.CustomerID, c.ContactName, c.Address, c.PostalCode, c.City, c.Country, c.Phone, o.OrderDate" + " from Orders o inner join Customers c on o.CustomerID = c.CustomerID" + $" where o.OrderDate between convert(varchar(25),'{dtFromDate.EditValue}',103) and convert(varchar(25), '{dtToDate.EditValue}',103)";
                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            }
        }
    }
}
