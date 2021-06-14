using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo {
    public partial class chex2_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                lb_Out.Text = "Page_LoadOut";
                lb_In.Text = "Page_LoadIn";
            }                     
        }

        protected void btn_Sub_Click(object sender, EventArgs e) {
            lb_Out.Text = "btn_LoadOut";
            lb_In.Text = "btn_LoadIn";
        }
    }
}