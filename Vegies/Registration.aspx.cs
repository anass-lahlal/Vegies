using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string connectionString = "ConnectionString";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            con.Open();
            string checkUser = "select count(*) from Account where name='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(checkUser, con);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (temp == 1)
            {
                lblExist.Visible = true;
            }
            con.Close();
        }

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            string connectionString = "ConnectionString";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            con.Open();
            string insertQuery = "insert into Account (name,email,password,address,phone) values (@name,@email,@password,@address,@phone)";
            SqlCommand comm = new SqlCommand(insertQuery, con);
            comm.Parameters.AddWithValue("@name", txtName.Text);
            comm.Parameters.AddWithValue("@email", txtEmail.Text);
            comm.Parameters.AddWithValue("@password", txtPass.Text);
            comm.Parameters.AddWithValue("@address", txtAddress.Text);
            comm.Parameters.AddWithValue("@phone", Convert.ToInt32(txtPhone.Text));
            comm.ExecuteNonQuery();
            string name = txtName.Text;
            Response.Redirect("Main.aspx?name=" + name);
            con.Close();
        }

        catch (Exception ex)
        {
            Response.Write("Error:" + ex.ToString());
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtPhone.Text = "";
        txtPass.Text = "";
        txtName.Text = "";
        txtEmail.Text = "";
        txtConfirm.Text = "";
        txtAddress.Text = "";
    }
}