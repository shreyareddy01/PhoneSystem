using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockID"] = -1;
        Response.Redirect("AnStock.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
}