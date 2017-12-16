using System.Data;
using System.Data.SqlClient;

/// <summary>
/// sql 的摘要说明
/// </summary>
public class sqlsentence
{
    static string str = @"server=DESKTOP-DU96QJS;Integrated Security=SSPI;database=test;";
    public sqlsentence()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public void sqlIDU(string sql)
    {
        SqlConnection con = new SqlConnection(str);
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    
    public int sqlSelect(string sql)
    {
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        int count = dt.Rows.Count;
        return count;
    }

     public DataTable sqldt(string sql,DataTable dt)
    {
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        return dt;
    }
}