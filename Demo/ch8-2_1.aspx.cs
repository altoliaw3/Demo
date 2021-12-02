using System;
using System.Data.SqlClient;

namespace WebApp_F {
    public partial class ch8_2_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string s_ConnS = "";
            //Data Source=(localdb)\MSSQLLocalDB;
            //Initial Catalog=Test;
            //Integrated Security=True;
            //Connect Timeout=30;Encrypt=False;
            //TrustServerCertificate=False;
            //ApplicationIntent=ReadWrite;MultiSubnetFailover=False;
            //User ID = sa; Password = 12345

            /*s_ConnS = "Data Source=(localdb)\\ProjectsV13;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"+
                "User ID = sa; Password = 12345";*/
            s_ConnS = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"+
                "User ID = sa; Password = 12345";

            try {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                //各種資料庫操作
                Response.Write("Connected");
                o_Conn.Close();
            }
            catch (Exception o_Exc) {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}