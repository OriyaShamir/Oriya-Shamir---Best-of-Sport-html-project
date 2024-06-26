using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for DBHelper
/// this class manege the connection to the Data Bage
/// it can return a query resault ro exequte a query;
/// </summary>


public class DBHelper
{
    private string connectionstring = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                    @"Data Source = "+ HttpContext.Current.Server.MapPath("\\DemoDB.accdb") + "; " +
                    @"Persist Security Info=False;";
    
    /// <summary>
    /// default constractor use the defaiult connection string
    /// </summary>
    public DBHelper()
    {

    }

    public DataTable GetTableByName (string TableName)
    {
        OleDbConnection connection = GetConnectionToTheDB();
        if (connection == null)
            return null;
        string query = String.Format("select * from {0};", TableName);
        OleDbCommand command = new OleDbCommand(query, connection);
        OleDbDataAdapter d = new OleDbDataAdapter(command);
        DataSet ds = new DataSet();
        d.Fill(ds);
        connection.Close();
        return ds.Tables[0];
    }
    public OleDbConnection GetConnection()
    {
        OleDbConnection conn = new OleDbConnection();
        // add a connection string to the connection
        if (this.connectionstring == "") { return null; }
        conn.ConnectionString = this.connectionstring;
        try
        {
            //open the connection to the data base
            conn.Open();
            return conn;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public DataSet GetDataSet(string query)
    {
        OleDbConnection connection = GetConnection();
        if (connection == null)
            return null;

        OleDbCommand c = new OleDbCommand(query, connection);
        OleDbDataAdapter d = new OleDbDataAdapter(c);
        DataSet ds = new DataSet();
        d.Fill(ds);
        return ds;
    }

    public DataTable GetDataTable(string query)
    {
        try
        {
            OleDbConnection connection = GetConnectionToTheDB();
            if (connection == null)
                return null;

            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter d = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            d.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }
        catch (Exception)
        {
            //catch the error (if there is an error while connecting.
            return null;

        }
    }


    public void SetConnection(string s)
    {
        this.connectionstring = s;
    }

    public OleDbConnection GetConnectionToTheDB()
    {
        if (this.connectionstring == "")
        {
            return null;
        }

        OleDbConnection connection = new OleDbConnection();
        connection.ConnectionString = this.connectionstring;
        try
        {
            //open the connection to the data base
            connection.Open();
            return connection;

        }
        catch (Exception)
        {
            //catch the error (if there is an error while connecting.
            return null;

        }
    }

    public int ExecuteNonQuery(string sql)
    {
        OleDbConnection connection = new OleDbConnection(sql);
        OleDbCommand command = new OleDbCommand(sql, connection);
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        connection.Close();
        return rowsAffected;
    }
}
