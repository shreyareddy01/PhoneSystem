using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnStock : System.Web.UI.Page
{
    private object txtStockId;

   
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 StockID;
            Boolean Found = false;
        StockID = Convert.ToInt32(txtStockID);
        Found = AnStock.Find(StockID);
            if (Found == true)
        { //display the value of the properties in the form}

            txtDateOfOrder.Text = AnStock.DateOfOrder;
            txtShipmentDate.Text = AnStock.ShipmentDate;
            txtSupplierID.Text = AnStock.SupplierID;
            txtNumberOfOrder.Text = AnStock.NumberOfOrder;
            txtNumberShipped.Text = AnStock.NumberShipped;
            txtCost.Text = AnStock.Cost;
            txtProductname.Text = AnStock.Productname;


        }
}

public class clsStock
{
    internal object StockId;

        public string DateOfOrder { get; internal set; }
        public string ShipmentDate { get; internal set; }
        public string SupplierID { get; internal set; }
        public string NumberOfOrder { get; internal set; }
        public string NumberShipped { get; internal set; }
        public string Cost { get; internal set; }
        public string Productname { get; internal set; }

        internal bool Find(int stockID)
        {
            throw new NotImplementedException();
        }

        internal EventHandler Valid(string dateOfOrder, string shipmentDate, string supplierID, string numberOfOrder, string numberShipped, string cost, string productname)
        {
            throw new NotImplementedException();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        string Error;
        string DateOfOrder = txtDateOfOrder.Text;
        string ShipmentDate = txtShipmentDate.Text;
        string SupplierID = txtSupplierID.Text;
        string NumberOfOrder = txtNumberOfOrder.Text;
        string NumberShipped = txtNumberShipped.Text;
        string Cost = txtCost.Text;
        string Productname = txtProductname.Text;
        Error=Convert.ToString(AnStock.Valid(DateOfOrder, ShipmentDate, SupplierID, NumberOfOrder, NumberShipped, Cost, Productname));

        if (Error == "")
        {
            AnStock.DateOfOrder = DateOfOrder;
            AnStock.ShipmentDate = ShipmentDate;

            AnStock.SupplierID = SupplierID;
            AnStock.NumberOfOrder = NumberOfOrder;
            AnStock.NumberShipped = NumberShipped;
            AnStock.Cost = Cost;
            AnStock.Productname = Productname;

            Session["AnStock"] = AnStock;
            Response.Write("StockView.axpx");
        }
        {
            Add();
            Response.Redirect("Default.aspx");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //function for adding
    void Add()
    {
       clsStockCollection StockBook = new clsAddressCollection();
        //validate the data on the web form
        string Error = StockBook.ThisStock.valid(txtDateOfOrder.Text, txtShipmentDate.Text, txtSupplierID.Text, txtNumberOfOrder.Text, txtNumberShipped.Text, txtCost.Text, txtProductname.Text);
        if (Error == "")
        {
            StockBook.ThisStock.DateOfOrder = Convert.ToDateTime(txtDateOfOrder.Text);
            StockBook.ThisStock.ShipmentDate = Convert.ToDateTime(txtShipmentDate.Text);
            StockBook.ThisStock.SupplierID = Convert.ToInt32 (txtSupplierID.Text);
            StockBook.ThisStock.NumberOfOrder = Convert.ToInt32 (txtNumberOfOrder.Text);
            StockBook.ThisStock.NumberShipped = Convert.ToInt32 (txtNumberShipped.Text);
            StockBook.ThisStock.Cost = txtCost.Text;
            StockBook.ThisStock.Productname = txtProductname.Text;
            //Add records
            StockBook.Add();
        }
        else
        {
            //report an error
            lblError.Text = "there is problem with the data" + Error;
        }

    }

}
