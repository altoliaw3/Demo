using System;

namespace WebApp_F{
    public partial class ch8_4_2 : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            Response.Write(Request.QueryString["Id"]);
        }
    }
}