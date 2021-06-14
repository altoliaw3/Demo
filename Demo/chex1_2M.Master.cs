using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS {
    public partial class Main : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void lbn_Car_Click(object sender, EventArgs e) {
            lb_Sub.Text = "This is a book.";
        }
    }
}