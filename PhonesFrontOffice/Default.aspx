<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 564px; width: 604px">
    <form id="form1" runat="server">
        <div style="height: 561px">
            <asp:ListBox ID="ListBox1" runat="server" Height="316px" Width="584px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="213px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            <br />
        </div>
    </form>
</body>
</html>
