using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch3_5_4 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int Average = 0;
            String Result;
            Average = 50;
            if (Average < 60)
                Result = "丁等生";
            else if (Average >= 60 && Average < 70)
                Result = "丙等生";
            else if (Average >= 70 && Average < 80)
                Result = "乙等生";
            else if (Average >= 80 && Average < 90)
                Result = "甲等生";
            else
                Result = "優等生";
            Response.Write(Result);
        }
    }
}