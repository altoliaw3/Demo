using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_2_1_2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write("老師為: "+Request.QueryString["name"]+"<br />");
            Response.Write("身分證為: " + Request.QueryString["id"] + "<br />");
        }
    }
}