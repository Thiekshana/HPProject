using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using DengfuTesting.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DengfuTesting.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
            conn.Open();
            string sqlexisits = "Select Count(*) from UserDataTable where userName = '" + userNameTextBox.Text + "' ";
            SqlCommand cmd = new SqlCommand(sqlexisits, conn);

            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp == 1)
            {
                lblusername.Text = "UserName Already Exists, Please try other user names";
                //Response.Write("Data already Exist");
            }
            else
            {
                lblusername.Text = "UserName Created Successfully";
            }
            conn.Close();

            
        }
    }
}