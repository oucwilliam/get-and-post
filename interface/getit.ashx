<%@ WebHandler Language="C#" Class="getit" %>

using System;
using System.Web;
using System.Data;
public class getit : IHttpHandler {
    static sqlsentence SQL = new sqlsentence();
    public void ProcessRequest (HttpContext context)
    {
        int id = Convert.ToInt32(context.Request.QueryString["id"]);
        string sql = "select * from Books where id = '" + id + "'";
        DataTable dt = new DataTable();
        SQL.sqldt(sql, dt);
        string BookName = Convert.ToString( dt.Rows[0][1]);
        string Author = Convert.ToString( dt.Rows[0][2]);
        int AllAmount = Convert.ToInt32( dt.Rows[0][3]);
        int Available = Convert.ToInt32( dt.Rows[0][4]);
        context.Response.ContentType = "text/plain";
        context.Response.Write("您选择的是'" + Author + "' 的 '" + BookName + "'，剩余'" + Available + "'/'" + AllAmount + "'");
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}