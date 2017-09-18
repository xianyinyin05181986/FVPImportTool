using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FairValueProImportTool
{
    public enum ImportResultCode
    {
        Success = 0,
        Invalid_Asset_Id = 1,
        Invalid_Client_Oid = 2,
        Could_Not_Find_Photo_On_Local_Disk = 3,
        Convert_File_Error = 4,
        Failed_To_Save_File = 5,
        Unknown = 6
    }
    public class PhotoImporter : IDisposable
    {
        public PhotoImporter(string connectionString)
        {
            LogMessage = "";
            unitOfWork = new UnitOfWork() { ConnectionString = connectionString };
            ResetCounter();
        }


        private Dictionary<ImportResultCode, int> Counter;
        private void CountByCode(ImportResultCode Code)
        {
            int oldvalue;
            int newvalue = 0;
            if (Counter.TryGetValue(Code, out oldvalue))
            {
                newvalue = oldvalue + 1;
            }
            else
                return;
            Counter.Remove(Code);
            Counter.Add(Code, newvalue);

        }

        private UnitOfWork unitOfWork;
        public string LogMessage { get; set; }
        private void Log(string logContent)
        {
            LogMessage = String.Format("{0}{1}{2}", LogMessage, logContent, Environment.NewLine);
        }

        public void ResetCounter()
        {
            Counter = new Dictionary<ImportResultCode, int>();
            foreach (ImportResultCode item in Enum.GetValues(typeof(ImportResultCode)).Cast<ImportResultCode>())
            {
                Counter.Add(item, 0);
            }
        }
        public ImportResultCode InsertPhoto(string assetId, string photoFileName, Guid clientOid)
        {
            ImportResultCode result = ProcessInsertPhoto(assetId, photoFileName, clientOid);
            CountByCode(result);
            return result;
        }
        private ImportResultCode ProcessInsertPhoto(string assetId, string photoFileName, Guid clientOid)
        {
            ImportResultCode result = ImportResultCode.Unknown;
            var validQuery = String.Format("Select [dbo].[AssetRegister].[Asset] into #assetCount From [dbo].[AssetRegister] Where [dbo].[AssetRegister].[AssetId] = '{0}' and [dbo].[AssetRegister].[Client] ='{1}'and [dbo].[AssetRegister].[GCRecord] is null Drop Table #assetCount", assetId, clientOid);
            var validationResult = unitOfWork.ExecuteNonQuery(validQuery);
            if (validationResult < 1)
            {
                result = ImportResultCode.Invalid_Asset_Id;
                return result;
            }
            // Find photo object
            try
            {
                byte[] file;
                try
                {
                    using (var stream = new FileStream(photoFileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            file = reader.ReadBytes((int)stream.Length);
                            if (file == null)
                                result = ImportResultCode.Could_Not_Find_Photo_On_Local_Disk;
                        }
                    }
                }
                catch (Exception)
                {
                    result = ImportResultCode.Could_Not_Find_Photo_On_Local_Disk;
                    return result;
                }

                // Create File Data
                FileData filedata = new FileData(unitOfWork)
                {
                    FileName = photoFileName.Split('\\').LastOrDefault(),
                    Content = file
                };
                filedata.Save();
                unitOfWork.CommitChanges();

                if (filedata.Oid != Guid.Empty)
                {
                    //3. Execute None Query To Insert File
                    string queryFormat = @"exec [dbo].[InsertPhotoForAsset] '{0}','{1}','{2}','{3}'";
                    var query = String.Format(queryFormat, assetId, photoFileName.Split('\\').LastOrDefault(), filedata.Oid, clientOid);
                    var r = unitOfWork.ExecuteNonQuery(query);
                    result = ImportResultCode.Success;
                    return result;
                }

                Log(String.Format("Insert Photo file of '{0}' For Asset {1} Failed!", photoFileName, assetId));
                result = ImportResultCode.Failed_To_Save_File;
            }
            catch (Exception e)
            {
                Log(e.Message);
                Log(e.StackTrace);
                result = ImportResultCode.Convert_File_Error;

            }
            return result;
        }
        public void Dispose()
        {
            if (unitOfWork != null)
            {
                unitOfWork = null;
            }
            if (unitOfWork != null)
            {
                unitOfWork.Dispose();
                unitOfWork = null;
            }
        }

        public string GetImportSummary()
        {
            StringBuilder sb = new StringBuilder();

            foreach (ImportResultCode item in Enum.GetValues(typeof(ImportResultCode)).Cast<ImportResultCode>())
            {
                int c;
                if (Counter.TryGetValue(item, out c))
                {
                    sb.AppendFormat("{0}:{1}{2}", item, c, Environment.NewLine);
                }
            }
            return sb.ToString();
        }
    }
}
#region T-SQL

//USE [fvp-database]
//GO
//-- =============================================
//-- Author:		Yinyin Xian
//-- Create date: 3rd Dec 2016
//-- Description:	Insert Photo using AssetId,ClientOid 
//-- =============================================
///****** Object:  StoredProcedure [dbo].[InsertPhotoForAsset]    Script Date: 4/12/2016 12:52:12 AM ******/
//DROP PROCEDURE [dbo].[InsertPhotoForAsset]
//GO
//-- =============================================================================================
//-- Create Stored Procedure Template for Azure SQL Database and Azure SQL Data Warehouse Database
//-- =============================================================================================
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO

//CREATE PROCEDURE [dbo].[InsertPhotoForAsset]
//    -- Add the parameters for the stored procedure here
//    @assetId nvarchar(100),
//    @filename nvarchar(100),
//    @fileDataOid uniqueidentifier,
//    @clientOid uniqueidentifier
//AS
//BEGIN
//    -- SET NOCOUNT ON added to prevent extra result sets from
//    -- interfering with SELECT statements.
//    SET NOCOUNT ON;

//    Declare @assetOid uniqueidentifier
//    ,@groupOid uniqueidentifier

//    Select @assetOid = [dbo].[AssetRegister].[Asset],
//            @groupOid = [dbo].[AssetRegister].[FairValueProGroup]
//    From [dbo].[AssetRegister]
//    Where [dbo].[AssetRegister].[AssetId] =@assetId 
//    and [dbo].[AssetRegister].[Client] =@clientOid
//    and [dbo].[AssetRegister].[GCRecord] is null

//    Print (@assetOid)
//    IF @assetOid is null
//    Return 

//    -- Insert statements for procedure here

//    Declare @filenameToinsert nvarchar(100)


//    IF Exists
//    (
//        Select [dbo].[UploadDocument].[Name]
//        From [dbo].[UploadDocument]
//        Where [dbo].[UploadDocument].[Asset] =@assetOid and [dbo].[UploadDocument].[Name] =@filename
//    )
//        Begin

//            Select @filenameToinsert = [dbo].[UploadDocument].[Name] +'_Copy'
//            From [dbo].[UploadDocument]
//            Where [dbo].[UploadDocument].[Asset] = @assetOid

//            Print(@filenameToinsert)
//        End
//    Else
//        Begin
//            Set @filenameToinsert  = @filename
//        End



//    Insert into [dbo].[UploadDocument]
//    (
//        [Oid],
//        [Name],
//        [Commments],
//        [Client],
//        [FairValueProGroup],
//        [UploadFile],
//        [TypeOfDocument],
//        [Asset]
//    )
//    Values
//    (
//        NewId()
//        ,@filenameToinsert
//        ,@filenameToinsert
//        ,@clientOid
//        ,@groupOid
//        ,@fileDataOid
//        ,1
//        ,@assetOid
//    )
//END
//GO



#endregion