using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F
{
    public partial class ch3_1_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int aver = 90, tmpresult= Convert.ToInt32((aver / 10));
            string result = "";

            if (tmpresult<=10 && tmpresult >= 0)
            {
                if (tmpresult == 10 || tmpresult == 9)
                {
                    result = "優等生";
                }
                else if (tmpresult == 8)
                {
                    result = "甲等生";
                }
                else if (tmpresult == 7)
                {
                    result = "乙等生";
                }
                else if (tmpresult == 6)
                {
                    result = "丙等生";
                }
                else
                {
                    result = "要重修了";
                }
            }
            Response.Write(result);
        }
    }
}