using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ch10_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){

        }

        protected void ddl_Users_SelectedIndexChanged(object sender, EventArgs e){
            lb_Txt.Text = "你選擇了"+ ddl_Users.SelectedValue;
        }
    }
}