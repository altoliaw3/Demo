using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApp_F {
    public partial class ch8_3_4 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try{                              
                SqlConnection o_Conn = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString
                    );             
                SqlDataAdapter o_A = new SqlDataAdapter();           
                o_Conn.Open();
                SqlCommand o_Cmd = new SqlCommand("SELECT * FROM Users ", o_Conn);
                o_A.SelectCommand = o_Cmd;
                DataSet o_D = new DataSet();
                o_A.Fill(o_D, "ds_Res");
                gv_DataShow.DataSource = o_D;
                gv_DataShow.DataBind();
                o_Conn.Close();
            }
            catch (Exception o_Exc){
                Response.Write(o_Exc.ToString());
            }
        }
    }
}