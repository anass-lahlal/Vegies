using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Main : System.Web.UI.Page
{
    int total;

    protected void Page_Load(object sender, EventArgs e)
    {





        lblWelcome.Text = Request.QueryString["name"].ToUpper();



        string connectionString = "ConnectionString";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
        con.Open();
        string count = "select count(*) from Items ";


        SqlCommand cmd = new SqlCommand(count, con);
        int temp = Convert.ToInt32(cmd.ExecuteScalar());

        string selectAll = "select * from Items";
        SqlCommand cm = new SqlCommand(selectAll, con);
        SqlDataReader reader = cm.ExecuteReader();


        while (reader.Read())
        {

            ItemControl it = (ItemControl)Page.LoadControl("ItemControl.ascx");



            it.pubPath = "~/Images/" + reader.GetValue(3).ToString();


            it.pubItem.Text = reader.GetValue(1).ToString();
            it.pubPrice.Text = reader.GetValue(4).ToString();
            it.pubQuantity.Text = reader.GetValue(2).ToString();
            PlaceHolder1.Controls.Add(it);
            




        }




        reader.Close();

        con.Close();



        if (IsPostBack)
        {
            con.Open();
            string inserDropDownList = "select * from Chart";
            SqlCommand comm = new SqlCommand(inserDropDownList, con);


            string ss = "";
            using (var read = comm.ExecuteReader())
            {
                while (read.Read())
                {


                    int a = Convert.ToInt32(read.GetValue(2).ToString());
                    string c = read.GetValue(3).ToString();
                    total += (a * Convert.ToInt32(c.ToString()));
                    lblPrice.Text = "Total price: " + total.ToString();
                    ss = read.GetValue(1).ToString() + "   " + read.GetValue(2).ToString();
                    


                }

            }

            DropDownList1.Items.Add(ss);

            con.Close();



        }



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

    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        string name = Request.QueryString["name"];
        string price = Request.QueryString[lblPrice.Text];
        Response.Redirect("CheckOut.aspx?name=" + name);
        
    }









   
}