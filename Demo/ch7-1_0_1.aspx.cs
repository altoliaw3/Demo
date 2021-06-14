using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_1_0 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.BufferOutput= false;
            for (int i_Ct=0; i_Ct < 10; i_Ct++) {
                Response.Write(i_Ct.ToString()+ 
                    "QWERTYUIOASDFGHJKSDFGHJKWERTYUISDFGHJKSDFGHJSDFGH"+"<br />");

                System.Threading.Thread.Sleep(400);
            }
        }
    }
}