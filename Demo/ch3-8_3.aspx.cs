using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ch3_8_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int Sum;
            Sum = MyMethod(10);   //呼叫方法
            Response.Write("1+2+...+10=" + Sum);
        }
        int MyMethod(int N)   //被呼叫的方法
        {
            int i, total = 0;
            for (i = 1; i <= N; i++)
                total = total + i;
            return total;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Result;
            int X = 10;
            Result = Total(X);
            Response.Write("遞迴函數呼叫10!=1×2×3×4×5×6×....×10=" + Result);
        }

        int Total(int N)                //方法名稱
        {
            if (N == 0)
                return 1;
            else
                return N * Total(N - 1);        //方法自己又可以呼叫自己
        }
    }
}