using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class ItemList : System.Web.UI.Page
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HPDatabase1"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                recall();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ItemName from ItemListTable", conn);
                using (IDataReader drselect = cmd.ExecuteReader())
                {
                    DropDownList1.DataSource = drselect;
                    DropDownList1.DataBind();
                    DropDownList1.Items.Insert(0, new ListItem("Please select items", ""));
                    drselect.Close();
                }
                conn.Close(); 
                
            } //end ispostback 
            lblQty.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            recall();
        }
        public void recall()
        {
            conn.Open();
            SqlCommand qtycmd = new SqlCommand("Select ItemName, Qty from ItemListTable where ItemName = '"+DropDownList1.SelectedValue.ToString().Trim()+"' ", conn);
           // qtycmd.Parameters.AddWithValue("@selectedItem", DropDownList1.SelectedValue.ToString());
            using (SqlDataReader dr = qtycmd.ExecuteReader())
            {
                //if (dr.HasRows)
                if (dr.Read())
                {
                    lblQty.Text = dr["Qty"].ToString();
                }
                dr.Close();
            }
            conn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}