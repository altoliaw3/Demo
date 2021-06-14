using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_1_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write(DateTime.Now.ToString()  + "<br />");
        }
    }
}