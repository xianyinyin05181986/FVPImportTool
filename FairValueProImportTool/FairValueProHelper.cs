﻿using DevExpress.DataAccess.Native.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FairValueProImportTool
{
    public partial class FairValueProHelper : DevExpress.XtraBars.TabForm
    {
        private const string STR_CONNECTION_STRING = "Server=tcp:me5cd2w04s.database.windows.net;Initial Catalog=fvp-database;User ID=fairvaluepro;Password=VTS344david;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=55;";
        public FairValueProHelper()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a ExcelDataSource
            excelDataSource2.Fill();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            FairValueProHelper form = new FairValueProHelper();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private PhotoImporter _Importer;
        private PhotoImporter Importer
        {
            get
            {
                if (_Importer == null)
                {
                    //initialize

                    _Importer = new PhotoImporter(STR_CONNECTION_STRING);
                }
                return _Importer;
            }
        }
        private string DestinationFolderPath;

        private FileOperator _FileOperator;
        public FileOperator FileOperator
        {
            get
            {
                if (_FileOperator == null)
                {
                    _FileOperator = new FileOperator();
                }
                return _FileOperator;
            }
        }

        public bool IsExport
        {
            get;
            set;
        }
        //public Guid ClientOid1 { get => clientOid; set => clientOid = value; }
        //public Guid ClientOid2 { get => clientOid; set => clientOid = value; }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientObject.FairValueProClient' table. You can move, or remove it, as needed.
            this.fairValueProClientTableAdapter.Fill(this.clientObject.FairValueProClient);
            sqlDataSource1.Connection.ConnectionString = STR_CONNECTION_STRING;
            sqlDataSource1.Fill();

        }

        private void Log(string content)
        {
            OperationLoger.WriteLogToResult(content, "ImportPhoto");
            //LogBox.AppendText(String.Format("{0}:  {1} {2}", DateTime.Now.ToString("dd-MMM-yyyy HH-MM-ss"), content, Environment.NewLine));
        }


        private void ExcelFilerichTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(richTextBox_SelectExecl_Import.Text) && !String.IsNullOrWhiteSpace(richTextBox_SelectExecl_Import.Text))
            {
                try
                {
                    excelDataSource2.FileName = richTextBox_SelectExecl_Import.Text;
                    excelDataSource2.RebuildResultSchema();

                    Photo_Command_Grid.Refresh();
                    excelDataSource2.Fill();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Could not load the excel file into grid. Please check all the column headers. ");
                }
            }
        }


        #region Rename Process
        private void SelectRenameIDButton_Click(object sender, EventArgs e)
        {
            if (SelectRenameFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 
                tb_filename.Text = SelectRenameFileDialog.FileName;
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var r = ClientlookUpEdit.GetSelectedDataRow() as DataRowView;
            if (r != null)
            {
                tb_client_Oid.Text = r.Row.ItemArray[0].ToString();
            }
        }

        private void bt_Process_Click(object sender, EventArgs e)
        {
            //tb_filename
            if (String.IsNullOrEmpty(tb_filename.Text) || String.IsNullOrWhiteSpace(tb_filename.Text))
            {

                MessageBox.Show("Select Command File!");
                tb_filename.BackColor = Color.MediumVioletRed;
                return;
            }
            if (String.IsNullOrEmpty(tb_client_Oid.Text) || String.IsNullOrWhiteSpace(tb_client_Oid.Text))
            {

                MessageBox.Show("Select Client!");
                tb_client_Oid.BackColor = Color.MediumVioletRed;
                return;
            }
            RenameBackGroudWorker.RunWorkerAsync();
        }

        private void tb_client_Oid_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_client_Oid.Text) && !String.IsNullOrWhiteSpace(tb_client_Oid.Text))
            {
                tb_client_Oid.BackColor = Color.White;
            }
        }

        private void tb_filename_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_filename.Text) && !String.IsNullOrWhiteSpace(tb_filename.Text))
            {
                tb_filename.BackColor = Color.White;
            }
        }

        private void Refresh_gridControl()
        {
            if (!String.IsNullOrEmpty(SelectRenameFileDialog.FileName) && !String.IsNullOrWhiteSpace(SelectRenameFileDialog.FileName))
            {
                AssetId_Old_New.FileName = SelectRenameFileDialog.FileName;
                AssetId_Old_New.RebuildResultSchema();
                New_And_Old_gridControl.RefreshDataSource();
                AssetId_Old_New.Fill();
            }
            else
            {
                MessageBox.Show("Invalid File Path");
                return
                    ;
            }
        }
        private void bt_Refresh_grid_Click(object sender, EventArgs e)
        {
            Refresh_gridControl();
        }

        private void RenameBackGroudWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var spp = new StoreProcedureProcessor(STR_CONNECTION_STRING))
            {
                var view = New_And_Old_gridControl.Views[0] as GridView;
                RenameBackGroudWorker.ReportProgress(1);

                var clientoid = tb_client_Oid.Text;
                if (view != null)
                {
                    for (int i = 0; i < view.RowCount; i++)
                    {
                        var row = view.GetDataRow(i);
                        var oldIdcolumn = view.Columns.ColumnByFieldName("Old");
                        var newIdcolumn = view.Columns.ColumnByFieldName("New");
                        var oldid = view.GetRowCellValue(i, oldIdcolumn).ToString();
                        var newid = view.GetRowCellValue(i, newIdcolumn).ToString();

                        var result = spp.RunStoredProcedure(newid, oldid, new Guid(clientoid));

                        RenameBackGroudWorker.ReportProgress(i / view.RowCount * 100);
                    }
                }
            }
        }

        private void RenameBackGroudWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RenameProgressBar.Value = e.ProgressPercentage;
        }

        private void RenameBackGroudWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RenameProgressBar.Value = RenameProgressBar.Maximum;
            RenameProgressBar.ForeColor = Color.YellowGreen;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(OperationLoger.FilePath);
            //OperationLoger.WriteLogToResult("1st");
            //OperationLoger.WriteLogToResult("2nd");
            //OperationLoger.WriteLogToResult("3rd");
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog_Import.InitialDirectory = "D:\\";
            openFileDialog_Import.FilterIndex = 2;
            openFileDialog_Import.RestoreDirectory = true;
            if (openFileDialog_Import.ShowDialog() == DialogResult.OK)
            {
                richTextBox_SelectExecl_Import.Text = openFileDialog_Import.FileName;
                richTextBox_SelectExecl_Import.BackColor = Color.White;
            }
            else
            {
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Import.ShowDialog() == DialogResult.OK)
            {
                richTextBox_SelectFolder_Import.Text = folderBrowserDialog_Import.SelectedPath;
                richTextBox_SelectFolder_Import.BackColor = Color.White;
            }
            else
                return;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox_SelectFolder_Import.Text) || String.IsNullOrWhiteSpace(richTextBox_SelectFolder_Import.Text))
                richTextBox_SelectFolder_Import.BackColor = Color.Red;
            if (String.IsNullOrEmpty(richTextBox_SelectExecl_Import.Text) || String.IsNullOrWhiteSpace(richTextBox_SelectExecl_Import.Text))
                richTextBox_SelectExecl_Import.BackColor = Color.Red;
        }

        private void FairValueProHelper_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientListDataSet.FairValueProClient' table. You can move, or remove it, as needed.
            this.fairValueProClientTableAdapter1.Fill(clientListDataSet.FairValueProClient);

        }

        private void Validate_Click(object sender, EventArgs e)
        {
            ValidateImportPhotos();

        }
        private Guid clientOid;
        protected bool ValidateImportPhotos()
        {
            bool result = true;
            if (String.IsNullOrEmpty(richTextBox_SelectExecl_Import.Text) || String.IsNullOrWhiteSpace(richTextBox_SelectExecl_Import.Text))
            {
                richTextBox_SelectExecl_Import.BackColor = Color.Red;
                result = false;
            }
            if (String.IsNullOrEmpty(richTextBox_SelectFolder_Import.Text) || String.IsNullOrWhiteSpace(richTextBox_SelectFolder_Import.Text))
            {
                richTextBox_SelectFolder_Import.BackColor = Color.Red;
                result = false;
            }
            if (Client.SelectedItem == null)
            {
                result = false;
            }
            if (Client.SelectedValue == null)
            {
                result = false;
            }
            if (!Guid.TryParse(Client.SelectedValue.ToString(), out clientOid))
            {
                result = false;
            }
            return result;
        }

        private void Client_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Client.SelectedValue != null)
            {
                richTextBox_Client_Oid.Text = Client.SelectedValue.ToString();
            }

            if (!String.IsNullOrEmpty(richTextBox_Client_Oid.Text) && !String.IsNullOrWhiteSpace(richTextBox_Client_Oid.Text))
                richTextBox_Client_Oid.BackColor = Color.White;
            else
                richTextBox_Client_Oid.BackColor = Color.Red;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (!ValidateImportPhotos())
                return;
            if (!SelectDestinationFolderForExportPhoto())
                return;

            PhotoImportProgressBar.BackColor = Color.White;

            backgroundWorker_Export.RunWorkerAsync();
        }
        protected bool SelectDestinationFolderForExportPhoto()
        {

            if (folderBrowserDialog_Output_Photos.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DestinationFolderPath = folderBrowserDialog_Output_Photos.SelectedPath;
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read folder from disk. Original error: " + ex.Message);
                    return
                        false;
                }

            }
            else
            {
                return false;
            }
        }



        private void backgroundWorker_Export_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PhotoImportProgressBar.Value = PhotoImportProgressBar.Maximum;
            PhotoImportProgressBar.BackColor = Color.LightBlue;
            MessageBox.Show(FileOperator.GetExportSummary());
            FileOperator.ResetCounter();
            this.Invoke((MethodInvoker)delegate ()
            {
                tabFormPage1.Enabled = true;
            });

        }

        private void backgroundWorker_Export_DoWork(object sender, DoWorkEventArgs e)
        {

            // Lock Grid

            //string text;
            //this.Invoke(() => text = combobox.Text);
            var rows = Photo_Command_Grid.Rows;
            string folderpahtcontent = null;
            string prefixcontent = null;
            this.Invoke((MethodInvoker)delegate ()
            {
                folderpahtcontent = richTextBox_SelectFolder_Import.Text;
                prefixcontent = tx_Prefix.Text;
                tabFormPage1.Enabled = false;
            });
            foreach (DataGridViewRow row in rows)
            {
                int index = rows.IndexOf(row);

                //OperationLoger.WriteLogToResult(String.Format("Row {0}--{1} ", index, row.Cells.GetCellValueFromColumnHeader(textBox_AssetId.Text).ToString()), "Export");

                ExportRow(folderpahtcontent, prefixcontent, row, textBox_AssetId.Text, textBox_P1.Text, textBox_P2.Text, textBox_P3.Text, textBox_P4.Text);

                backgroundWorker_Export.ReportProgress((index + 1) / rows.Count * 100);
            }
        }

        protected string ExportRow(string folderpahtcontent, string prefixcontent, DataGridViewRow row, string assetid, string p1, string p2, string p3, string p4)
        {
            var processResult = new StringBuilder();
            if (!String.IsNullOrEmpty(assetid) && !String.IsNullOrWhiteSpace(assetid))
            {
                string assetIdcontent = row.Cells.GetCellValueFromColumnHeader(assetid).ToString();

                if (!String.IsNullOrEmpty(p1) && !String.IsNullOrWhiteSpace(p1))
                {
                    var p1content = row.Cells.GetCellValueFromColumnHeader(p1).ToString();
                    if (!String.IsNullOrEmpty(p1content) && !String.IsNullOrWhiteSpace(p1content))
                    {
                        ExportCell(assetIdcontent, p1content, folderpahtcontent, prefixcontent);
                    }
                }
                if (!String.IsNullOrEmpty(p2) && !String.IsNullOrWhiteSpace(p2))
                {
                    object rowCellsGetCellValueFromColumnHeader = row.Cells.GetCellValueFromColumnHeader(p2);
                    if (rowCellsGetCellValueFromColumnHeader != null)
                    {
                        var p2content = rowCellsGetCellValueFromColumnHeader.ToString();
                        if (!String.IsNullOrEmpty(p2content) && !String.IsNullOrWhiteSpace(p2content))
                        {
                            ExportCell(assetIdcontent, p2content, folderpahtcontent, prefixcontent);
                        }
                    }
                }
                if (!String.IsNullOrEmpty(p3) && !String.IsNullOrWhiteSpace(p3))
                {
                    object rowCellsGetCellValueFromColumnHeader3 = row.Cells.GetCellValueFromColumnHeader(p3);
                    if (rowCellsGetCellValueFromColumnHeader3 != null)
                    {
                        string p3content = rowCellsGetCellValueFromColumnHeader3.ToString();
                        ExportCell(assetIdcontent, p3content, folderpahtcontent, prefixcontent);
                    }
                }
                if (!String.IsNullOrEmpty(p4) && !String.IsNullOrWhiteSpace(p4))
                {
                    object rowCellsGetCellValueFromColumnHeader4 = row.Cells.GetCellValueFromColumnHeader(p4);
                    if (rowCellsGetCellValueFromColumnHeader4 != null)
                    {
                        string p4content = rowCellsGetCellValueFromColumnHeader4.ToString();
                        ExportCell(assetIdcontent, p4content, folderpahtcontent, prefixcontent);
                    }
                }
            }
            return processResult.ToString();
        }

        protected void ImportRow(string folderpahtcontent, string prefixcontent, DataGridViewRow row, string assetid, string p1, string p2, string p3, string p4)
        {
            if (!String.IsNullOrEmpty(assetid) && !String.IsNullOrWhiteSpace(assetid))
            {
                string assetIdcontent = row.Cells.GetCellValueFromColumnHeader(assetid).ToString();
                if (!String.IsNullOrEmpty(p1) && !String.IsNullOrWhiteSpace(p1))
                {
                    object rowCellsGetCellValueFromColumnHeader1 = row.Cells.GetCellValueFromColumnHeader(p1);
                    if (rowCellsGetCellValueFromColumnHeader1 != null)
                    {
                        string p1content = rowCellsGetCellValueFromColumnHeader1.ToString();
                        if (!String.IsNullOrEmpty(p1content) && !String.IsNullOrWhiteSpace(p1content))
                            ImportCell(assetIdcontent, p1content, folderpahtcontent, prefixcontent);
                    }
                }
                if (!String.IsNullOrEmpty(p2) && !String.IsNullOrWhiteSpace(p2))
                {
                    string p2content = row.Cells.GetCellValueFromColumnHeader(p2).ToString();
                    if (!String.IsNullOrEmpty(p2content) && !String.IsNullOrWhiteSpace(p2content))
                        ImportCell(assetIdcontent, p2content, folderpahtcontent, prefixcontent);
                }
                if (!String.IsNullOrEmpty(p3) && !String.IsNullOrWhiteSpace(p3))
                {
                    string p3content = row.Cells.GetCellValueFromColumnHeader(p3).ToString();
                    if (!String.IsNullOrEmpty(p3content) && !String.IsNullOrWhiteSpace(p3content))
                        ImportCell(assetIdcontent, p3content, folderpahtcontent, prefixcontent);
                }
                if (!String.IsNullOrEmpty(p4) && !String.IsNullOrWhiteSpace(p4))
                {
                    string p4content = row.Cells.GetCellValueFromColumnHeader(p4).ToString();
                    if (!String.IsNullOrEmpty(p4content) && !String.IsNullOrWhiteSpace(p4content))
                        ImportCell(assetIdcontent, p4content, folderpahtcontent, prefixcontent);
                }
            }
        }

        private ImportResultCode ImportCell(string assetid, string p, string photoFolderPath, string prefix = null)
        {
            ImportResultCode result = ImportResultCode.Convert_File_Error;
            if (!(String.IsNullOrWhiteSpace(p) || String.IsNullOrEmpty(p)))
            {
                if (String.IsNullOrWhiteSpace(photoFolderPath) || String.IsNullOrEmpty(photoFolderPath))
                {
                    OperationLoger.WriteLogToResult(String.Format("No Photo folder {0} Found For {1}", p, assetid), "Import");
                }
                else
                {
                    string photo1FullPhotoFilePath = PhotoFilePathFactory.GenerateFullPhotoFilePath(photoFolderPath, p, prefix, false);
                    result = Importer.InsertPhoto(assetid, photo1FullPhotoFilePath, clientOid);
                }

            }
            switch (result)
            {
                case ImportResultCode.Unknown:
                case ImportResultCode.Convert_File_Error:
                case ImportResultCode.Invalid_Client_Oid:
                case ImportResultCode.Failed_To_Save_File:
                case ImportResultCode.Invalid_Asset_Id:
                    OperationLoger.WriteLogToResult(String.Format("Error for {0},{1}", assetid, result), "Import");
                    break;
                case ImportResultCode.Could_Not_Find_Photo_On_Local_Disk:
                    OperationLoger.WriteLogToResult(String.Format("Error for {0},{1} at {2}", assetid, result, photoFolderPath), "Import");
                    break;
                case ImportResultCode.Success:
                    OperationLoger.WriteLogToResult(String.Format("{0} has been uploaded to  asset:{1}", photoFolderPath, assetid), "Import");
                    break;
                default:
                    break;

            }
            return result;
        }

        protected FileOperationCode ExportCell(string assetid, string p, string photoFolderPath, string prefix = null)
        {
            FileOperationCode result = FileOperationCode.Unknown;
            if (!(String.IsNullOrWhiteSpace(p) || String.IsNullOrEmpty(p)))
            {
                if (String.IsNullOrWhiteSpace(photoFolderPath) || String.IsNullOrEmpty(photoFolderPath))
                {
                    result = FileOperationCode.Error_Old_File_Not_Exists;
                }
                else
                {
                    string sourceFilePath;
                    if (String.IsNullOrEmpty(prefix) || String.IsNullOrWhiteSpace(prefix))
                    {
                        sourceFilePath = PhotoFilePathFactory.GenerateFullPhotoFilePath(photoFolderPath, p, false);
                    }
                    else
                    {
                        sourceFilePath = PhotoFilePathFactory.GenerateFullPhotoFilePath(photoFolderPath, p, prefix, false);
                    }
                    string destinationPath = PhotoFilePathFactory.GenerateFullPhotoFilePath(DestinationFolderPath, assetid, false);
                    result = FileOperator.Export(sourceFilePath, destinationPath, true);
                    switch (result)
                    {
                        case FileOperationCode.Copied:
                            OperationLoger.WriteLogToResult(String.Format("Successfully Copied {0} to {1}", sourceFilePath, destinationPath), "Export");
                            break;
                        case FileOperationCode.Error_New_File_Exists:
                            OperationLoger.WriteLogToResult(String.Format("Error for AssetId : {0} Copied {1} because {2} exists", assetid, sourceFilePath, destinationPath), "Export");
                            break;
                        case FileOperationCode.Error_Old_File_Not_Exists:
                            OperationLoger.WriteLogToResult(String.Format("Error AssetId : {0} Copying {1} faied because it does not exist", assetid, sourceFilePath), "Export");
                            break;
                        default:
                            OperationLoger.WriteLogToResult(String.Format("Error AssetId : {0} failed, unknown reason", assetid), "Export");
                            break;
                    }

                }
            }
            return result;
        }
        private void backgroundWorker_Export_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            PhotoImportProgressBar.Value = e.ProgressPercentage;
            richTextBox_Progress_Import.Text = String.Format("{0}%", e.ProgressPercentage);
        }

        private void bt_Import_Click(object sender, EventArgs e)
        {
            if (!ValidateImportPhotos())
                return;
            if (!ConfirmationMessage())
                return;
            //clientOid = new Guid(richTextBox_Client_Oid.Text);
            PhotoImportProgressBar.BackColor = Color.White;
            backgroundWorker_Import.RunWorkerAsync();

        }
        private bool ConfirmationMessage()
        {

            return MessageBox.Show("Start Import Photos will be processed now.Yes?", "Confirmation Message", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("See you next time :)", "Quit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void backgroundWorker_Import_DoWork(object sender, DoWorkEventArgs e)
        {
            var rows = Photo_Command_Grid.Rows;
            string folderpahtcontent = null;
            string prefixcontent = null;
            this.Invoke((MethodInvoker)delegate ()
            {
                folderpahtcontent = richTextBox_SelectFolder_Import.Text;
                prefixcontent = tx_Prefix.Text;
                tabFormPage1.Enabled = false;
                tabFormPage2.Enabled = false;

            });
            foreach (DataGridViewRow row in rows)
            {
                int index = rows.IndexOf(row);
                backgroundWorker_Import.ReportProgress((index + 1) / rows.Count * 100);
                ImportRow(folderpahtcontent, prefixcontent, row, textBox_AssetId.Text, textBox_P1.Text, textBox_P2.Text, textBox_P3.Text, textBox_P4.Text);

            }
        }

        private void backgroundWorker_Import_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PhotoImportProgressBar.Value = e.ProgressPercentage;
            richTextBox_Progress_Import.Text = String.Format("{0}%", e.ProgressPercentage);
        }

        private void backgroundWorker_Import_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PhotoImportProgressBar.Value = PhotoImportProgressBar.Maximum;
            PhotoImportProgressBar.BackColor = Color.LightBlue;

            MessageBox.Show("Import Finish");

            this.Invoke((MethodInvoker)delegate ()
            {
                tabFormPage1.Enabled = true;
                tabFormPage2.Enabled = true;
            });

        }

    }
}

