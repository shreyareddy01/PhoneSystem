using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Stockview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
            //Display stsock ID
            Response.Write(AnStock.StockId);
    }
}

public class clsStock
{
    internal string StockId;
}