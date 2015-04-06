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
        public static string itemN;
        public static String itemQ;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) //First Load
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
                
            }
            else
            {
               
            }
            //lblQty.Text = "";

            //btnConfirm.Attributes.Add("onclick", "return ConfirmOnDelete()");
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
                    itemN = dr["ItemName"].ToString();
                    itemQ = dr["Qty"].ToString();
                    btnAdd.Visible = true;
                    btnTake.Visible = true;

                    lblAddQty.Visible = false;
                    tbQty.Visible = false;
                    btnConfirm.Visible = false;
                }
                else
                {
                    btnAdd.Visible = false;
                    btnTake.Visible = false;

                    btnConfirm.Visible = false;
                    lblAddQty.Visible = false;
                    tbQty.Visible = false;
                }
                dr.Close();
            }
            conn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            lblAddQty.Visible = true;
            tbQty.Visible = true;
            DropDownList1.SelectedValue = itemN;
            lblQty.Text = itemQ;
            //lblItem.Text = itemN;
            //lblQuantity.Text = itemQ;

            btnAdd.Visible = false;
            btnTake.Visible = false;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbQty.Text=="")
            {
                //btnConfirm.Attributes.Add("onclick", "return ConfirmOnDelete()");
                //Response.Write(@"<script language='javascript'>alert('Textbox is empty.');</script>");

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(),
            "alertMessage",
            "alert('Please fill in add quantity correctly and click confirm button again.  Thanks');", true);
               
            }
            else
            {
                ScriptManager.RegisterStartupScript(this,this.GetType(), "temp","javascript:calopen("+tbQty.Text+");",true);
                string confirmValues = Request.Form["confirmss"];
                if (confirmValues == "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
                }


                //OnConfirm();

                //btnConfirm.OnClientClick = @"return Confirm();";
                //btnConfirm.Attributes.Add("onclick", "return Confirm()"); 
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
            }
        }

        public void OnConfirm() //public void OnConfirm(object sender, EventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
            }
        }

    }
}