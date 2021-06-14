using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch6_6 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_Sumbit_Click(object sender, EventArgs e) {
            if (Page.IsValid) {
                lb_Msg.Text = tb_Num.Text;
            }
        }

        protected void cv_Num_ServerValidate(object source, ServerValidateEventArgs args) {
            int i_Tmp = Convert.ToInt32(args.Value);
            if (i_Tmp % 2 ==0) {
                args.IsValid = true;
            }
            else {
                args.IsValid = false;
            }
        }
    }
}