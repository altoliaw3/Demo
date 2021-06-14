using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_4_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int i_Counter = 0;
            if (Application["Counter"] != null) {
                i_Counter= (int) Application["Counter"];
                i_Counter++;
                Application["Counter"] = i_Counter;
            }
            else {
                i_Counter++;
                Application["Counter"] = i_Counter;
            }
            Response.Write("目前有多少連線已對該網頁產生請求(request) &nbsp;"+ 
                            i_Counter.ToString());
        }
    }
}