using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string connectionString ="ConnectionString";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
        con.Open();
        string checkUser = "select count(*) from Account where name='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'";
        SqlCommand cmd = new SqlCommand(checkUser, con);
        int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        if (temp == 1)
        {
            string name = txtUsername.Text;
            Response.Redirect("Main.aspx?name=" + name);
        }

        else
        {
            lblWarning.Visible = true;

        }
        con.Close();
    }
}