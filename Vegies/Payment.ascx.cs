using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Payment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public Label lblAddr { get { return lblAddress; } set { lblAddress = value; } }
    public Label lblPrice { get { return lblTotal; } set { lblTotal = value; } }
    public RadioButton rbC { get { return rbCash; } set { rbCash = value; } }
    public RadioButton rbCC { get { return rbCreditCard; } set { rbCreditCard = value; } }
    public GridView grid { get { return GridView1; } set { GridView1 = value; } }
}