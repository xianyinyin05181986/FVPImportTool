namespace FairValueProImportTool
{
    partial class FairValueProHelper
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (_Importer != null)
                {
                    _Importer.Dispose();
                    _Importer = null;
                }
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings2 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions2 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FairValueProHelper));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectRenameIDButton = new System.Windows.Forms.Button();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.ClientlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tb_client_Oid = new System.Windows.Forms.TextBox();
            this.New_And_Old_gridControl = new DevExpress.XtraGrid.GridControl();
            this.AssetId_Old_New = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Test = new System.Windows.Forms.Button();
            this.RenameProgressBar = new System.Windows.Forms.ProgressBar();
            this.bt_Process = new System.Windows.Forms.Button();
            this.bt_Refresh_grid = new System.Windows.Forms.Button();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tableLayoutPanelx = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Photo_Command_Grid = new System.Windows.Forms.DataGridView();
            this.assetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excelDataSource2 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_AssetID = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.label_P2 = new System.Windows.Forms.Label();
            this.label_P3 = new System.Windows.Forms.Label();
            this.label_P4 = new System.Windows.Forms.Label();
            this.textBox_AssetId = new System.Windows.Forms.TextBox();
            this.textBox_P1 = new System.Windows.Forms.TextBox();
            this.textBox_P2 = new System.Windows.Forms.TextBox();
            this.textBox_P3 = new System.Windows.Forms.TextBox();
            this.textBox_P4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.PhotoImportProgressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox_SelectExecl_Import = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SelectFolder_Import = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Import = new System.Windows.Forms.Button();
            this.richTextBox_Progress_Import = new System.Windows.Forms.RichTextBox();
            this.Export = new System.Windows.Forms.Button();
            this.Validate = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tx_Prefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.ComboBox();
            this.fairValueProClientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientListDataSet = new FairValueProImportTool.ClientListDataSet();
            this.fairValueProClientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox_Client_Oid = new System.Windows.Forms.RichTextBox();
            this.clientObject = new FairValueProImportTool.ClientObject();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fairValueProClientTableAdapter = new FairValueProImportTool.ClientObjectTableAdapters.FairValueProClientTableAdapter();
            this.SelectRenameFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RenameBackGroudWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog_Import = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_Import = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker_Export = new System.ComponentModel.BackgroundWorker();
            this.fairValueProClientTableAdapter1 = new FairValueProImportTool.ClientListDataSetTableAdapters.FairValueProClientTableAdapter();
            this.folderBrowserDialog_Output_Photos = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker_Import = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_And_Old_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.tableLayoutPanelx.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_Command_Grid)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fairValueProClientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairValueProClientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientObject)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AccessibleName = "Main";
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(this.barButtonItem1);
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1139, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Exit";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.tabFormDefaultManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1139, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 498);
            this.barDockControlBottom.Size = new System.Drawing.Size(1139, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1139, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.xtraScrollableControl2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "AssetId Rename";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.tableLayoutPanel2);
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 50);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(1139, 448);
            this.xtraScrollableControl2.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 990F));
            this.tableLayoutPanel2.Controls.Add(this.SelectRenameIDButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_filename, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClientlookUpEdit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_client_Oid, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.New_And_Old_gridControl, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70615F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.29385F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 500);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectRenameIDButton
            // 
            this.SelectRenameIDButton.Location = new System.Drawing.Point(3, 3);
            this.SelectRenameIDButton.Name = "SelectRenameIDButton";
            this.SelectRenameIDButton.Size = new System.Drawing.Size(143, 36);
            this.SelectRenameIDButton.TabIndex = 0;
            this.SelectRenameIDButton.Text = "Select Rename ID File";
            this.SelectRenameIDButton.UseVisualStyleBackColor = true;
            this.SelectRenameIDButton.Click += new System.EventHandler(this.SelectRenameIDButton_Click);
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(152, 3);
            this.tb_filename.Multiline = true;
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(802, 36);
            this.tb_filename.TabIndex = 1;
            // 
            // ClientlookUpEdit
            // 
            this.ClientlookUpEdit.Location = new System.Drawing.Point(3, 52);
            this.ClientlookUpEdit.MenuManager = this.tabFormDefaultManager1;
            this.ClientlookUpEdit.Name = "ClientlookUpEdit";
            this.ClientlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ClientlookUpEdit.Properties.DisplayMember = "Name";
            this.ClientlookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.ClientlookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.ClientlookUpEdit.Properties.ValueMember = "Oid";
            this.ClientlookUpEdit.Size = new System.Drawing.Size(143, 20);
            this.ClientlookUpEdit.TabIndex = 2;
            // 
            // tb_client_Oid
            // 
            this.tb_client_Oid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_client_Oid.Location = new System.Drawing.Point(152, 52);
            this.tb_client_Oid.Name = "tb_client_Oid";
            this.tb_client_Oid.Size = new System.Drawing.Size(984, 20);
            this.tb_client_Oid.TabIndex = 3;
            // 
            // New_And_Old_gridControl
            // 
            this.New_And_Old_gridControl.DataSource = this.AssetId_Old_New;
            this.New_And_Old_gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.New_And_Old_gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.New_And_Old_gridControl.Location = new System.Drawing.Point(152, 85);
            this.New_And_Old_gridControl.MainView = this.gridView1;
            this.New_And_Old_gridControl.MenuManager = this.tabFormDefaultManager1;
            this.New_And_Old_gridControl.Name = "New_And_Old_gridControl";
            this.New_And_Old_gridControl.Size = new System.Drawing.Size(984, 412);
            this.New_And_Old_gridControl.TabIndex = 4;
            this.New_And_Old_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // AssetId_Old_New
            // 
            this.AssetId_Old_New.FileName = "D:\\Test Data\\RenameAssetID.xlsx";
            this.AssetId_Old_New.Name = "AssetId_Old_New";
            this.AssetId_Old_New.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9Ik9sZCIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJOZXciIFR5c" +
    "GU9IlN0cmluZyIgLz48L1ZpZXc+";
            fieldInfo6.Name = "Old";
            fieldInfo6.Type = typeof(string);
            fieldInfo7.Name = "New";
            fieldInfo7.Type = typeof(string);
            this.AssetId_Old_New.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo6,
            fieldInfo7});
            excelWorksheetSettings2.CellRange = null;
            excelWorksheetSettings2.WorksheetName = "Sheet1";
            excelSourceOptions2.ImportSettings = excelWorksheetSettings2;
            this.AssetId_Old_New.SourceOptions = excelSourceOptions2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOld,
            this.colNew});
            this.gridView1.GridControl = this.New_And_Old_gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colOld
            // 
            this.colOld.FieldName = "Old";
            this.colOld.Name = "colOld";
            this.colOld.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colOld.Visible = true;
            this.colOld.VisibleIndex = 0;
            // 
            // colNew
            // 
            this.colNew.FieldName = "New";
            this.colNew.Name = "colNew";
            this.colNew.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNew.Visible = true;
            this.colNew.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Test);
            this.panel1.Controls.Add(this.RenameProgressBar);
            this.panel1.Controls.Add(this.bt_Process);
            this.panel1.Controls.Add(this.bt_Refresh_grid);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 361);
            this.panel1.TabIndex = 5;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(24, 224);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 3;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // RenameProgressBar
            // 
            this.RenameProgressBar.Location = new System.Drawing.Point(9, 121);
            this.RenameProgressBar.Name = "RenameProgressBar";
            this.RenameProgressBar.Size = new System.Drawing.Size(131, 23);
            this.RenameProgressBar.TabIndex = 2;
            // 
            // bt_Process
            // 
            this.bt_Process.Location = new System.Drawing.Point(3, 77);
            this.bt_Process.Name = "bt_Process";
            this.bt_Process.Size = new System.Drawing.Size(140, 42);
            this.bt_Process.TabIndex = 1;
            this.bt_Process.Text = "Process";
            this.bt_Process.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh_grid
            // 
            this.bt_Refresh_grid.Location = new System.Drawing.Point(3, 3);
            this.bt_Refresh_grid.Name = "bt_Refresh_grid";
            this.bt_Refresh_grid.Size = new System.Drawing.Size(140, 43);
            this.bt_Refresh_grid.TabIndex = 0;
            this.bt_Refresh_grid.Text = "Refresh";
            this.bt_Refresh_grid.UseVisualStyleBackColor = true;
            this.bt_Refresh_grid.Click += new System.EventHandler(this.SelectRenameIDButton_Click);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Import Photos";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.tableLayoutPanelx);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 50);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1139, 448);
            this.xtraScrollableControl1.TabIndex = 23;
            // 
            // tableLayoutPanelx
            // 
            this.tableLayoutPanelx.ColumnCount = 2;
            this.tableLayoutPanelx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.70541F));
            this.tableLayoutPanelx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.29459F));
            this.tableLayoutPanelx.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanelx.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelx.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanelx.Controls.Add(this.richTextBox_SelectExecl_Import, 1, 0);
            this.tableLayoutPanelx.Controls.Add(this.richTextBox_SelectFolder_Import, 1, 1);
            this.tableLayoutPanelx.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanelx.Location = new System.Drawing.Point(12, 8);
            this.tableLayoutPanelx.Name = "tableLayoutPanelx";
            this.tableLayoutPanelx.RowCount = 3;
            this.tableLayoutPanelx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.87218F));
            this.tableLayoutPanelx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.12782F));
            this.tableLayoutPanelx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanelx.Size = new System.Drawing.Size(1127, 428);
            this.tableLayoutPanelx.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Photo_Command_Grid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(179, 82);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.3553F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.6447F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(944, 343);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Photo_Command_Grid
            // 
            this.Photo_Command_Grid.AutoGenerateColumns = false;
            this.Photo_Command_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Photo_Command_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Photo_Command_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetIDDataGridViewTextBoxColumn,
            this.photo1DataGridViewTextBoxColumn,
            this.photo2DataGridViewTextBoxColumn,
            this.photo3DataGridViewTextBoxColumn,
            this.photo4DataGridViewTextBoxColumn});
            this.Photo_Command_Grid.DataSource = this.excelDataSource2;
            this.Photo_Command_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo_Command_Grid.Location = new System.Drawing.Point(3, 86);
            this.Photo_Command_Grid.Name = "Photo_Command_Grid";
            this.Photo_Command_Grid.Size = new System.Drawing.Size(938, 254);
            this.Photo_Command_Grid.TabIndex = 2;
            // 
            // assetIDDataGridViewTextBoxColumn
            // 
            this.assetIDDataGridViewTextBoxColumn.DataPropertyName = "Asset ID";
            this.assetIDDataGridViewTextBoxColumn.HeaderText = "Asset ID";
            this.assetIDDataGridViewTextBoxColumn.Name = "assetIDDataGridViewTextBoxColumn";
            this.assetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photo1DataGridViewTextBoxColumn
            // 
            this.photo1DataGridViewTextBoxColumn.DataPropertyName = "Photo 1";
            this.photo1DataGridViewTextBoxColumn.HeaderText = "Photo 1";
            this.photo1DataGridViewTextBoxColumn.Name = "photo1DataGridViewTextBoxColumn";
            this.photo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photo2DataGridViewTextBoxColumn
            // 
            this.photo2DataGridViewTextBoxColumn.DataPropertyName = "Photo 2";
            this.photo2DataGridViewTextBoxColumn.HeaderText = "Photo 2";
            this.photo2DataGridViewTextBoxColumn.Name = "photo2DataGridViewTextBoxColumn";
            this.photo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photo3DataGridViewTextBoxColumn
            // 
            this.photo3DataGridViewTextBoxColumn.DataPropertyName = "Photo 3";
            this.photo3DataGridViewTextBoxColumn.HeaderText = "Photo 3";
            this.photo3DataGridViewTextBoxColumn.Name = "photo3DataGridViewTextBoxColumn";
            this.photo3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photo4DataGridViewTextBoxColumn
            // 
            this.photo4DataGridViewTextBoxColumn.DataPropertyName = "Photo 4";
            this.photo4DataGridViewTextBoxColumn.HeaderText = "Photo 4";
            this.photo4DataGridViewTextBoxColumn.Name = "photo4DataGridViewTextBoxColumn";
            this.photo4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // excelDataSource2
            // 
            this.excelDataSource2.FileName = "D:\\Import Tasks\\Test\\Command.xlsx";
            this.excelDataSource2.Name = "excelDataSource2";
            this.excelDataSource2.ResultSchemaSerializable = resources.GetString("excelDataSource2.ResultSchemaSerializable");
            fieldInfo1.Name = "Asset ID";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Photo 1";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "Photo 2";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "Photo 3";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "Photo 4";
            fieldInfo5.Type = typeof(string);
            this.excelDataSource2.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource2.SourceOptions = excelSourceOptions1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.76035F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(933, 77);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.67442F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.32558F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel7.Controls.Add(this.Label_AssetID, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label_P1, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label_P2, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label_P3, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label_P4, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox_AssetId, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_P1, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_P2, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_P3, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox_P4, 5, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(927, 44);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // Label_AssetID
            // 
            this.Label_AssetID.AutoSize = true;
            this.Label_AssetID.Location = new System.Drawing.Point(35, 0);
            this.Label_AssetID.Name = "Label_AssetID";
            this.Label_AssetID.Size = new System.Drawing.Size(47, 13);
            this.Label_AssetID.TabIndex = 0;
            this.Label_AssetID.Text = "Asset Id";
            this.Label_AssetID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Location = new System.Drawing.Point(185, 0);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(44, 13);
            this.label_P1.TabIndex = 1;
            this.label_P1.Text = "Photo 1";
            this.label_P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.Location = new System.Drawing.Point(366, 0);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(44, 13);
            this.label_P2.TabIndex = 2;
            this.label_P2.Text = "Photo 2";
            this.label_P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_P3
            // 
            this.label_P3.AutoSize = true;
            this.label_P3.Location = new System.Drawing.Point(543, 0);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(44, 13);
            this.label_P3.TabIndex = 3;
            this.label_P3.Text = "Photo 3";
            this.label_P3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_P4
            // 
            this.label_P4.AutoSize = true;
            this.label_P4.Location = new System.Drawing.Point(723, 0);
            this.label_P4.Name = "label_P4";
            this.label_P4.Size = new System.Drawing.Size(44, 13);
            this.label_P4.TabIndex = 4;
            this.label_P4.Text = "Photo 4";
            this.label_P4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_AssetId
            // 
            this.textBox_AssetId.Location = new System.Drawing.Point(35, 18);
            this.textBox_AssetId.Name = "textBox_AssetId";
            this.textBox_AssetId.Size = new System.Drawing.Size(144, 21);
            this.textBox_AssetId.TabIndex = 5;
            this.textBox_AssetId.Text = "Asset ID";
            // 
            // textBox_P1
            // 
            this.textBox_P1.Location = new System.Drawing.Point(185, 18);
            this.textBox_P1.Name = "textBox_P1";
            this.textBox_P1.Size = new System.Drawing.Size(175, 21);
            this.textBox_P1.TabIndex = 6;
            this.textBox_P1.Text = "Photo 1";
            // 
            // textBox_P2
            // 
            this.textBox_P2.Location = new System.Drawing.Point(366, 18);
            this.textBox_P2.Name = "textBox_P2";
            this.textBox_P2.Size = new System.Drawing.Size(171, 21);
            this.textBox_P2.TabIndex = 7;
            this.textBox_P2.Text = "Photo 2";
            // 
            // textBox_P3
            // 
            this.textBox_P3.Location = new System.Drawing.Point(543, 18);
            this.textBox_P3.Name = "textBox_P3";
            this.textBox_P3.Size = new System.Drawing.Size(174, 21);
            this.textBox_P3.TabIndex = 8;
            this.textBox_P3.Text = "Photo 3";
            // 
            // textBox_P4
            // 
            this.textBox_P4.Location = new System.Drawing.Point(723, 18);
            this.textBox_P4.Name = "textBox_P4";
            this.textBox_P4.Size = new System.Drawing.Size(166, 21);
            this.textBox_P4.TabIndex = 9;
            this.textBox_P4.Text = "Photo 4";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9708738F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.02913F));
            this.tableLayoutPanel8.Controls.Add(this.PhotoImportProgressBar, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(927, 21);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // PhotoImportProgressBar
            // 
            this.PhotoImportProgressBar.Location = new System.Drawing.Point(11, 3);
            this.PhotoImportProgressBar.Name = "PhotoImportProgressBar";
            this.PhotoImportProgressBar.Size = new System.Drawing.Size(856, 15);
            this.PhotoImportProgressBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Excel File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select Photo Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox_SelectExecl_Import
            // 
            this.richTextBox_SelectExecl_Import.Location = new System.Drawing.Point(179, 3);
            this.richTextBox_SelectExecl_Import.Name = "richTextBox_SelectExecl_Import";
            this.richTextBox_SelectExecl_Import.Size = new System.Drawing.Size(945, 30);
            this.richTextBox_SelectExecl_Import.TabIndex = 3;
            this.richTextBox_SelectExecl_Import.Text = "";
            this.richTextBox_SelectExecl_Import.TextChanged += new System.EventHandler(this.ExcelFilerichTextBox_TextChanged);
            // 
            // richTextBox_SelectFolder_Import
            // 
            this.richTextBox_SelectFolder_Import.Location = new System.Drawing.Point(179, 42);
            this.richTextBox_SelectFolder_Import.Name = "richTextBox_SelectFolder_Import";
            this.richTextBox_SelectFolder_Import.Size = new System.Drawing.Size(945, 31);
            this.richTextBox_SelectFolder_Import.TabIndex = 4;
            this.richTextBox_SelectFolder_Import.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bt_Import, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.richTextBox_Progress_Import, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Export, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.Validate, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Client, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.richTextBox_Client_Oid, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(170, 343);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // bt_Import
            // 
            this.bt_Import.Location = new System.Drawing.Point(3, 278);
            this.bt_Import.Name = "bt_Import";
            this.bt_Import.Size = new System.Drawing.Size(164, 36);
            this.bt_Import.TabIndex = 0;
            this.bt_Import.Text = "Import";
            this.bt_Import.UseVisualStyleBackColor = true;
            this.bt_Import.Click += new System.EventHandler(this.bt_Import_Click);
            // 
            // richTextBox_Progress_Import
            // 
            this.richTextBox_Progress_Import.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Progress_Import.Name = "richTextBox_Progress_Import";
            this.richTextBox_Progress_Import.Size = new System.Drawing.Size(164, 63);
            this.richTextBox_Progress_Import.TabIndex = 2;
            this.richTextBox_Progress_Import.Text = "";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(3, 236);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(164, 36);
            this.Export.TabIndex = 5;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Validate
            // 
            this.Validate.Location = new System.Drawing.Point(3, 189);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(164, 36);
            this.Validate.TabIndex = 1;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65854F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34146F));
            this.tableLayoutPanel5.Controls.Add(this.tx_Prefix, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 156);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(164, 27);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tx_Prefix
            // 
            this.tx_Prefix.Location = new System.Drawing.Point(50, 3);
            this.tx_Prefix.Name = "tx_Prefix";
            this.tx_Prefix.Size = new System.Drawing.Size(100, 21);
            this.tx_Prefix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix\r\n";
            // 
            // Client
            // 
            this.Client.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fairValueProClientBindingSource2, "Oid", true));
            this.Client.DataSource = this.fairValueProClientBindingSource1;
            this.Client.DisplayMember = "Name";
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(3, 72);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(164, 21);
            this.Client.TabIndex = 3;
            this.Client.ValueMember = "Oid";
            this.Client.SelectedValueChanged += new System.EventHandler(this.Client_SelectedValueChanged);
            // 
            // fairValueProClientBindingSource2
            // 
            this.fairValueProClientBindingSource2.DataMember = "FairValueProClient";
            this.fairValueProClientBindingSource2.DataSource = this.clientListDataSet;
            // 
            // clientListDataSet
            // 
            this.clientListDataSet.DataSetName = "ClientListDataSet";
            this.clientListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fairValueProClientBindingSource1
            // 
            this.fairValueProClientBindingSource1.DataMember = "FairValueProClient";
            this.fairValueProClientBindingSource1.DataSource = this.clientListDataSet;
            this.fairValueProClientBindingSource1.Sort = "Name";
            // 
            // richTextBox_Client_Oid
            // 
            this.richTextBox_Client_Oid.Location = new System.Drawing.Point(3, 98);
            this.richTextBox_Client_Oid.Name = "richTextBox_Client_Oid";
            this.richTextBox_Client_Oid.Size = new System.Drawing.Size(164, 52);
            this.richTextBox_Client_Oid.TabIndex = 4;
            this.richTextBox_Client_Oid.Text = "";
            // 
            // clientObject
            // 
            this.clientObject.DataSetName = "ClientObject";
            this.clientObject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "me5cd2w04s.database.windows.net_fvp-database_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ClientName";
            table1.MetaSerializable = "30|30|125|240";
            table1.Name = "PhotoAssetView";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "JobName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "AssetId";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "AssetOid";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "AssetRegisterOid";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "ClientOid";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Distinct = true;
            selectQuery1.FilterString = "";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "PhotoAssetView";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // fairValueProClientTableAdapter
            // 
            this.fairValueProClientTableAdapter.ClearBeforeFill = true;
            // 
            // SelectRenameFileDialog
            // 
            this.SelectRenameFileDialog.FileName = "SelectRenameFile";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(926, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(8, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // RenameBackGroudWorker
            // 
            this.RenameBackGroudWorker.WorkerReportsProgress = true;
            // 
            // openFileDialog_Import
            // 
            this.openFileDialog_Import.FileName = "openFileDialog1";
            // 
            // backgroundWorker_Export
            // 
            this.backgroundWorker_Export.WorkerReportsProgress = true;
            this.backgroundWorker_Export.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Export_DoWork);
            this.backgroundWorker_Export.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Export_ProgressChanged);
            this.backgroundWorker_Export.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Export_RunWorkerCompleted);
            // 
            // fairValueProClientTableAdapter1
            // 
            this.fairValueProClientTableAdapter1.ClearBeforeFill = true;
            // 
            // folderBrowserDialog_Output_Photos
            // 
            this.folderBrowserDialog_Output_Photos.Description = "Select the destination Path for output photo";
            // 
            // backgroundWorker_Import
            // 
            this.backgroundWorker_Import.WorkerReportsProgress = true;
            this.backgroundWorker_Import.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Import_DoWork);
            this.backgroundWorker_Import.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Import_ProgressChanged);
            this.backgroundWorker_Import.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Import_RunWorkerCompleted);
            // 
            // FairValueProHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 498);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tabFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "FairValueProHelper";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "FairValueProHelper";
            this.Load += new System.EventHandler(this.FairValueProHelper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_And_Old_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.tableLayoutPanelx.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Photo_Command_Grid)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fairValueProClientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairValueProClientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private ClientObject clientObject;
        private ClientObjectTableAdapters.FairValueProClientTableAdapter fairValueProClientTableAdapter;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private System.Windows.Forms.OpenFileDialog SelectRenameFileDialog;
        private System.Windows.Forms.Button SelectRenameIDButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_filename;
        private DevExpress.XtraEditors.LookUpEdit ClientlookUpEdit;
        private System.Windows.Forms.TextBox tb_client_Oid;
        private DevExpress.XtraGrid.GridControl New_And_Old_gridControl;
        private DevExpress.DataAccess.Excel.ExcelDataSource AssetId_Old_New;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOld;
        private DevExpress.XtraGrid.Columns.GridColumn colNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Process;
        private System.Windows.Forms.Button bt_Refresh_grid;
        private System.Windows.Forms.ProgressBar RenameProgressBar;
        private System.ComponentModel.BackgroundWorker RenameBackGroudWorker;
        private System.Windows.Forms.Button Test;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar PhotoImportProgressBar;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox_SelectExecl_Import;
        private System.Windows.Forms.RichTextBox richTextBox_SelectFolder_Import;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bt_Import;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Import;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Import;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Export;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_Prefix;
        private System.Windows.Forms.DataGridView Photo_Command_Grid;
        private System.Windows.Forms.ComboBox Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo4DataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox_Client_Oid;
        private ClientListDataSet clientListDataSet;
        private System.Windows.Forms.BindingSource fairValueProClientBindingSource1;
        private ClientListDataSetTableAdapters.FairValueProClientTableAdapter fairValueProClientTableAdapter1;
        private System.Windows.Forms.BindingSource fairValueProClientBindingSource2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Output_Photos;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RichTextBox richTextBox_Progress_Import;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label Label_AssetID;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Label label_P4;
        private System.Windows.Forms.TextBox textBox_AssetId;
        private System.Windows.Forms.TextBox textBox_P1;
        private System.Windows.Forms.TextBox textBox_P2;
        private System.Windows.Forms.TextBox textBox_P3;
        private System.Windows.Forms.TextBox textBox_P4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Import;
      
    }
}

