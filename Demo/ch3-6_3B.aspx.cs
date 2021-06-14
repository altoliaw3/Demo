using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ch3_6_3B : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int i, j;

            Response.Write("題目：九九乘法表的程式" + "<br>");
            Response.Write("<table border=4>");
            for (i = 1; i <= 9; i++)
            {
                Response.Write("<tr>");
                for (j = 1; j <= 9; j++)
                    Response.Write("<td>" + i + "*" + j + "=" + i * j + "</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
    }
}