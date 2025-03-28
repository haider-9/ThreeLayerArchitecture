using System.Data;
using System.Data.SqlClient;

public class DBconn
{
    public SqlConnection conn;
    public DBconn()
    {
        conn = new SqlConnection(@"Data Source=SAMREEN-ASHRAF\MSSQLSERVER01;Database=StudentDB;Initial Catalog=True");
    }
    public int DUI(string qry)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand(qry, conn);
        return cmd.ExecuteNonQuery();

    }
    public SqlDataReader search(string qry)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand(qry, conn);
        SqlDataReader rdr = cmd.ExecuteReader();
        return rdr;
    }
    public DataTable searchConnectionless(string qry)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand(qry, conn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
   
}