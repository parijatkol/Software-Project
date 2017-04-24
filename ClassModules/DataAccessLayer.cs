using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DataAccessLayer
{
    #region GlobalObjectsAndVariables
    
    public string StrTablename, Name, strCon, AutoGenID;
    public int Id, UserId, RowCount, ColCount, TableCount, LoginSucceed, LastID;
    public SqlConnection con;
    public SqlCommand cmd;
    public SqlDataAdapter da;
    public DataSet ds;
    public SqlDataReader dr;
    public DataTable dt;
    public SqlParameter Param, GeneratedId,LoginSuccess;
    string OutputId;

    
    
    #endregion

    #region Connection
    public SqlConnection CreateConnection()
    {
        try
        {
            strCon = ConfigurationManager.ConnectionStrings["Inventory_DBConnectionString"].ConnectionString;
            //strCon = "Data Source=WWT;Initial Catalog=Inventory_DB;User Id=sa;Password=manager2010;integrated security=true";
            //strCon = "Data Source=LAPTOP;Initial Catalog=Inventory_DB;User Id=sa;Password=manager2010;integrated security=true";
            //strCon = "Data Source=PERSONAL\\PERSONAL;Initial Catalog=Inventory_DB;User Id=sa;Password=dipakmaiti";

            //DbConnection con = new DbConnection("File Name=" + Server.MapPath("\\Conn.udl"));

//            MessageBox.Show(Application.StartupPath);
//            MessageBox.Show(System.IO.Path.GetPathRoot("Connection"));
//            MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().ToString());


            con = new SqlConnection(strCon);
            con.Open();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
        }
        return con;
    }
    #endregion

    #region Dataset
    public DataSet PopulateDataSet(string StrSql, string StrTableName)
    {
        try
        {
            da = new SqlDataAdapter(StrSql, CreateConnection());
            ds = new DataSet("MyDataSet");
            da.Fill(ds, StrTableName);
        }
        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
            con.Close();
            con.Dispose();
        }
        return ds;
    }

    public DataSet ExecuteDatasetUsingParameter(String SpName, IDataParameter[] Params)
    {
        try
        {
            cmd = new SqlCommand(SpName, CreateConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (IDataParameter param in Params)
                cmd.Parameters.Add(param);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet("MyDataSet");
            da.Fill(ds, "StrTableName");
        }

        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return ds;
    }

    public DataSet ExecuteDatasetUsingParameter1(String SpName, IDataParameter[] Params)
    {
        try
        {
            //Procedure2 that return the DataSet
            da = new SqlDataAdapter(SpName, CreateConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
    
            foreach (IDataParameter param in Params)
                da.SelectCommand.Parameters.Add(param);

            ds = new DataSet("MyDataSet");
            da.Fill(ds, "StrTableName");
        }

        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return ds;
    }
   
    public string OutputParam(String SpName, IDataParameter[] Params)
    {
        try
        {
            cmd = new SqlCommand(SpName, CreateConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (IDataParameter param in Params)
                cmd.Parameters.Add(param);

            GeneratedId = cmd.Parameters.Add("@GeneratedId", SqlDbType.VarChar, 200);
            GeneratedId.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            OutputId = cmd.Parameters["@GeneratedId"].Value.ToString();
        }

        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return OutputId;
    }

   
    #endregion
    
    #region DataReader
    
    public SqlDataReader GetDataReader(string SpName)
    {
        try
        {
            cmd = new SqlCommand(SpName, CreateConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            //if (con.State==ConnectionState.Open)
            //    con.Close();
            //else
            //    con.Open();

            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        catch (SqlException exception)
        {
            SqlError err;
            err = exception.Errors[0];
            string ErrorMessage = err.Message + err.Number + err.Source + err.State;
        }

        finally
        {
        }

        return dr;
    }

    #endregion

    #region DataTable

    //public DataTable PopulateDataTable()
    //{
    //    try
    //    {
    //        da = new SqlDataAdapter(StrSql, CreateConnection());
    //        ds = new DataSet("MyDataSet");
    //        da.Fill(ds, "StrTableName");
    //        RowCount = ds.Tables[0].Rows.Count;
    //        ColCount = ds.Tables[0].Columns.Count;
    //        dt = new DataTable("StrTableName");
    //        ds.Tables.Add(dt);
    //        ColCount = dt.Columns.Count;
    //        RowCount = dt.Rows.Count;
    //        con.Open();

    //    }
    //    catch (Exception err)
    //    {

    //        throw new ApplicationException(err.Source.ToString());

    //    }
    //    finally
    //    {
    //        con.Close();
    //        con.Dispose();
    //    }
    //    return dt;
    //}
    #endregion

    # region DataAdapter

    public SqlDataAdapter PopulateData(string SQL)
    {
        SqlDataAdapter populateData = new SqlDataAdapter(SQL, CreateConnection());
        return populateData;
    }
    #endregion

    #region InsertUpdateDeleteData

    public int SqlInsertUpdateDeleteData(String StrSql)
    {
        try
        {
            cmd = new SqlCommand(StrSql, CreateConnection());
            cmd.ExecuteNonQuery();
        }
    
        catch (Exception err)
        {
            throw new ApplicationException(err.Source.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return Id;
    }

    public int InsertUpdateDeleteData(String SpName, IDataParameter[] Params)
    {
        cmd = new SqlCommand(SpName, CreateConnection());
        cmd.CommandType = CommandType.StoredProcedure;
     
        foreach (IDataParameter param in Params)
            cmd.Parameters.Add(param);

        Param = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int, 4);
        Param.Direction = ParameterDirection.ReturnValue;

        try
        {
            cmd.ExecuteNonQuery();
            Id = (int)cmd.Parameters["@ReturnValue"].Value;
        }

        catch (Exception ex)
        {
            Exception oException = ex.GetBaseException();

            throw new ApplicationException(oException.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return Id;
    }

    public int CheckLogin(String SpName, IDataParameter[] Params)
    {
            cmd = new SqlCommand(SpName, CreateConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (IDataParameter param in Params)
                cmd.Parameters.Add(param);

            Param = cmd.Parameters.Add("@LoginSuccess", SqlDbType.Int,1);
            Param.Direction = ParameterDirection.ReturnValue;

            try
            {
                cmd.ExecuteNonQuery();
                LoginSucceed = (int) cmd.Parameters["@LoginSuccess"].Value;
            }
            catch (SqlException exception)
            {
                Exception oException =exception.GetBaseException();
                throw new ApplicationException(oException.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return LoginSucceed;
    }
    
    public int DeleteUserGroup(int UserGroupId)
    {
        cmd = new SqlCommand("SP_DeleteUserGroup ", CreateConnection());
        cmd.CommandType = CommandType.StoredProcedure;
        Param = cmd.Parameters.Add("@UserGroupId", SqlDbType.Int, 4);
        Param.Value = UserGroupId;
        Param.Direction = ParameterDirection.Input;
        
        try
        {
            //con.Open();
            cmd.ExecuteNonQuery();
        }

        catch (Exception err)
        {
            throw new ApplicationException(err.Source.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return Id;
    }

    public string AutoCode(string StrSql)
    {
        try
        {
            cmd = new SqlCommand(StrSql, CreateConnection());
            AutoGenID = (string)cmd.ExecuteScalar();
        }

        catch (Exception err)
        {
            throw new ApplicationException(err.Source.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }
        return AutoGenID;
    }

    public int GetLastID(string StrSql)
    {
        try
        {
            cmd = new SqlCommand(StrSql, CreateConnection());
            LastID = (int)cmd.ExecuteScalar();
        }

        catch (Exception err)
        {
            throw new ApplicationException(err.Source.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }
        return LastID;
    }

    
    #endregion

    #region Report

    #endregion

    #region UserInfo
    
    public int GetUserId(String SpName, IDataParameter[] Params)
    {
        cmd = new SqlCommand(SpName, CreateConnection());
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (IDataParameter param in Params)
            cmd.Parameters.Add(param);

        Param = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int, 4);
        Param.Direction = ParameterDirection.ReturnValue;
        
        try
        {
            ////con.Open();
            cmd.ExecuteNonQuery();
            UserId = (int)cmd.Parameters["@ReturnValue"].Value;
        }

        catch (Exception err)
        {
            throw new ApplicationException(err.Source.ToString());
        }

        finally
        {
            con.Close();
            con.Dispose();
        }

        return UserId;
    }

    #endregion
}
