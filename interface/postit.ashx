<%@ WebHandler Language="C#" Class="posit" %>

using System;
using System.Web;
using System.Data;
public class posit : IHttpHandler
{
    static sqlsentence SQL = new sqlsentence();
    public void ProcessRequest(HttpContext context)
    {
        string Username = context.Request.Form["Username"].ToString();
        string Phone = context.Request.Form["Phone"].ToString();
        string sql = "select * from Users where username = N'" + Username + "' and Phone = '" + Phone + "'";
        DataTable dt = new DataTable();
        SQL.sqldt(sql, dt);
        int count = dt.Rows.Count;
        if (count == 0)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("用户名或手机号错误");
        }
        else
        {
            string password =  Convert.ToString( dt.Rows[0][2]);
            context.Response.ContentType = "text/plain";
            context.Response.Write("您的密码是：" + password + "");
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}