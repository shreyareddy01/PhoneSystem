<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStock.aspx.cs" Inherits="AnStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 516px; width: 592px">
            <asp:Label ID="lblStockID" runat="server" Text="StockID"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server" style="margin-left: 77px" Width="196px"></asp:TextBox>
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblDateOfOrder" runat="server" Text="DateOfOrder"></asp:Label>
            <asp:TextBox ID="txtDateOfOrder" runat="server" style="margin-left: 46px" Width="197px"></asp:TextBox>
            <br />
            <asp:Label ID="lblShipmentDate" runat="server" Text="ShipmentDate"></asp:Label>
            <asp:TextBox ID="txtShipmentDate" runat="server" style="margin-left: 44px" Width="195px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="margin-left: 63px" Width="198px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNumberOfOrder" runat="server" Text="NumberOfOrder"></asp:Label>
            <asp:TextBox ID="txtNumberOfOrder" runat="server" style="margin-left: 29px" Width="195px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNumberShipped" runat="server" Text="NumberShipped"></asp:Label>
            <asp:TextBox ID="txtNumberShipped" runat="server" style="margin-left: 35px" Width="195px"></asp:TextBox>
            <br />
            <asp:Label ID="lblCost" runat="server" Text="Cost"></asp:Label>
            <asp:TextBox ID="txtCost" runat="server" style="margin-left: 97px" Width="201px"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductname" runat="server" Text="Productname"></asp:Label>
            <asp:TextBox ID="txtProductname" runat="server" style="margin-left: 51px" Width="195px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="Active" runat="server" Text="Active" />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
