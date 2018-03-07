using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

public partial class ItemControl : System.Web.UI.UserControl
{
    
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
       



    }
    public Label pubItem { get { return lblItem; } set { lblItem = value; } }
    public Panel pubPanel { get { return Panel1 ; } set { Panel1 = value; } }
    public Label pubPrice { get { return lblPrice; } set { lblPrice = value; } }
    public String pubPath { get { return Image1.ImageUrl; } set { Image1.ImageUrl = value; } }

    public Label pubQuantity { get { return lblQuantity; } set { lblQuantity = value; } }




    public Button pubButton { get { return btnAdd; } set { btnAdd = value; } }
    
   


    
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        try
        {
            string connectionString = "ConnectionString";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            con.Open();
            string checkUser = "select count(*) from Chart where item_name='" + lblItem.ToString() + "'";

            int quan = 0;
            string getQuantity = "select quantity from Items where item_name = '" + lblItem.Text + "'";
            SqlCommand updateQuantity = new SqlCommand(getQuantity, con);
            using (SqlDataReader dr = updateQuantity.ExecuteReader())
            {
                while (dr.Read())
                {
                    quan = Convert.ToInt32(dr[0].ToString());
                }
            }

            int newQuan = quan - Convert.ToInt32(txtQuantity.Text);
            string otherTable = "update Items set quantity = '" + newQuan.ToString() + "' where item_name ='" + lblItem.Text.ToString() + "'";
            SqlCommand updateTable = new SqlCommand(otherTable, con);
            updateTable.ExecuteNonQuery();


            SqlCommand cmd = new SqlCommand(checkUser, con);
            int temp = 0; 

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    temp = Convert.ToInt32(dr[0].ToString());
                }
            }


            if (temp == 1)
            {
                int itemQuan = 0;
                string inserDropDownList = "select quantity from Chart where item_name = '" + lblItem.Text + "'";
                SqlCommand com = new SqlCommand(inserDropDownList, con);
                using (SqlDataReader dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                         itemQuan = Convert.ToInt32(dr[0].ToString());
                    }
                }
                int other = itemQuan + Convert.ToInt32(lblQuantity.Text);
                string insertQuan = "UPDATE Chart SET quantity ='" + other.ToString() + "' WHERE item_name='" + lblItem.Text.ToString() + "'";
                com.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                string insertQuery = "insert into Chart (item_name,quantity,price) values (@item,@quant,@pri)";
                SqlCommand comm = new SqlCommand(insertQuery, con);
                comm.Parameters.AddWithValue("@item", lblItem.Text);
                comm.Parameters.AddWithValue("@quant", txtQuantity.Text);
                comm.Parameters.AddWithValue("@pri", lblPrice.Text);
                comm.ExecuteNonQuery();
                con.Close();
            }
        }

        catch (Exception ex)
        {
            Response.Write("Error:" + ex.ToString());
        }

        txtQuantity.Text = "0";





    }
}