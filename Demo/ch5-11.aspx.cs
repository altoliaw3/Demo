using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch5_11 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void wd_Steps_FinishButtonClick(object sender, WizardNavigationEventArgs e) {
            lb_Msg.Text = "";
            lb_Msg.Text = lb_Msg.Text + tb_Name.Text + "<br />";
            lb_Msg.Text = lb_Msg.Text + tb_Mail.Text + "<br />";
            lb_Msg.Text = lb_Msg.Text + tb_Con.Text + "<br />";
        }
    }
}