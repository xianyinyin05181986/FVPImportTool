using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FairValueProImportTool
{
    public class StoreProcedureProcessor : IDisposable
    {
        public void Dispose()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }
        public StoreProcedureProcessor(string connectionString)
        {
            sqlConnection = new SqlConnection() { ConnectionString = connectionString };
            sqlConnection.Open();
        }
        private SqlConnection sqlConnection;

        public StoredProcedureCode RunStoredProcedure(string newId, string oldId, Guid clientOid, string procedureName = "Update_AssetId_By_ClientOid_OldAssetID")
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = procedureName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("clientOid", clientOid));
                    cmd.Parameters.Add(new SqlParameter("oldId", oldId));
                    cmd.Parameters.Add(new SqlParameter("newId", newId));
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.Connection = sqlConnection;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    StringBuilder logbd = new StringBuilder();
                    var resultvalue = Double.Parse(result.ToString());
                    if (resultvalue == 1)
                    {
                        logbd.AppendFormat("{0}=>{1} done.",oldId,newId);
                        OperationLoger.WriteLogToResult(logbd.ToString());
                        return StoredProcedureCode.Completed;
                    }
                    if (resultvalue > 1)
                    {
                        logbd.AppendFormat("{0}=>{1} done. More than one rows affected", oldId, newId);
                        OperationLoger.WriteLogToResult(logbd.ToString());
                        return StoredProcedureCode.Warning;
                    }
                    if (resultvalue == 0)
                    {
                        logbd.AppendFormat("{0}=>{1} not process. Not found old Id ", oldId, newId);

                        OperationLoger.WriteLogToResult(logbd.ToString());
                        return StoredProcedureCode.Warning;
                    }
                    return StoredProcedureCode.Error;
                }
                catch (Exception)
                {
                    return StoredProcedureCode.Error;
                }


                
            }
        }

    }

    public enum StoredProcedureCode
    {
        Error,
        Warning,
        Completed
    }
}
