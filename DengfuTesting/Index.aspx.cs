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
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((string)Session["uName"] == null)
            //{
            //    Response.Redirect("~/Login.aspx");
            //}

            if (!IsPostBack)
            {

                lblSession.Text = "Welcome " + (string)Session["uName"];
                

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
                conn.Open();
                string sqlselect = "Select Count(*) from inventoryTable where Qty = '" + qtyTextBox.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlselect, conn);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    qtyLabel.Text = "Data already Exist";
                    //Response.Write("Data already Exist");
                }
                else
                {
                    //qtyLabel.Text = "Data Updated";
                }
                conn.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
                conn.Open();
                string updateQuery = "Update inventoryTable set Qty = @qty where itemName = '"+DropDownList1.SelectedItem+"'";
                //string updateQuery = "Update into inventoryTable (ItemName, Qty) Values (@itemName, @qty)";
                SqlCommand updatecmd = new SqlCommand(updateQuery, conn);
               // updatecmd.Parameters.AddWithValue("@itemName", DropDownList1.SelectedItem);
                updatecmd.Parameters.AddWithValue("@qty", qtyTextBox.Text);
                try
                {
                updatecmd.ExecuteNonQuery();
                Response.Redirect(Request.RawUrl);//Refresh the page
                }
                catch(Exception)
                {
                }
                
                qtyLabel.Text = "Update successfully";
                conn.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error " + ex.ToString());
            }
                
        }

        protected void SqlDataSourceInventoryList_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
                conn.Open();
                //string updateQuery = "Update inventoryTable set Qty = @qty where itemName = '" + DropDownList1.SelectedItem + "'";
                string insertQuery = "Update inventoryTable set Qty = Qty + '"+insertTextBox.Text +"' where itemName = '"+DropDownList2.SelectedItem+"' ";
                SqlCommand updatecmd = new SqlCommand(insertQuery, conn);
                // updatecmd.Parameters.AddWithValue("@itemName", DropDownList1.SelectedItem);
               // updatecmd.Parameters.AddWithValue("@qty", qtyTextBox.Text);
                try
                {
                    updatecmd.ExecuteNonQuery();
                    Response.Redirect(Request.RawUrl);//Refresh the page
                }
                catch (Exception)
                {
                }

                qtyLabel.Text = "Update successfully";
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error " + ex.ToString());
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["inventoryListConnectionString"].ConnectionString);
                conn.Open();
                string deleteQuery = "Update inventoryTable set Qty = Qty - '" + deleteTextBox.Text + "' where itemName = '" + DropDownList3.SelectedItem + "' ";
                SqlCommand deletecmd = new SqlCommand(deleteQuery, conn);
                try
                {
                    deletecmd.ExecuteNonQuery();
                    Response.Redirect(Request.RawUrl);//Refresh the page
                }
                catch (Exception)
                {
                }

                qtyLabel.Text = "Update successfully";
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error " + ex.ToString());
            }
        }
    }
}