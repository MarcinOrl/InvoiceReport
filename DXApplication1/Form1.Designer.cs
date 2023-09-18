using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace DXApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            gridView2 = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            ordersBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new GridView();
            colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            dtToDate = new DevExpress.XtraEditors.DateEdit();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnLoad = new DevExpress.XtraEditors.SimpleButton();
            dtFromDate = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            dateEdit1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            dateEdit2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            orderDetailBindingSource = new System.Windows.Forms.BindingSource(components);
            sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            ((ISupportInitialize)gridView2).BeginInit();
            ((ISupportInitialize)gridControl1).BeginInit();
            ((ISupportInitialize)ordersBindingSource).BeginInit();
            ((ISupportInitialize)gridView1).BeginInit();
            ((ISupportInitialize)layoutControlItem6).BeginInit();
            ((ISupportInitialize)layoutControlItem5).BeginInit();
            ((ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((ISupportInitialize)dtToDate.Properties).BeginInit();
            ((ISupportInitialize)dtToDate.Properties.CalendarTimeProperties).BeginInit();
            ((ISupportInitialize)dtFromDate.Properties).BeginInit();
            ((ISupportInitialize)dtFromDate.Properties.CalendarTimeProperties).BeginInit();
            ((ISupportInitialize)Root).BeginInit();
            ((ISupportInitialize)dateEdit1).BeginInit();
            ((ISupportInitialize)layoutControlItem2).BeginInit();
            ((ISupportInitialize)layoutControlItem3).BeginInit();
            ((ISupportInitialize)layoutControlItem4).BeginInit();
            ((ISupportInitialize)emptySpaceItem1).BeginInit();
            ((ISupportInitialize)dateEdit2).BeginInit();
            ((ISupportInitialize)emptySpaceItem2).BeginInit();
            ((ISupportInitialize)layoutControlItem1).BeginInit();
            ((ISupportInitialize)orderDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            gridView2.GridControl = gridControl1;
            gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(gridColumn1, "gridColumn1");
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = ordersBindingSource;
            gridLevelNode1.LevelTemplate = gridView2;
            gridLevelNode1.RelationName = "Detail";
            gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            resources.ApplyResources(gridControl1, "gridControl1");
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, gridView2 });
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataSource = typeof(Orders);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCustomerID, colOrderID, colContactName, colAddress, colPostalCode, colCity, colCountry, colPhone, colOrderDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colCustomerID
            // 
            colCustomerID.FieldName = "CustomerID";
            colCustomerID.MinWidth = 25;
            colCustomerID.Name = "colCustomerID";
            resources.ApplyResources(colCustomerID, "colCustomerID");
            // 
            // colOrderID
            // 
            colOrderID.FieldName = "OrderID";
            colOrderID.MinWidth = 25;
            colOrderID.Name = "colOrderID";
            resources.ApplyResources(colOrderID, "colOrderID");
            // 
            // colContactName
            // 
            colContactName.FieldName = "ContactName";
            colContactName.MinWidth = 25;
            colContactName.Name = "colContactName";
            resources.ApplyResources(colContactName, "colContactName");
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.MinWidth = 25;
            colAddress.Name = "colAddress";
            resources.ApplyResources(colAddress, "colAddress");
            // 
            // colPostalCode
            // 
            colPostalCode.FieldName = "PostalCode";
            colPostalCode.MinWidth = 25;
            colPostalCode.Name = "colPostalCode";
            resources.ApplyResources(colPostalCode, "colPostalCode");
            // 
            // colCity
            // 
            colCity.FieldName = "City";
            colCity.MinWidth = 25;
            colCity.Name = "colCity";
            resources.ApplyResources(colCity, "colCity");
            // 
            // colCountry
            // 
            colCountry.FieldName = "Country";
            colCountry.MinWidth = 25;
            colCountry.Name = "colCountry";
            resources.ApplyResources(colCountry, "colCountry");
            // 
            // colPhone
            // 
            colPhone.FieldName = "Phone";
            colPhone.MinWidth = 25;
            colPhone.Name = "colPhone";
            resources.ApplyResources(colPhone, "colPhone");
            // 
            // colOrderDate
            // 
            colOrderDate.FieldName = "OrderDate";
            colOrderDate.MinWidth = 25;
            colOrderDate.Name = "colOrderDate";
            resources.ApplyResources(colOrderDate, "colOrderDate");
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Location = new System.Drawing.Point(0, 428);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(795, 25);
            layoutControlItem6.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Location = new System.Drawing.Point(0, 428);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(795, 25);
            layoutControlItem5.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(dtToDate);
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(btnPrint);
            layoutControl1.Controls.Add(btnLoad);
            layoutControl1.Controls.Add(dtFromDate);
            resources.ApplyResources(layoutControl1, "layoutControl1");
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 210, 812, 500);
            layoutControl1.Root = Root;
            // 
            // simpleButton1
            // 
            resources.ApplyResources(simpleButton1, "simpleButton1");
            simpleButton1.Name = "simpleButton1";
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.Click += simpleButton1_Click;
            // 
            // dtToDate
            // 
            resources.ApplyResources(dtToDate, "dtToDate");
            dtToDate.Name = "dtToDate";
            dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtToDate.Properties.Buttons")) });
            dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtToDate.Properties.CalendarTimeProperties.Buttons")) });
            dtToDate.StyleController = layoutControl1;
            // 
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.Name = "btnPrint";
            btnPrint.StyleController = layoutControl1;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnLoad
            // 
            resources.ApplyResources(btnLoad, "btnLoad");
            btnLoad.Name = "btnLoad";
            btnLoad.StyleController = layoutControl1;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtFromDate
            // 
            resources.ApplyResources(dtFromDate, "dtFromDate");
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtFromDate.Properties.Buttons")) });
            dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtFromDate.Properties.CalendarTimeProperties.Buttons")) });
            dtFromDate.StyleController = layoutControl1;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { dateEdit1, layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem1, dateEdit2, emptySpaceItem2, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(916, 482);
            Root.TextVisible = false;
            // 
            // dateEdit1
            // 
            dateEdit1.Control = dtFromDate;
            dateEdit1.Location = new System.Drawing.Point(0, 0);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Size = new System.Drawing.Size(225, 31);
            resources.ApplyResources(dateEdit1, "dateEdit1");
            dateEdit1.TextSize = new System.Drawing.Size(49, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnLoad;
            layoutControlItem2.Location = new System.Drawing.Point(793, 431);
            layoutControlItem2.MaxSize = new System.Drawing.Size(103, 31);
            layoutControlItem2.MinSize = new System.Drawing.Size(103, 31);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(103, 31);
            layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnPrint;
            layoutControlItem3.Location = new System.Drawing.Point(690, 431);
            layoutControlItem3.MaxSize = new System.Drawing.Size(103, 31);
            layoutControlItem3.MinSize = new System.Drawing.Size(103, 31);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(103, 31);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = gridControl1;
            layoutControlItem4.Location = new System.Drawing.Point(0, 31);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(896, 400);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 431);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(690, 31);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dateEdit2
            // 
            dateEdit2.Control = dtToDate;
            dateEdit2.Location = new System.Drawing.Point(225, 0);
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Size = new System.Drawing.Size(233, 31);
            resources.ApplyResources(dateEdit2, "dateEdit2");
            dateEdit2.TextSize = new System.Drawing.Size(49, 16);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(690, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(206, 31);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = simpleButton1;
            layoutControlItem1.Location = new System.Drawing.Point(458, 0);
            layoutControlItem1.MinSize = new System.Drawing.Size(91, 31);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(232, 31);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(OrderDetail);
            // 
            // sqlDataSource1
            // 
            sqlDataSource1.Name = "sqlDataSource1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Name = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)gridView2).EndInit();
            ((ISupportInitialize)gridControl1).EndInit();
            ((ISupportInitialize)ordersBindingSource).EndInit();
            ((ISupportInitialize)gridView1).EndInit();
            ((ISupportInitialize)layoutControlItem6).EndInit();
            ((ISupportInitialize)layoutControlItem5).EndInit();
            ((ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((ISupportInitialize)dtToDate.Properties.CalendarTimeProperties).EndInit();
            ((ISupportInitialize)dtToDate.Properties).EndInit();
            ((ISupportInitialize)dtFromDate.Properties.CalendarTimeProperties).EndInit();
            ((ISupportInitialize)dtFromDate.Properties).EndInit();
            ((ISupportInitialize)Root).EndInit();
            ((ISupportInitialize)dateEdit1).EndInit();
            ((ISupportInitialize)layoutControlItem2).EndInit();
            ((ISupportInitialize)layoutControlItem3).EndInit();
            ((ISupportInitialize)layoutControlItem4).EndInit();
            ((ISupportInitialize)emptySpaceItem1).EndInit();
            ((ISupportInitialize)dateEdit2).EndInit();
            ((ISupportInitialize)emptySpaceItem2).EndInit();
            ((ISupportInitialize)layoutControlItem1).EndInit();
            ((ISupportInitialize)orderDetailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem dateEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem dateEdit2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

