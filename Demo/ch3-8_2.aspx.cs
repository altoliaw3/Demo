using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ch3_8_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int X, Y;
            X = 5;
            Y = 10;
            Response.Write("「傳值呼叫」呼叫前<hr>");
            Response.Write("X=" + X + "　　　" + "Y=" + Y + "<br>");
            CallByValue(X, Y);
            Response.Write("「傳值呼叫」呼叫後<hr>");
            Response.Write("X=" + X + "　　　" + "Y=" + Y + "<br>");
        }
        void CallByValue(int A, int B)
        {
            A = 15;
            B = 30;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int X, Y;
            X = 5;
            Y = 10;
            Response.Write("「傳參考呼叫」呼叫前<hr>");
            Response.Write("X=" + X + "　　　" + "Y=" + Y + "<br>");
            CallByReference(ref X, ref Y);
            Response.Write("「傳參考呼叫」呼叫後<hr>");
            Response.Write("X=" + X + "　　　" + "Y=" + Y + "<br>");
        }
        void CallByReference(ref int A, ref int B)
        {
            A = 15;
            B = 30;
        }
    }
}