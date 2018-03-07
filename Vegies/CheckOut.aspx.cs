using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOut : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string tc = Request.QueryString["name"];
        lblWelcome.Text = Request.QueryString["name"].ToUpper();




        string connectionString = "ConnectionString";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
        con.Open();

        string cmdLine = "select address from Account where name = '" + tc + "'";
        SqlCommand cmd = new SqlCommand(cmdLine, con);
        string name = cmd.ExecuteScalar().ToString();

        Payment1.lblAddr.Text = "Mr. " + tc +", your delivery will be sent to this address : " +name ;
        int price = 0;
        for (int i = 0; i < Payment1.grid.Rows.Count; i++)
        {
            price += Convert.ToInt32(Payment1.grid.Rows[i].Cells[1].Text) * Convert.ToInt32(Payment1.grid.Rows[i].Cells[2].Text);
            
        }

        Payment1.lblPrice.Text = price.ToString() + " TL";
        lblPrice.Text = "Total price : " + price + " TL";
        con.Close();

    }


    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        string connectionString = "ConnectionString";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
        con.Open();
        string deleteAll = "truncate table Chart";
        SqlCommand sc = new SqlCommand(deleteAll, con);
        sc.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Login.aspx");
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        string connectionString = "ConnectionString";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
        con.Open();
        string deleteAll = "truncate table Chart";
        SqlCommand sc = new SqlCommand(deleteAll, con);
        sc.ExecuteNonQuery();
        con.Close();
        string name = Request.QueryString["name"];
        Response.Redirect("Main.aspx?name=" + name);

    }
}
