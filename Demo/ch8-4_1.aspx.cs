using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch8_4_1 : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ddl_Sort_SelectedIndexChanged(object sender, EventArgs e) {
            gv_Show.Sort(ddl_Sort.SelectedValue, SortDirection.Descending);
        }

        protected void gv_Show_SelectedIndexChanged(object sender, EventArgs e) {
            Label o_Label = (Label)
                            (gv_Show.SelectedRow.Cells[3]).FindControl("Label1");
            lb_Msg.Text = "你所選擇的為" +
                gv_Show.SelectedRow.Cells[2].Text +
                o_Label.Text +
                gv_Show.SelectedRow.Cells[4].Text;
        }

        protected void gv_Show_RowCommand(object sender, GridViewCommandEventArgs e){            
            if (e.CommandName == "Cal") {
                int i_Row = Convert.ToInt32(e.CommandArgument);
                DateTime o_DT = (DateTime.Parse(gv_Show.Rows[i_Row]
                                .Cells[4].Text).AddDays(2));
                lb_Msg.Text = o_DT.ToString();
            }
        }
    }
}