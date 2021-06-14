using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch7_3_2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_Name = "";
            string s_Id = "";
            
            if (Session["name"] != null) {
                Response.Write("會議室ID" + Session.SessionID + " <br />");

                s_Name = (string) Session["name"];
                Response.Write("保存客戶端姓名" + s_Name + " <br />");
            }
            else {
                Response.Write("保存客戶端姓名-會議室已遺失<br />");
            }

            if (Session["id"] != null) {
                s_Id = (string)Session["id"];
                Response.Write("保存客戶端ID" + s_Id + " <br />");
            }
            else {
                Response.Write("保存客戶端ID-會議室已遺失<br />");
            }
        }
    }
}