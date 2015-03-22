using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DengfuTesting
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
            conn.Open();
            string sqlselect = "Select Count(*) from UserDataTable where userName = '" + userNameTextBox.Text + "' ";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Session["uName"] = userNameTextBox.Text;
                Response.Redirect("~/Index.aspx");
                //Response.Write("Data already Exist");
            }
            else
            {
                //lblUsername.Text = "Wrong UserName";
            }
            conn.Close();
        }
    }
}