using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_3_3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["name"] != null || Session["id"] != null) {
                Session.Abandon();
                Response.Write("Session已被摧毀<br />");
            }
            else {
                Response.Write("沒有Session<br />");
            }
        }
    }
}