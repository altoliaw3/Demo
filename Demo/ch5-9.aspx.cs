using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch5_9 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_One_Click(object sender, EventArgs e) {
            pl_1.Visible = !(pl_1.Visible);
        }

        protected void btn_Two_Click(object sender, EventArgs e) {
            pl_2.Visible = !(pl_2.Visible);
        }
    }
}