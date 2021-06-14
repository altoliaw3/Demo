using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_2_2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write("客戶端連線Server端的IP為-"+ 
                Request.ServerVariables["REMOTE_ADDR"].ToString());
        }
    }
}