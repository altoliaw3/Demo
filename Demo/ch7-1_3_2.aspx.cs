using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_1_3_2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            double d_Chin = 85;
            double d_Math = 78;
            double d_Eng = 62;
            Response.Write("國文:" + d_Chin.ToString() + "<br />");
            Response.Write("數學:" + d_Math.ToString() + "<br />");
            Response.Write("英文:" + d_Eng.ToString() + "<br />");

            Response.Flush();
            HttpContext.Current.Response.SuppressContent = true;
            HttpContext.Current.ApplicationInstance.CompleteRequest();
            double d_Avg = (d_Chin + d_Math + d_Eng) / 3;
            Response.Write("平均:" + d_Avg);
        }
    }
}