using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch5_10 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            mv_Show.ActiveViewIndex = 1;
            mu_Tag.Items[1].Selected = true;
        }

        protected void Button2_Click(object sender, EventArgs e) {
            mv_Show.ActiveViewIndex = 0;
            mu_Tag.Items[0].Selected = true;
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e) {
            mv_Show.ActiveViewIndex = Convert.ToInt32( mu_Tag.SelectedValue );
        }
    }
}