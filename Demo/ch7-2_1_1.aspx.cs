using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_2_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_Name = "霸道總柴";
            string s_Id = "A123456789";
            Response.Redirect(("ch7-2_1_2?name=" +
                                            Server.UrlEncode(s_Name) + "&" +
                                         "id=" + Server.UrlEncode(s_Id)
                               ),
                               false) ;
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}