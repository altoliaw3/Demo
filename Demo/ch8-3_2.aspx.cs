using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApp_F {
    public partial class ch8_3_2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_ConnS = "";

            s_ConnS = "Data Source=(localdb)\\ProjectsV13;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";

            try {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                SqlDataAdapter o_A = new SqlDataAdapter( "Select * from Users", o_Conn);
                DataSet o_D = new DataSet();
                o_A.Fill(o_D, "ds_Res");
                gv_DataShow.DataSource = o_D;
                gv_DataShow.DataBind();              
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}