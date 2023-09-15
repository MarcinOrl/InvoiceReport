namespace DXApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            dtToDate = new DevExpress.XtraEditors.DateEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            ordersBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtToDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtToDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFromDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFromDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            SuspendLayout();
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
            layoutControl1.Controls.Add(dtToDate);
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(btnPrint);
            layoutControl1.Controls.Add(btnLoad);
            layoutControl1.Controls.Add(dtFromDate);
            resources.ApplyResources(layoutControl1, "layoutControl1");
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            // 
            // dtToDate
            // 
            resources.ApplyResources(dtToDate, "dtToDate");
            dtToDate.Name = "dtToDate";
            dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtToDate.Properties.Buttons")) });
            dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton((DevExpress.XtraEditors.Controls.ButtonPredefines)resources.GetObject("dtToDate.Properties.CalendarTimeProperties.Buttons")) });
            dtToDate.StyleController = layoutControl1;
            // 
            // gridControl1
            // 
            gridControl1.DataSource = ordersBindingSource;
            resources.ApplyResources(gridControl1, "gridControl1");
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataSource = typeof(Orders);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOrderID, colContactName, colAddress, colPostalCode, colCity, colPhone, colOrderDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
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
            resources.ApplyResources(colCity, "colCity");
            colCity.FieldName = "City";
            colCity.MinWidth = 25;
            colCity.Name = "colCity";
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
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { dateEdit1, layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem1, dateEdit2, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(815, 448);
            Root.TextVisible = false;
            // 
            // dateEdit1
            // 
            dateEdit1.Control = dtFromDate;
            dateEdit1.Location = new System.Drawing.Point(0, 0);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Size = new System.Drawing.Size(188, 26);
            resources.ApplyResources(dateEdit1, "dateEdit1");
            dateEdit1.TextSize = new System.Drawing.Size(49, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnLoad;
            layoutControlItem2.Location = new System.Drawing.Point(692, 397);
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
            layoutControlItem3.Location = new System.Drawing.Point(589, 397);
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
            layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(795, 371);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 397);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(589, 31);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dateEdit2
            // 
            dateEdit2.Control = dtToDate;
            dateEdit2.Location = new System.Drawing.Point(188, 0);
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Size = new System.Drawing.Size(181, 26);
            resources.ApplyResources(dateEdit2, "dateEdit2");
            dateEdit2.TextSize = new System.Drawing.Size(49, 16);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(369, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(426, 26);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtToDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtToDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFromDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFromDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem dateEdit2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
    }
}

